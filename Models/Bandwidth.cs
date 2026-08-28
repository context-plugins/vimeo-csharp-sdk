using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record Bandwidth
{
    /// <summary>
    /// The quota period for which the bandwidth is evaluated.
    /// <para>
    /// Option descriptions:
    ///  * <c>calendar_month</c> - The quota period is one month.
    ///  * <c>year</c> - The quota period is one year.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("period")]
    public Period1? Period { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
