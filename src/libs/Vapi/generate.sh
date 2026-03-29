#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://api.vapi.ai/api-json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://api.vapi.ai/api-json -o openapi.yaml

# Fix 1: Replace problematic enum value 'transcript[transcriptType="final"]' with 'transcript-final'
#         (contains embedded quotes that break C# string escaping in generated code).
# Fix 2: Flatten LMNTVoice/FallbackLMNTVoice language oneOf to simple string enum
#         (oneOf with two enum types produces invalid generic type in JsonConverter attribute).
# Fix 3: Replace operator/comparator symbol enum values (=, !=, <, <=, >, >=) with descriptive names
#         (these sanitize to identical 'x_'/'x__' C# identifiers, causing CS0102 duplicate definition errors).
# Fix 4: Replace punctuation character enum values with descriptive names
#         (!, ), ,, :, ;, ?, |, ||, and Unicode punctuation all sanitize to 'x_').
# Fix 5: Add missing discriminator mappings for tool endpoints:
#         - "code" -> CreateCodeToolDTO (missing from POST /tool request body)
#         - "ghl" -> GhlTool (missing from all /tool response discriminators)
#         - "code" -> UpdateCodeToolDTO (missing from PATCH /tool/{id} request body)
# Fix 6: Rename "11labs" discriminator key to "elevenlabs" everywhere
#         ("11labs" sanitizes to "x11labs" which collides with the parameter name in generated Match methods).
# Fix 7: Deduplicate enum arrays (DeepgramVoice voiceId, endedReason, etc.)
#         (duplicate values cause CS0102 errors in generated C# enums).
# Fix 8: Rename duplicate 'name' parameter in /session GET to 'customerName'
#         (two query params named 'name' — session name and customer name — cause CS0100).
jq '
  # Fix 5: Add missing discriminator mappings
  .paths["/tool"].post.requestBody.content["application/json"].schema.discriminator.mapping["code"] = "#/components/schemas/CreateCodeToolDTO" |
  .paths["/tool"].post.responses["201"].content["application/json"].schema.discriminator.mapping["ghl"] = "#/components/schemas/GhlTool" |
  .paths["/tool"].get.responses["200"].content["application/json"].schema.items.discriminator.mapping["ghl"] = "#/components/schemas/GhlTool" |
  .paths["/tool/{id}"].get.responses["200"].content["application/json"].schema.discriminator.mapping["ghl"] = "#/components/schemas/GhlTool" |
  .paths["/tool/{id}"].patch.requestBody.content["application/json"].schema.discriminator.mapping["code"] = "#/components/schemas/UpdateCodeToolDTO" |
  .paths["/tool/{id}"].patch.responses["200"].content["application/json"].schema.discriminator.mapping["ghl"] = "#/components/schemas/GhlTool" |
  .paths["/tool/{id}"].delete.responses["200"].content["application/json"].schema.discriminator.mapping["ghl"] = "#/components/schemas/GhlTool" |

  # Fix 8: Rename duplicate "name" param in /session GET (customer name → customerName)
  (.paths["/session"].get.parameters[] |
    select(.name == "name" and (.description | test("customer")))) .name = "customerName" |

  # Fix 2: Flatten LMNTVoice/FallbackLMNTVoice language oneOf
  .components.schemas.LMNTVoice.properties.language |= (del(.oneOf) | .type = "string") |
  .components.schemas.FallbackLMNTVoice.properties.language |= (del(.oneOf) | .type = "string") |

  # Walk the whole spec for remaining fixes
  walk(
    if type == "string" and . == "transcript[transcriptType=\"final\"]"
    then "transcript-final"

    # Fix 6: rename 11labs discriminator keys
    elif type == "object" and has("discriminator") and .discriminator.mapping["11labs"]
    then .discriminator.mapping["elevenlabs"] = .discriminator.mapping["11labs"] | del(.discriminator.mapping["11labs"])

    # Fix 3: operator/comparator enums
    elif type == "array" and (length > 0) and all(type == "string") and any(. == ">=") and any(. == "<=")
    then map(
      if . == "=" then "eq"
      elif . == "!=" then "neq"
      elif . == ">" then "gt"
      elif . == "<" then "lt"
      elif . == ">=" then "gte"
      elif . == "<=" then "lte"
      else .
      end
    )

    # Fix 4: punctuation boundary enums (detect by presence of CJK period)
    elif type == "array" and (length > 0) and all(type == "string") and any(. == "\u3002")
    then map(
      if . == "\u3002" then "cjk-period"
      elif . == "\uff0c" then "cjk-comma"
      elif . == "\u0964" then "devanagari-danda"
      elif . == "\u0965" then "devanagari-double-danda"
      elif . == "\u060c" then "arabic-comma"
      elif . == "\u06d4" then "urdu-period"
      elif . == "!" then "exclamation"
      elif . == "?" then "question"
      elif . == ";" then "semicolon"
      elif . == ")" then "close-paren"
      elif . == "||" then "double-pipe"
      elif . == "|" then "pipe"
      elif . == "," then "comma"
      elif . == ":" then "colon"
      elif . == "." then "period"
      else .
      end
    )

    # Fix 7: Deduplicate any string enum arrays
    elif type == "array" and (length > 0) and all(type == "string")
    then unique

    else .
    end
  )
' openapi.yaml > openapi_fixed.yaml && mv openapi_fixed.yaml openapi.yaml

# Auth: --security-scheme injects bearer auth.
autosdk generate openapi.yaml \
  --namespace Vapi \
  --clientClassName VapiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
