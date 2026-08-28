using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Error
{
    /// <summary>
    /// The error message that technical users receive.
    /// </summary>
    [JsonPropertyName("developer_message")]
    public required string DeveloperMessage { get; init; }

    /// <summary>
    /// The error message that general users receive.
    /// </summary>
    [JsonPropertyName("error")]
    public required string ErrorValue { get; init; }

    /// <summary>
    /// The error code.
    /// </summary>
    [JsonPropertyName("error_code")]
    public required double ErrorCode { get; init; }

    /// <summary>
    /// A link to more information about the error.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
