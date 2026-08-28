using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Field1
{
    /// <summary>
    /// The ID of the custom metadata field, as returned by <c>GET /teams/{user_id}/custom_metadata</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field_id")]
    public double? FieldId { get; init; }

    /// <summary>
    /// The value to assign to the field. Send <c>null</c> to clear an existing value. For <c>str</c> fields, the value can be up to 50 characters; other types have their own format constraints (see the description above).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field_value")]
    public string? FieldValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
