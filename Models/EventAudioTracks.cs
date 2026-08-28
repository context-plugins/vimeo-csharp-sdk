using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record EventAudioTracks
{
    /// <summary>
    /// A list of language codes for audio tracks.
    /// </summary>
    [JsonPropertyName("audio_tracks")]
    public required IReadOnlyList<string> AudioTracks { get; init; }

    /// <summary>
    /// The language code for the primary audio track.
    /// </summary>
    [JsonPropertyName("primary_audio_track")]
    public required string PrimaryAudioTrack { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
