using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record CustomMetadataSettings
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
    [JsonPropertyName("id")]
    public required double Id { get; init; }

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
    /// <para>
    /// Option descriptions:
    ///  * <c>bool</c> - Boolean value.
    ///  * <c>date</c> - Date value.
    ///  * <c>int</c> - Integer value.
    ///  * <c>multi-select</c> - Multi-select from allowed values.
    ///  * <c>select</c> - Single-select from allowed values.
    ///  * <c>str</c> - String value.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type17 Type { get; init; }

    /// <summary>
    /// Allowed values for select/multi-select types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyList<string?>? Values { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
