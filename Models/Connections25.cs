using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Connections25
{
    /// <summary>
    /// Metadata for the child text tracks. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("child_text_tracks")]
    public ChildTextTracks? ChildTextTracks { get; init; }

    /// <summary>
    /// Metadata for the parent text track.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parent_text_track")]
    public ParentTextTrack? ParentTextTrack { get; init; }
}
