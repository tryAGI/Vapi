/* order: 20, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace Vapi.IntegrationTests;

public partial class Tests
{
    //// Vapi provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// voice AI assistant management, call operations, and phone number queries.

    [TestMethod]
    public void Meai_AsListAssistantsTool()
    {
        var client = new VapiClient(apiKey: "test-key");

        //// Create a tool that lists voice AI assistants:
        var tool = client.AsListAssistantsTool();

        tool.Name.Should().Be("ListVapiAssistants");
        tool.Description.Should().Contain("assistants");
    }

    [TestMethod]
    public void Meai_AsGetAssistantTool()
    {
        var client = new VapiClient(apiKey: "test-key");

        //// Create a tool that gets assistant details by ID:
        var tool = client.AsGetAssistantTool();

        tool.Name.Should().Be("GetVapiAssistant");
        tool.Description.Should().Contain("assistant");
    }

    [TestMethod]
    public void Meai_AsCreateAssistantTool()
    {
        var client = new VapiClient(apiKey: "test-key");

        //// Create a tool that creates a new voice AI assistant:
        var tool = client.AsCreateAssistantTool();

        tool.Name.Should().Be("CreateVapiAssistant");
        tool.Description.Should().Contain("assistant");
    }

    [TestMethod]
    public void Meai_AsListCallsTool()
    {
        var client = new VapiClient(apiKey: "test-key");

        //// Create a tool that lists voice AI calls:
        var tool = client.AsListCallsTool();

        tool.Name.Should().Be("ListVapiCalls");
        tool.Description.Should().Contain("calls");
    }

    [TestMethod]
    public void Meai_AsGetCallTool()
    {
        var client = new VapiClient(apiKey: "test-key");

        //// Create a tool that gets call details by ID:
        var tool = client.AsGetCallTool();

        tool.Name.Should().Be("GetVapiCall");
        tool.Description.Should().Contain("call");
    }

    [TestMethod]
    public void Meai_AsListPhoneNumbersTool()
    {
        var client = new VapiClient(apiKey: "test-key");

        //// Create a tool that lists phone numbers:
        var tool = client.AsListPhoneNumbersTool();

        tool.Name.Should().Be("ListVapiPhoneNumbers");
        tool.Description.Should().Contain("phone");
    }

    [TestMethod]
    public void Meai_AllToolsCreated()
    {
        var client = new VapiClient(apiKey: "test-key");

        //// All tools can be combined in a single list for use with any IChatClient:
        var tools = new AIFunction[]
        {
            client.AsListAssistantsTool(),
            client.AsGetAssistantTool(),
            client.AsCreateAssistantTool(),
            client.AsListCallsTool(),
            client.AsGetCallTool(),
            client.AsListPhoneNumbersTool(),
        };

        foreach (var tool in tools)
        {
            tool.Should().NotBeNull();
            tool.Name.Should().NotBeNullOrEmpty();
            tool.Description.Should().NotBeNullOrEmpty();
        }
    }
}
