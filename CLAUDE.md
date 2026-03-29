# CLAUDE.md -- Vapi SDK

## Overview

Auto-generated C# SDK for [Vapi](https://vapi.ai/) -- voice AI agent platform for building, managing, and deploying conversational AI phone and web call assistants with real-time transcription, analytics, and tool integrations.
OpenAPI spec downloaded from `https://api.vapi.ai/api-json`.

## Build & Test

```bash
dotnet build Vapi.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new VapiClient(apiKey); // VAPI_API_KEY env var
```

## Key Files

- `src/libs/Vapi/openapi.yaml` -- OpenAPI spec (downloaded from Vapi API)
- `src/libs/Vapi/generate.sh` -- Downloads spec, applies 7 fixes, runs autosdk with `--security-scheme`
- `src/libs/Vapi/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Vapi/Extensions/VapiClient.AsTool.cs` -- MEAI `AIFunction` tools (assistants, calls, phone numbers)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

The `generate.sh` applies 7 fixes to the downloaded spec via `jq`, plus `--security-scheme Http:Header:Bearer` for auth:

1. **LMNTVoice language:** Flattens `oneOf` to simple `string` (oneOf with two enum types produces malformed `OneOf<T1?,T2?>JsonConverter` in `typeof()`; AutoSDK #206)
2. **Operator enums:** Replaces symbols (`=`, `!=`, `>`, `>=`, `<`, `<=`) with descriptive names (`eq`, `neq`, `gt`, `gte`, `lt`, `lte`) to avoid duplicate C# identifiers
3. **Punctuation enums:** Replaces punctuation characters (`!`, `)`, `,`, `:`, `;`, `?`, `|`, `||`, CJK/Devanagari/Arabic) with descriptive names
4. **Missing discriminator mappings:** Adds `code` -> `CreateCodeToolDTO` and `ghl` -> `GhlTool` to tool endpoint discriminators
5. **11labs rename:** Renames `11labs` discriminator key to `elevenlabs` (numeric prefix causes C# naming collisions)
6. **Enum deduplication:** Deduplicates string enum arrays to avoid CS0102 errors
7. **Duplicate parameter rename:** Renames second `name` query param in `/session` GET to `customerName` (two params named `name` — session name and customer name — cause CS0100)

Uses `--exclude-deprecated-operations` flag.

## Sub-client Pattern

Vapi API has tagged operations generating sub-clients:
- `client.Assistants.*` -- Create, list, get, update, delete voice AI assistants
- `client.Calls.*` -- Create, list, get, update, delete voice calls
- `client.PhoneNumbers.*` -- Create, list, get, update, delete phone numbers
- `client.Tools.*` -- Create, list, get, update, delete tools
- `client.Squads.*` -- Create, list, get, update, delete multi-agent squads
- `client.Files.*` -- Upload, list, get, delete files
- `client.Analytics.*` -- Query call analytics and metrics
- `client.Sessions.*` -- Manage chat sessions
- `client.Campaigns.*` -- Manage outbound call campaigns
- `client.Eval.*` -- Evaluation and testing
- `client.Chats.*` -- Chat completions
- `client.StructuredOutputs.*` -- Structured data extraction
- `client.ProviderResources.*` -- Provider resource management
- `client.ObservabilityScorecard.*` -- Observability scoring

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsListAssistantsTool(limit)` -- List all voice AI assistants
- `AsGetAssistantTool()` -- Get assistant details by ID
- `AsCreateAssistantTool()` -- Create a new assistant with name and first message
- `AsListCallsTool(limit)` -- List voice calls with optional assistant filter
- `AsGetCallTool()` -- Get call details including transcript and summary
- `AsListPhoneNumbersTool(limit)` -- List configured phone numbers

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented -- Vapi is a voice AI agent platform with no matching MEAI interface.
