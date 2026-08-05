using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record TeamsCustomMetadataBackfillRequest
{
    /// <summary>
    /// The ID of the custom metadata field to populate.
    /// </summary>
    [JsonPropertyName("field_id")]
    public required double FieldId { get; init; }

    /// <summary>
    /// The value to assign to the field. Must match the field's data type. For <c>str</c> fields, the value can be up to 50 characters.
    /// </summary>
    [JsonPropertyName("field_value")]
    public required string FieldValue { get; init; }

    /// <summary>
    /// Whether to overwrite values that are already set. When <c>false</c> (the default), only videos that don't yet have a value are updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("override_existing")]
    public bool? OverrideExisting { get; init; }
}
