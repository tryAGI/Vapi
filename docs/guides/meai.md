# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Vapi SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models the ability to manage voice AI assistants, calls, and phone numbers via Vapi.

> **Tip:** See the [cross-SDK MEAI comparison](https://tryagi.github.io/docs/guides/meai/) for
> a full list of tryAGI SDKs with MEAI support.

## Installation

```bash
dotnet add package Vapi
```

The `Microsoft.Extensions.AI` package is included as a transitive dependency.

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListAssistantsTool()` | `ListVapiAssistants` | Lists all voice AI assistants. |
| `AsGetAssistantTool()` | `GetVapiAssistant` | Gets details of a specific assistant by ID. |
| `AsCreateAssistantTool()` | `CreateVapiAssistant` | Creates a new voice AI assistant. |
| `AsListCallsTool()` | `ListVapiCalls` | Lists voice AI calls with optional filtering. |
| `AsGetCallTool()` | `GetVapiCall` | Gets details of a specific call by ID. |
| `AsListPhoneNumbersTool()` | `ListVapiPhoneNumbers` | Lists configured phone numbers. |

## Usage

```csharp
using Vapi;
using Microsoft.Extensions.AI;

var vapi = new VapiClient(apiKey);

// Create tools
var tools = new[]
{
    vapi.AsListAssistantsTool(),
    vapi.AsGetAssistantTool(),
    vapi.AsCreateAssistantTool(),
    vapi.AsListCallsTool(),
    vapi.AsGetCallTool(),
    vapi.AsListPhoneNumbersTool(),
};

// Use with any IChatClient
var response = await chatClient.GetResponseAsync(
    "List all my voice AI assistants and their recent calls",
    new ChatOptions { Tools = tools });
```

## Tool Details

### ListVapiAssistants

Lists all Vapi voice AI assistants. Returns assistant IDs, names, first messages, and timestamps.
Accepts a `limit` parameter to control the number of results (default: 20).

```csharp
var tool = vapi.AsListAssistantsTool(limit: 10);
```

### GetVapiAssistant

Gets details of a specific Vapi voice AI assistant by its ID. Returns the assistant's name,
first message, and configuration timestamps.

### CreateVapiAssistant

Creates a new Vapi voice AI assistant with a given name and optional first message.
Returns the created assistant's ID and details.

### ListVapiCalls

Lists Vapi voice AI calls with optional filtering by assistant ID.
Returns call IDs, statuses, types, timestamps, and costs.
Accepts a `limit` parameter to control the number of results (default: 20).

```csharp
var tool = vapi.AsListCallsTool(limit: 50);
```

### GetVapiCall

Gets details of a specific Vapi voice AI call by its ID. Returns call status, type,
timestamps, cost, transcript, and summary.

### ListVapiPhoneNumbers

Lists Vapi phone numbers configured for voice AI calls. Returns phone number details
including IDs and associated configurations.
Accepts a `limit` parameter to control the number of results (default: 20).

```csharp
var tool = vapi.AsListPhoneNumbersTool(limit: 10);
```
