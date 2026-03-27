# Authentication

The Vapi SDK uses Bearer token authentication. You can obtain an API key from your [Vapi dashboard](https://dashboard.vapi.ai/).

## Basic Usage

```csharp
using Vapi;

var client = new VapiClient(apiKey: Environment.GetEnvironmentVariable("VAPI_API_KEY")!);
```

## Environment Variable

| Variable | Description |
|----------|-------------|
| `VAPI_API_KEY` | Your Vapi API key |
