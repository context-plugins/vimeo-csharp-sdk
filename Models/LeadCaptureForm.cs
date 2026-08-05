using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the authenticated user's lead capture form. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record LeadCaptureForm
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public IReadOnlyList<string>? Options { get; init; }
}
