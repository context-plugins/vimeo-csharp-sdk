using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record EventSessionStatus
{
    /// <summary>
    /// Information about the archive data.
    /// </summary>
    [JsonPropertyName("archive")]
    public required Archive Archive { get; init; }

    /// <summary>
    /// Whether the current user can manage the event.
    /// </summary>
    [JsonPropertyName("can_manage")]
    public required bool CanManage { get; init; }

    /// <summary>
    /// The ID of the live video.
    /// </summary>
    [JsonPropertyName("id")]
    public required double Id { get; init; }

    /// <summary>
    /// The ingest of the video.
    /// </summary>
    [JsonPropertyName("ingest")]
    public required Ingest Ingest { get; init; }

    /// <summary>
    /// The metering status of the live video.
    /// </summary>
    [JsonPropertyName("metering")]
    public required Metering Metering { get; init; }

    /// <summary>
    /// The status of the event.
    /// <para>
    /// Option descriptions:
    ///  * <c>ended</c> - The event has ended.
    ///  * <c>started</c> - The event has started.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status15? Status { get; init; }

    /// <summary>
    /// The stream mode of the event.
    /// <para>
    /// Option descriptions:
    ///  * <c>live</c> - The stream is live playback.
    ///  * <c>record</c> - The stream is in record mode.
    ///  * <c>simulive</c> - The stream is scheduled media playback.
    /// </para>
    /// </summary>
    [JsonPropertyName("stream_mode")]
    public required StreamMode StreamMode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
