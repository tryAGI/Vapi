#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Vapi;

/// <summary>
/// Extensions for using VapiClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class VapiToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists Vapi assistants.
    /// </summary>
    /// <param name="client">The Vapi client.</param>
    /// <param name="limit">Maximum number of assistants to return.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListAssistantsTool(
        this VapiClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var assistants = await client.Assistants.AssistantControllerFindAllAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(assistants.Select(a => new
                {
                    id = a.Id,
                    name = a.Name,
                    firstMessage = a.FirstMessage,
                    createdAt = a.CreatedAt,
                    updatedAt = a.UpdatedAt,
                }));
            },
            name: "ListVapiAssistants",
            description: "Lists all Vapi voice AI assistants. Returns assistant IDs, names, first messages, and timestamps.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets details of a specific Vapi assistant by ID.
    /// </summary>
    /// <param name="client">The Vapi client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetAssistantTool(this VapiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [System.ComponentModel.Description("The unique identifier of the assistant to retrieve.")]
                string id,
                CancellationToken cancellationToken) =>
            {
                var assistant = await client.Assistants.AssistantControllerFindOneAsync(
                    id: id,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    id = assistant.Id,
                    name = assistant.Name,
                    firstMessage = assistant.FirstMessage,
                    createdAt = assistant.CreatedAt,
                    updatedAt = assistant.UpdatedAt,
                });
            },
            name: "GetVapiAssistant",
            description: "Gets details of a specific Vapi voice AI assistant by its ID. Returns the assistant's name, first message, and configuration.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates a new Vapi assistant with a name and first message.
    /// </summary>
    /// <param name="client">The Vapi client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreateAssistantTool(this VapiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [System.ComponentModel.Description("The name of the assistant to create.")]
                string name,
                [System.ComponentModel.Description("The first message the assistant will say when a call starts. If empty, the assistant waits for the user to speak first.")]
                string? firstMessage,
                CancellationToken cancellationToken) =>
            {
                var assistant = await client.Assistants.AssistantControllerCreateAsync(
                    name: name,
                    firstMessage: firstMessage,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    id = assistant.Id,
                    name = assistant.Name,
                    firstMessage = assistant.FirstMessage,
                    createdAt = assistant.CreatedAt,
                });
            },
            name: "CreateVapiAssistant",
            description: "Creates a new Vapi voice AI assistant with a given name and optional first message. Returns the created assistant's ID and details.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists Vapi calls with optional filters.
    /// </summary>
    /// <param name="client">The Vapi client.</param>
    /// <param name="limit">Maximum number of calls to return.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListCallsTool(
        this VapiClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [System.ComponentModel.Description("Optional assistant ID to filter calls by a specific assistant.")]
                string? assistantId,
                CancellationToken cancellationToken) =>
            {
                var calls = await client.Calls.CallControllerFindAllAsync(
                    assistantId: assistantId,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(calls.Select(c => new
                {
                    id = c.Id,
                    status = c.Status?.ToString(),
                    type = c.Type?.ToString(),
                    assistantId = c.AssistantId,
                    phoneNumberId = c.PhoneNumberId,
                    createdAt = c.CreatedAt,
                    endedAt = c.EndedAt,
                    endedReason = c.EndedReason?.ToString(),
                    cost = c.Cost,
                }));
            },
            name: "ListVapiCalls",
            description: "Lists Vapi voice AI calls with optional filtering by assistant ID. Returns call IDs, statuses, types, timestamps, and costs.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets details of a specific Vapi call by ID.
    /// </summary>
    /// <param name="client">The Vapi client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetCallTool(this VapiClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [System.ComponentModel.Description("The unique identifier of the call to retrieve.")]
                string id,
                CancellationToken cancellationToken) =>
            {
                var call = await client.Calls.CallControllerFindOneAsync(
                    id: id,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    id = call.Id,
                    status = call.Status?.ToString(),
                    type = call.Type?.ToString(),
                    assistantId = call.AssistantId,
                    phoneNumberId = call.PhoneNumberId,
                    createdAt = call.CreatedAt,
                    endedAt = call.EndedAt,
                    endedReason = call.EndedReason?.ToString(),
                    cost = call.Cost,
                    transcript = call.Artifact?.Transcript,
                    summary = call.Analysis?.Summary,
                });
            },
            name: "GetVapiCall",
            description: "Gets details of a specific Vapi voice AI call by its ID. Returns call status, type, timestamps, cost, transcript, and summary.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists Vapi phone numbers.
    /// </summary>
    /// <param name="client">The Vapi client.</param>
    /// <param name="limit">Maximum number of phone numbers to return.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListPhoneNumbersTool(
        this VapiClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var phoneNumbers = await client.PhoneNumbers.PhoneNumberControllerFindAllAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(phoneNumbers.Select(p => new
                {
                    value = p.ToString(),
                }));
            },
            name: "ListVapiPhoneNumbers",
            description: "Lists Vapi phone numbers configured for voice AI calls. Returns phone number details including IDs and associated configurations.");
    }
}
