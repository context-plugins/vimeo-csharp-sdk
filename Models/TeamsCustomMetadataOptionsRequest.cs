using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record TeamsCustomMetadataOptionsRequest
{
    /// <summary>
    /// The ID of the <c>select</c> or <c>multi-select</c> custom metadata field to modify.
    /// </summary>
    [JsonPropertyName("field_id")]
    public required double FieldId { get; init; }

    /// <summary>
    /// The list of changes to apply to the field's allowed values.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<Option> Options { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
