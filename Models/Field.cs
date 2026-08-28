using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record Field
{
    /// <summary>
    /// The value applied by default when a video doesn't specify one. For <c>str</c> fields, the default can be up to 50 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default_value")]
    public string? DefaultValue { get; init; }

    /// <summary>
    /// When <c>true</c>, combined with <c>id</c>, deletes the field and all values assigned to it.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delete")]
    public bool? Delete { get; init; }

    /// <summary>
    /// A short explanation of the field's purpose. Up to 1024 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The ID of an existing field. Omit to create a new field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public double? Id { get; init; }

    /// <summary>
    /// Whether videos must have a value for this field. Required when creating a new field. Can only be relaxed (<c>true</c> to <c>false</c>) after creation, not made stricter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mandatory")]
    public bool? Mandatory { get; init; }

    /// <summary>
    /// The display name of the field. Required when creating a new field. Up to 255 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The data type of the field. Required when creating a new field. <b>Immutable</b> after creation.
    /// <para>
    /// Option descriptions:
    ///  * <c>bool</c> - Boolean value (<c>true</c> or <c>false</c>).
    ///  * <c>date</c> - Calendar date in <c>YYYY-MM-DD</c> format.
    ///  * <c>int</c> - Integer value.
    ///  * <c>multi-select</c> - One or more values chosen from the field's <c>values</c> list.
    ///  * <c>select</c> - A single value chosen from the field's <c>values</c> list.
    ///  * <c>str</c> - Freeform string value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type43? Type { get; init; }

    /// <summary>
    /// The list of allowed values. Required for <c>select</c> and <c>multi-select</c> fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyList<string?>? Values { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
