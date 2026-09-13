
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BackoffPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Server))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContentType), TypeInfoPropertyName = "TextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContentLanguage), TypeInfoPropertyName = "TextContentLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomMessageType), TypeInfoPropertyName = "CustomMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.CustomMessage>), TypeInfoPropertyName = "OneOfStringCustomMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferFallbackPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SummaryPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPlanMode), TypeInfoPropertyName = "TransferPlanMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll>), TypeInfoPropertyName = "OneOfContextEngineeringPlanLastNMessagesContextEngineeringPlanNoneContextEngineeringPlanAll2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanLastNMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanAll))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationNumberType), TypeInfoPropertyName = "TransferDestinationNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationSip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationSipType), TypeInfoPropertyName = "TransferDestinationSipType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType), TypeInfoPropertyName = "ContextEngineeringPlanLastNMessagesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanNoneType), TypeInfoPropertyName = "ContextEngineeringPlanNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanAllType), TypeInfoPropertyName = "ContextEngineeringPlanAllType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>), TypeInfoPropertyName = "OneOfTransferDestinationNumberTransferDestinationSip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder), TypeInfoPropertyName = "PaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPhoneNumberHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPhoneNumberHookActionType), TypeInfoPropertyName = "TransferPhoneNumberHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayPhoneNumberHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayPhoneNumberHookActionType), TypeInfoPropertyName = "SayPhoneNumberHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallRingingHookFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallRingingHookFilterType), TypeInfoPropertyName = "PhoneNumberCallRingingHookFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallRingingHookFilterKey), TypeInfoPropertyName = "PhoneNumberCallRingingHookFilterKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallRinging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallRingingOn), TypeInfoPropertyName = "PhoneNumberHookCallRingingOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallRingingHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>), TypeInfoPropertyName = "OneOfTransferPhoneNumberHookActionSayPhoneNumberHookAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterType), TypeInfoPropertyName = "PhoneNumberCallEndingHookFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterKey), TypeInfoPropertyName = "PhoneNumberCallEndingHookFilterKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem), TypeInfoPropertyName = "PhoneNumberCallEndingHookFilterOneOfItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallEnding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallEndingOn), TypeInfoPropertyName = "PhoneNumberHookCallEndingOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>), TypeInfoPropertyName = "OneOfPhoneNumberHookCallRingingPhoneNumberHookCallEnding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoPhoneNumberProvider), TypeInfoPropertyName = "ByoPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoPhoneNumberStatus), TypeInfoPropertyName = "ByoPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioPhoneNumberProvider), TypeInfoPropertyName = "TwilioPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioPhoneNumberStatus), TypeInfoPropertyName = "TwilioPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonagePhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonagePhoneNumberProvider), TypeInfoPropertyName = "VonagePhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonagePhoneNumberStatus), TypeInfoPropertyName = "VonagePhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPhoneNumberProvider), TypeInfoPropertyName = "VapiPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPhoneNumberStatus), TypeInfoPropertyName = "VapiPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TelnyxPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TelnyxPhoneNumberProvider), TypeInfoPropertyName = "TelnyxPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TelnyxPhoneNumberStatus), TypeInfoPropertyName = "TelnyxPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateByoPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateByoPhoneNumberDTOProvider), TypeInfoPropertyName = "CreateByoPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTwilioPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTwilioPhoneNumberDTOProvider), TypeInfoPropertyName = "CreateTwilioPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVonagePhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVonagePhoneNumberDTOProvider), TypeInfoPropertyName = "CreateVonagePhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVapiPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVapiPhoneNumberDTOProvider), TypeInfoPropertyName = "CreateVapiPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTelnyxPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTelnyxPhoneNumberDTOProvider), TypeInfoPropertyName = "CreateTelnyxPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateByoPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateByoPhoneNumberDTOProvider), TypeInfoPropertyName = "UpdateByoPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTwilioPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTwilioPhoneNumberDTOProvider), TypeInfoPropertyName = "UpdateTwilioPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVonagePhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVonagePhoneNumberDTOProvider), TypeInfoPropertyName = "UpdateVonagePhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVapiPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVapiPhoneNumberDTOProvider), TypeInfoPropertyName = "UpdateVapiPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTelnyxPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTelnyxPhoneNumberDTOProvider), TypeInfoPropertyName = "UpdateTelnyxPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>), TypeInfoPropertyName = "OneOfByoPhoneNumberTwilioPhoneNumberVonagePhoneNumberVapiPhoneNumberTelnyxPhoneNumber2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateRequest), TypeInfoPropertyName = "PhoneNumberControllerCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerCreateRequestDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateRequest), TypeInfoPropertyName = "PhoneNumberControllerUpdateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerUpdateRequestDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortOrder), TypeInfoPropertyName = "PhoneNumberControllerFindAllPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortBy), TypeInfoPropertyName = "PhoneNumberControllerFindAllPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateResponse), TypeInfoPropertyName = "PhoneNumberControllerCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerCreateResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberControllerFindAllResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllResponseItem), TypeInfoPropertyName = "PhoneNumberControllerFindAllResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerFindAllResponseItemDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindOneResponse), TypeInfoPropertyName = "PhoneNumberControllerFindOneResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindOneResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindOneResponseDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerFindOneResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateResponse), TypeInfoPropertyName = "PhoneNumberControllerUpdateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerUpdateResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerRemoveResponse), TypeInfoPropertyName = "PhoneNumberControllerRemoveResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerRemoveResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerRemoveResponseDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerRemoveResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContentType?), TypeInfoPropertyName = "NullableTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContentLanguage?), TypeInfoPropertyName = "NullableTextContentLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomMessageType?), TypeInfoPropertyName = "NullableCustomMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.CustomMessage>?), TypeInfoPropertyName = "NullableOneOfStringCustomMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPlanMode?), TypeInfoPropertyName = "NullableTransferPlanMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll>?), TypeInfoPropertyName = "NullableOneOfContextEngineeringPlanLastNMessagesContextEngineeringPlanNoneContextEngineeringPlanAll2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationNumberType?), TypeInfoPropertyName = "NullableTransferDestinationNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationSipType?), TypeInfoPropertyName = "NullableTransferDestinationSipType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType?), TypeInfoPropertyName = "NullableContextEngineeringPlanLastNMessagesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanNoneType?), TypeInfoPropertyName = "NullableContextEngineeringPlanNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanAllType?), TypeInfoPropertyName = "NullableContextEngineeringPlanAllType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>?), TypeInfoPropertyName = "NullableOneOfTransferDestinationNumberTransferDestinationSip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder?), TypeInfoPropertyName = "NullablePaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPhoneNumberHookActionType?), TypeInfoPropertyName = "NullableTransferPhoneNumberHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayPhoneNumberHookActionType?), TypeInfoPropertyName = "NullableSayPhoneNumberHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallRingingHookFilterType?), TypeInfoPropertyName = "NullablePhoneNumberCallRingingHookFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallRingingHookFilterKey?), TypeInfoPropertyName = "NullablePhoneNumberCallRingingHookFilterKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallRingingOn?), TypeInfoPropertyName = "NullablePhoneNumberHookCallRingingOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>?), TypeInfoPropertyName = "NullableOneOfTransferPhoneNumberHookActionSayPhoneNumberHookAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterType?), TypeInfoPropertyName = "NullablePhoneNumberCallEndingHookFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterKey?), TypeInfoPropertyName = "NullablePhoneNumberCallEndingHookFilterKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem?), TypeInfoPropertyName = "NullablePhoneNumberCallEndingHookFilterOneOfItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallEndingOn?), TypeInfoPropertyName = "NullablePhoneNumberHookCallEndingOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>?), TypeInfoPropertyName = "NullableOneOfPhoneNumberHookCallRingingPhoneNumberHookCallEnding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoPhoneNumberProvider?), TypeInfoPropertyName = "NullableByoPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoPhoneNumberStatus?), TypeInfoPropertyName = "NullableByoPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioPhoneNumberProvider?), TypeInfoPropertyName = "NullableTwilioPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioPhoneNumberStatus?), TypeInfoPropertyName = "NullableTwilioPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonagePhoneNumberProvider?), TypeInfoPropertyName = "NullableVonagePhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonagePhoneNumberStatus?), TypeInfoPropertyName = "NullableVonagePhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPhoneNumberProvider?), TypeInfoPropertyName = "NullableVapiPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPhoneNumberStatus?), TypeInfoPropertyName = "NullableVapiPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TelnyxPhoneNumberProvider?), TypeInfoPropertyName = "NullableTelnyxPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TelnyxPhoneNumberStatus?), TypeInfoPropertyName = "NullableTelnyxPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateByoPhoneNumberDTOProvider?), TypeInfoPropertyName = "NullableCreateByoPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTwilioPhoneNumberDTOProvider?), TypeInfoPropertyName = "NullableCreateTwilioPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVonagePhoneNumberDTOProvider?), TypeInfoPropertyName = "NullableCreateVonagePhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVapiPhoneNumberDTOProvider?), TypeInfoPropertyName = "NullableCreateVapiPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTelnyxPhoneNumberDTOProvider?), TypeInfoPropertyName = "NullableCreateTelnyxPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateByoPhoneNumberDTOProvider?), TypeInfoPropertyName = "NullableUpdateByoPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTwilioPhoneNumberDTOProvider?), TypeInfoPropertyName = "NullableUpdateTwilioPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVonagePhoneNumberDTOProvider?), TypeInfoPropertyName = "NullableUpdateVonagePhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVapiPhoneNumberDTOProvider?), TypeInfoPropertyName = "NullableUpdateVapiPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTelnyxPhoneNumberDTOProvider?), TypeInfoPropertyName = "NullableUpdateTelnyxPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>?), TypeInfoPropertyName = "NullableOneOfByoPhoneNumberTwilioPhoneNumberVonagePhoneNumberVapiPhoneNumberTelnyxPhoneNumber2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateRequest?), TypeInfoPropertyName = "NullablePhoneNumberControllerCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider?), TypeInfoPropertyName = "NullablePhoneNumberControllerCreateRequestDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateRequest?), TypeInfoPropertyName = "NullablePhoneNumberControllerUpdateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider?), TypeInfoPropertyName = "NullablePhoneNumberControllerUpdateRequestDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortOrder?), TypeInfoPropertyName = "NullablePhoneNumberControllerFindAllPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortBy?), TypeInfoPropertyName = "NullablePhoneNumberControllerFindAllPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateResponse?), TypeInfoPropertyName = "NullablePhoneNumberControllerCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider?), TypeInfoPropertyName = "NullablePhoneNumberControllerCreateResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllResponseItem?), TypeInfoPropertyName = "NullablePhoneNumberControllerFindAllResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider?), TypeInfoPropertyName = "NullablePhoneNumberControllerFindAllResponseItemDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindOneResponse?), TypeInfoPropertyName = "NullablePhoneNumberControllerFindOneResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindOneResponseDiscriminatorProvider?), TypeInfoPropertyName = "NullablePhoneNumberControllerFindOneResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateResponse?), TypeInfoPropertyName = "NullablePhoneNumberControllerUpdateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider?), TypeInfoPropertyName = "NullablePhoneNumberControllerUpdateResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerRemoveResponse?), TypeInfoPropertyName = "NullablePhoneNumberControllerRemoveResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerRemoveResponseDiscriminatorProvider?), TypeInfoPropertyName = "NullablePhoneNumberControllerRemoveResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallRingingHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallEndingHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.PhoneNumberControllerFindAllResponseItem>))]
    internal sealed partial class PhoneNumbersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PhoneNumbersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PhoneNumbersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PhoneNumbersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Vapi.JsonConverters.PhoneNumberControllerCreateRequestJsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.PhoneNumberControllerUpdateRequestJsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.PhoneNumberControllerCreateResponseJsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.PhoneNumberControllerFindAllResponseItemJsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.PhoneNumberControllerFindOneResponseJsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.PhoneNumberControllerUpdateResponseJsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.PhoneNumberControllerRemoveResponseJsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, byte[]>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, byte[]>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?, object>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Vapi.TextContentType)

                    || typeToConvert == typeof(global::Vapi.TextContentType?)

                    || typeToConvert == typeof(global::Vapi.TextContentLanguage)

                    || typeToConvert == typeof(global::Vapi.TextContentLanguage?)

                    || typeToConvert == typeof(global::Vapi.CustomMessageType)

                    || typeToConvert == typeof(global::Vapi.CustomMessageType?)

                    || typeToConvert == typeof(global::Vapi.TransferPlanMode)

                    || typeToConvert == typeof(global::Vapi.TransferPlanMode?)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationNumberType)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationNumberType?)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationSipType)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationSipType?)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType?)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanNoneType)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanNoneType?)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanAllType)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanAllType?)

                    || typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder)

                    || typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder?)

                    || typeToConvert == typeof(global::Vapi.TransferPhoneNumberHookActionType)

                    || typeToConvert == typeof(global::Vapi.TransferPhoneNumberHookActionType?)

                    || typeToConvert == typeof(global::Vapi.SayPhoneNumberHookActionType)

                    || typeToConvert == typeof(global::Vapi.SayPhoneNumberHookActionType?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberCallRingingHookFilterType)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberCallRingingHookFilterType?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberCallRingingHookFilterKey)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberCallRingingHookFilterKey?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberHookCallRingingOn)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberHookCallRingingOn?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterType)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterType?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterKey)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterKey?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberHookCallEndingOn)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberHookCallEndingOn?)

                    || typeToConvert == typeof(global::Vapi.ByoPhoneNumberProvider)

                    || typeToConvert == typeof(global::Vapi.ByoPhoneNumberProvider?)

                    || typeToConvert == typeof(global::Vapi.ByoPhoneNumberStatus)

                    || typeToConvert == typeof(global::Vapi.ByoPhoneNumberStatus?)

                    || typeToConvert == typeof(global::Vapi.TwilioPhoneNumberProvider)

                    || typeToConvert == typeof(global::Vapi.TwilioPhoneNumberProvider?)

                    || typeToConvert == typeof(global::Vapi.TwilioPhoneNumberStatus)

                    || typeToConvert == typeof(global::Vapi.TwilioPhoneNumberStatus?)

                    || typeToConvert == typeof(global::Vapi.VonagePhoneNumberProvider)

                    || typeToConvert == typeof(global::Vapi.VonagePhoneNumberProvider?)

                    || typeToConvert == typeof(global::Vapi.VonagePhoneNumberStatus)

                    || typeToConvert == typeof(global::Vapi.VonagePhoneNumberStatus?)

                    || typeToConvert == typeof(global::Vapi.VapiPhoneNumberProvider)

                    || typeToConvert == typeof(global::Vapi.VapiPhoneNumberProvider?)

                    || typeToConvert == typeof(global::Vapi.VapiPhoneNumberStatus)

                    || typeToConvert == typeof(global::Vapi.VapiPhoneNumberStatus?)

                    || typeToConvert == typeof(global::Vapi.TelnyxPhoneNumberProvider)

                    || typeToConvert == typeof(global::Vapi.TelnyxPhoneNumberProvider?)

                    || typeToConvert == typeof(global::Vapi.TelnyxPhoneNumberStatus)

                    || typeToConvert == typeof(global::Vapi.TelnyxPhoneNumberStatus?)

                    || typeToConvert == typeof(global::Vapi.CreateByoPhoneNumberDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateByoPhoneNumberDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateTwilioPhoneNumberDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateTwilioPhoneNumberDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateVonagePhoneNumberDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateVonagePhoneNumberDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateVapiPhoneNumberDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateVapiPhoneNumberDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateTelnyxPhoneNumberDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateTelnyxPhoneNumberDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.UpdateByoPhoneNumberDTOProvider)

                    || typeToConvert == typeof(global::Vapi.UpdateByoPhoneNumberDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.UpdateTwilioPhoneNumberDTOProvider)

                    || typeToConvert == typeof(global::Vapi.UpdateTwilioPhoneNumberDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.UpdateVonagePhoneNumberDTOProvider)

                    || typeToConvert == typeof(global::Vapi.UpdateVonagePhoneNumberDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.UpdateVapiPhoneNumberDTOProvider)

                    || typeToConvert == typeof(global::Vapi.UpdateVapiPhoneNumberDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.UpdateTelnyxPhoneNumberDTOProvider)

                    || typeToConvert == typeof(global::Vapi.UpdateTelnyxPhoneNumberDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortOrder)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortOrder?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortBy)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortBy?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindOneResponseDiscriminatorProvider)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindOneResponseDiscriminatorProvider?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider?)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerRemoveResponseDiscriminatorProvider)

                    || typeToConvert == typeof(global::Vapi.PhoneNumberControllerRemoveResponseDiscriminatorProvider?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vapi.TextContentType))
                {
                    return new global::Vapi.JsonConverters.TextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TextContentType?))
                {
                    return new global::Vapi.JsonConverters.TextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TextContentLanguage))
                {
                    return new global::Vapi.JsonConverters.TextContentLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TextContentLanguage?))
                {
                    return new global::Vapi.JsonConverters.TextContentLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomMessageType))
                {
                    return new global::Vapi.JsonConverters.CustomMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomMessageType?))
                {
                    return new global::Vapi.JsonConverters.CustomMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferPlanMode))
                {
                    return new global::Vapi.JsonConverters.TransferPlanModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferPlanMode?))
                {
                    return new global::Vapi.JsonConverters.TransferPlanModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationNumberType))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationNumberType?))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationNumberTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationSipType))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationSipTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationSipType?))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationSipTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanLastNMessagesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType?))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanLastNMessagesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanNoneType))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanNoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanNoneType?))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanNoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanAllType))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanAllTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanAllType?))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanAllTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder))
                {
                    return new global::Vapi.JsonConverters.PaginationMetaSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder?))
                {
                    return new global::Vapi.JsonConverters.PaginationMetaSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferPhoneNumberHookActionType))
                {
                    return new global::Vapi.JsonConverters.TransferPhoneNumberHookActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferPhoneNumberHookActionType?))
                {
                    return new global::Vapi.JsonConverters.TransferPhoneNumberHookActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SayPhoneNumberHookActionType))
                {
                    return new global::Vapi.JsonConverters.SayPhoneNumberHookActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SayPhoneNumberHookActionType?))
                {
                    return new global::Vapi.JsonConverters.SayPhoneNumberHookActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberCallRingingHookFilterType))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberCallRingingHookFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberCallRingingHookFilterType?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberCallRingingHookFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberCallRingingHookFilterKey))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberCallRingingHookFilterKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberCallRingingHookFilterKey?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberCallRingingHookFilterKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberHookCallRingingOn))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberHookCallRingingOnJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberHookCallRingingOn?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberHookCallRingingOnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterType))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterType?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterKey))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterKey?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterOneOfItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterOneOfItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberHookCallEndingOn))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberHookCallEndingOnJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberHookCallEndingOn?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberHookCallEndingOnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ByoPhoneNumberProvider))
                {
                    return new global::Vapi.JsonConverters.ByoPhoneNumberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ByoPhoneNumberProvider?))
                {
                    return new global::Vapi.JsonConverters.ByoPhoneNumberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ByoPhoneNumberStatus))
                {
                    return new global::Vapi.JsonConverters.ByoPhoneNumberStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ByoPhoneNumberStatus?))
                {
                    return new global::Vapi.JsonConverters.ByoPhoneNumberStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TwilioPhoneNumberProvider))
                {
                    return new global::Vapi.JsonConverters.TwilioPhoneNumberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TwilioPhoneNumberProvider?))
                {
                    return new global::Vapi.JsonConverters.TwilioPhoneNumberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TwilioPhoneNumberStatus))
                {
                    return new global::Vapi.JsonConverters.TwilioPhoneNumberStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TwilioPhoneNumberStatus?))
                {
                    return new global::Vapi.JsonConverters.TwilioPhoneNumberStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VonagePhoneNumberProvider))
                {
                    return new global::Vapi.JsonConverters.VonagePhoneNumberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VonagePhoneNumberProvider?))
                {
                    return new global::Vapi.JsonConverters.VonagePhoneNumberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VonagePhoneNumberStatus))
                {
                    return new global::Vapi.JsonConverters.VonagePhoneNumberStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VonagePhoneNumberStatus?))
                {
                    return new global::Vapi.JsonConverters.VonagePhoneNumberStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiPhoneNumberProvider))
                {
                    return new global::Vapi.JsonConverters.VapiPhoneNumberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiPhoneNumberProvider?))
                {
                    return new global::Vapi.JsonConverters.VapiPhoneNumberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiPhoneNumberStatus))
                {
                    return new global::Vapi.JsonConverters.VapiPhoneNumberStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiPhoneNumberStatus?))
                {
                    return new global::Vapi.JsonConverters.VapiPhoneNumberStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TelnyxPhoneNumberProvider))
                {
                    return new global::Vapi.JsonConverters.TelnyxPhoneNumberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TelnyxPhoneNumberProvider?))
                {
                    return new global::Vapi.JsonConverters.TelnyxPhoneNumberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TelnyxPhoneNumberStatus))
                {
                    return new global::Vapi.JsonConverters.TelnyxPhoneNumberStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TelnyxPhoneNumberStatus?))
                {
                    return new global::Vapi.JsonConverters.TelnyxPhoneNumberStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateByoPhoneNumberDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateByoPhoneNumberDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateByoPhoneNumberDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateByoPhoneNumberDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTwilioPhoneNumberDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateTwilioPhoneNumberDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTwilioPhoneNumberDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateTwilioPhoneNumberDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateVonagePhoneNumberDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateVonagePhoneNumberDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateVonagePhoneNumberDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateVonagePhoneNumberDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateVapiPhoneNumberDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateVapiPhoneNumberDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateVapiPhoneNumberDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateVapiPhoneNumberDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTelnyxPhoneNumberDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateTelnyxPhoneNumberDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTelnyxPhoneNumberDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateTelnyxPhoneNumberDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateByoPhoneNumberDTOProvider))
                {
                    return new global::Vapi.JsonConverters.UpdateByoPhoneNumberDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateByoPhoneNumberDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.UpdateByoPhoneNumberDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateTwilioPhoneNumberDTOProvider))
                {
                    return new global::Vapi.JsonConverters.UpdateTwilioPhoneNumberDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateTwilioPhoneNumberDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.UpdateTwilioPhoneNumberDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateVonagePhoneNumberDTOProvider))
                {
                    return new global::Vapi.JsonConverters.UpdateVonagePhoneNumberDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateVonagePhoneNumberDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.UpdateVonagePhoneNumberDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateVapiPhoneNumberDTOProvider))
                {
                    return new global::Vapi.JsonConverters.UpdateVapiPhoneNumberDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateVapiPhoneNumberDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.UpdateVapiPhoneNumberDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateTelnyxPhoneNumberDTOProvider))
                {
                    return new global::Vapi.JsonConverters.UpdateTelnyxPhoneNumberDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateTelnyxPhoneNumberDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.UpdateTelnyxPhoneNumberDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerCreateRequestDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerCreateRequestDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerUpdateRequestDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerUpdateRequestDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortOrder))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerFindAllPaginatedSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortOrder?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerFindAllPaginatedSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortBy))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerFindAllPaginatedSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortBy?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerFindAllPaginatedSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerCreateResponseDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerCreateResponseDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerFindAllResponseItemDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerFindAllResponseItemDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindOneResponseDiscriminatorProvider))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerFindOneResponseDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerFindOneResponseDiscriminatorProvider?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerFindOneResponseDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerUpdateResponseDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerUpdateResponseDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerRemoveResponseDiscriminatorProvider))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerRemoveResponseDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PhoneNumberControllerRemoveResponseDiscriminatorProvider?))
                {
                    return new global::Vapi.JsonConverters.PhoneNumberControllerRemoveResponseDiscriminatorProviderNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new PhoneNumbersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}