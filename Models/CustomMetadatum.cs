using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record CustomMetadatum
{
    /// <summary>
    /// Default value for the metadata field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default")]
    public string? Default { get; init; }

    /// <summary>
    /// Optional description of the metadata field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The unique identifier of the metadata field.
    /// </summary>
    [JsonPropertyName("field_id")]
    public required double FieldId { get; init; }

    /// <summary>
    /// The current value of this metadata field for the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field_value")]
    public string? FieldValue { get; init; }

    /// <summary>
    /// Whether this metadata field is required.
    /// </summary>
    [JsonPropertyName("mandatory")]
    public required bool Mandatory { get; init; }

    /// <summary>
    /// The name of the metadata field.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The data type of the metadata field.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Allowed values for select/multi-select types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyList<string?>? Values { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
