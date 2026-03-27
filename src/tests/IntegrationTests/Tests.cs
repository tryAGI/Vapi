namespace Vapi.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static VapiClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("VAPI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("VAPI_API_KEY environment variable is not found.");

        var client = new VapiClient(apiKey);
        
        return client;
    }
}
