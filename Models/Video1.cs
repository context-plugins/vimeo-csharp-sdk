using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// The associated video object. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record Video1
{
    /// <summary>
    /// The number of comments on the associated video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("comments")]
    public required double Comments { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the video was created. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// The duration of the associated video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("duration")]
    public required double Duration { get; init; }

    /// <summary>
    /// The number of likes on the associated video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("likes")]
    public required double Likes { get; init; }

    /// <summary>
    /// The associated live stream object. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("live")]
    public required Live1 Live { get; init; }

    /// <summary>
    /// The link to the video management page. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("manage_link")]
    public required string ManageLink { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The title of the associated video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
