#!/usr/bin/env bash
set -euo pipefail
readonly openapi_url="https://api.vapi.ai/api-json"
dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.yaml

# Fix 1: Add top-level security array so AutoSDK generates bearer auth constructor.
# Fix 2: Replace problematic enum value 'transcript[transcriptType="final"]' with 'transcript-final'
#         (contains embedded quotes that break C# string escaping in generated code).
# Fix 3: Flatten LMNTVoice/FallbackLMNTVoice language oneOf to simple string enum
#         (oneOf with two enum types produces invalid generic type in JsonConverter attribute).
# Fix 4: Replace operator/comparator symbol enum values (=, !=, <, <=, >, >=) with descriptive names
#         (these sanitize to identical 'x_'/'x__' C# identifiers, causing CS0102 duplicate definition errors).
# Fix 5: Replace punctuation character enum values with descriptive names
#         (!, ), ,, :, ;, ?, |, ||, and Unicode punctuation all sanitize to 'x_').
# Fix 6: Add missing 'ghl' and 'code' discriminator mappings to tool endpoint schemas
#         (GhlTool/CodeTool are in oneOf but not in discriminator mapping, causing CS0117).
# Fix 7: Rename '11labs' discriminator value to 'elevenlabs'
#         ('11labs' starts with digit, sanitizes to 'x11labs', causing CS1503 lambda/property conflict).
jq '
  .security = [{"bearer": []}] |

  # Fix transcript enum value
  walk(
    if type == "string" and . == "transcript[transcriptType=\"final\"]"
    then "transcript-final"
    # Fix operator enums
    elif type == "array" and all(type == "string") and any(. == ">=") and any(. == "<=") and any(. == "!=")
    then [.[] | if . == "=" then "eq"
              elif . == "!=" then "neq"
              elif . == ">" then "gt"
              elif . == "<" then "lt"
              elif . == ">=" then "gte"
              elif . == "<=" then "lte"
              else .
              end]
    # Fix punctuation enums
    elif type == "array" and all(type == "string") and any(. == "\u3002" or . == "\uff0c" or . == "\u0964" or . == "\u0965")
    then [.[] | if . == "\u3002" then "cjk-period"
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
              end]
    else .
    end
  ) |

  # Fix LMNT language oneOf
  .components.schemas.LMNTVoice.properties.language |= (del(.oneOf) | .type = "string") |
  .components.schemas.FallbackLMNTVoice.properties.language |= (del(.oneOf) | .type = "string") |

  # Fix 11labs -> elevenlabs in discriminator mappings
  walk(
    if type == "object" and has("discriminator") and .discriminator.mapping["11labs"]?
    then .discriminator.mapping.elevenlabs = .discriminator.mapping["11labs"] | del(.discriminator.mapping["11labs"])
    else .
    end
  ) |

  # Add missing ghl/code discriminator mappings to tool endpoints
  # For request schemas (Create DTOs)
  (.paths["/tool"].post.requestBody.content["application/json"].schema.discriminator.mapping.ghl) = "#/components/schemas/CreateGhlToolDTO" |
  (.paths["/tool"].post.requestBody.content["application/json"].schema.discriminator.mapping.code) = "#/components/schemas/CreateCodeToolDTO" |
  # For response schemas (Tool types)
  (.paths["/tool"].post.responses["201"].content["application/json"].schema.discriminator.mapping.ghl) = "#/components/schemas/GhlTool" |
  (.paths["/tool"].post.responses["201"].content["application/json"].schema.discriminator.mapping.code) = "#/components/schemas/CodeTool" |
  (.paths["/tool"].get.responses["200"].content["application/json"].schema.items.discriminator.mapping.ghl) = "#/components/schemas/GhlTool" |
  (.paths["/tool"].get.responses["200"].content["application/json"].schema.items.discriminator.mapping.code) = "#/components/schemas/CodeTool" |
  (.paths["/tool/{id}"].get.responses["200"].content["application/json"].schema.discriminator.mapping.ghl) = "#/components/schemas/GhlTool" |
  (.paths["/tool/{id}"].get.responses["200"].content["application/json"].schema.discriminator.mapping.code) = "#/components/schemas/CodeTool" |
  (.paths["/tool/{id}"].patch.requestBody.content["application/json"].schema.discriminator.mapping.ghl) = "#/components/schemas/UpdateGhlToolDTO" |
  (.paths["/tool/{id}"].patch.requestBody.content["application/json"].schema.discriminator.mapping.code) = "#/components/schemas/UpdateCodeToolDTO" |
  (.paths["/tool/{id}"].patch.responses["200"].content["application/json"].schema.discriminator.mapping.ghl) = "#/components/schemas/GhlTool" |
  (.paths["/tool/{id}"].patch.responses["200"].content["application/json"].schema.discriminator.mapping.code) = "#/components/schemas/CodeTool" |
  (.paths["/tool/{id}"].delete.responses["200"].content["application/json"].schema.discriminator.mapping.ghl) = "#/components/schemas/GhlTool" |
  (.paths["/tool/{id}"].delete.responses["200"].content["application/json"].schema.discriminator.mapping.code) = "#/components/schemas/CodeTool"
' openapi.yaml > openapi_fixed.yaml && mv openapi_fixed.yaml openapi.yaml

autosdk generate openapi.yaml \
  --namespace Vapi \
  --clientClassName VapiClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
