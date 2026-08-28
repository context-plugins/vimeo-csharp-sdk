using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The context of the video's subscription, if the video is part of a subscription.
/// </summary>
public record Context
{
    /// <summary>
    /// The relevant contextual action.
    /// <para>
    /// Option descriptions:
    ///  * <c>Added to</c> - An Added To action.
    ///  * <c>Appearance by</c> - An Appearance By action.
    ///  * <c>Liked by</c> - A Liked By action.
    ///  * <c>Uploaded by</c> - An Uploaded By action.
    /// </para>
    /// </summary>
    [JsonPropertyName("action")]
    public required ActionEnum Action { get; init; }

    /// <summary>
    /// The contextual resource: a user, group, or channel representation, or an object of a tag.
    /// </summary>
    [JsonPropertyName("resource")]
    public required object? Resource { get; init; }

    /// <summary>
    /// The contextual resource type.
    /// </summary>
    [JsonPropertyName("resource_type")]
    public required string ResourceType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
