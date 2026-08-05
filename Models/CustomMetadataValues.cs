using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record CustomMetadataValues
{
    /// <summary>
    /// Default value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default")]
    public string? Default { get; init; }

    /// <summary>
    /// Optional description.
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
    /// The current value for the video.
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
}
