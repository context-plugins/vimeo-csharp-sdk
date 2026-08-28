using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record LiveEventsActivateRequest
{
    /// <summary>
    /// Whether the stream activates from the cloud composer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cloud_composing_streaming")]
    public bool? CloudComposingStreaming { get; init; }

    /// <summary>
    /// Whether the stream activates from the cloud composer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("streaming_start_requested")]
    public bool? StreamingStartRequested { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
