using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record ConnectedApps1
{
    /// <summary>
    /// The list of all the scopes on the connected app that are needed for a particular Vimeo feature.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("all_scopes")]
    public object? AllScopes { get; init; }

    /// <summary>
    /// Whether the authenticated user is connected to the connected app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_connected")]
    public bool? IsConnected { get; init; }

    /// <summary>
    /// The list of the remaining scopes on the connected app that the authenticated user needs for a particular Vimeo feature.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("needed_scopes")]
    public object? NeededScopes { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public IReadOnlyList<string>? Options { get; init; }

    /// <summary>
    /// The URI of the connected app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }
}
