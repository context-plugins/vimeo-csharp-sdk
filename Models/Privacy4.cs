using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// The group's privacy settings.
/// </summary>
public record Privacy4
{
    /// <summary>
    /// Who can comment on the group.
    /// <para>
    /// Option descriptions:
    ///  * <c>all</c> - Anyone can comment on the group.
    ///  * <c>members</c> - Only group members can comment on the group.
    /// </para>
    /// </summary>
    [JsonPropertyName("comment")]
    public required Comment2 Comment { get; init; }

    /// <summary>
    /// Who can invite new members to the group.
    /// <para>
    /// Option descriptions:
    ///  * <c>all</c> - Anyone can invite new members to the group.
    ///  * <c>members</c> - Only group members can invite new members to the group.
    /// </para>
    /// </summary>
    [JsonPropertyName("invite")]
    public required Invite2 Invite { get; init; }

    /// <summary>
    /// Who can join the group.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can join the group.
    ///  * <c>members</c> - Only people with a Vimeo account can join the group.
    /// </para>
    /// </summary>
    [JsonPropertyName("join")]
    public required Join1 Join { get; init; }

    /// <summary>
    /// Who can add videos to the group.
    /// <para>
    /// Option descriptions:
    ///  * <c>all</c> - Anyone can add videos to the group.
    ///  * <c>members</c> - Only group members can add videos to the group.
    /// </para>
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos7 Videos { get; init; }

    /// <summary>
    /// Who can access the group.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can access the group. This privacy setting appears as <c>Public</c> on the Vimeo front end.
    ///  * <c>members</c> - Only group members can access the group.
    /// </para>
    /// </summary>
    [JsonPropertyName("view")]
    public required View5 View { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
