using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record LiveEventsAudioTracksRequest
{
    /// <summary>
    /// A list of language codes for audio tracks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("audio_tracks")]
    public IReadOnlyList<string>? AudioTracks { get; init; }

    /// <summary>
    /// The language code for the primary audio track.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_audio_track")]
    public string? PrimaryAudioTrack { get; init; }
}
