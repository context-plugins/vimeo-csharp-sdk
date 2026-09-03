using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record MeAlbumsRequest1
{
    /// <summary>
    /// The hexadecimal color code for the color of the player buttons and showcase controls.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand_color")]
    public string? BrandColor { get; init; }

    /// <summary>
    /// The description of the showcase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The custom domain of the showcase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domain")]
    public string? Domain { get; init; }

    /// <summary>
    /// Whether to hide Vimeo navigation when displaying the showcase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hide_nav")]
    public bool? HideNav { get; init; }

    /// <summary>
    /// Whether to include the upcoming event in the showcase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hide_upcoming")]
    public bool? HideUpcoming { get; init; }

    /// <summary>
    /// The type of layout for presenting the showcase.
    /// <para>
    /// Option descriptions:
    ///  * <c>grid</c> - The videos appear in a grid.
    ///  * <c>player</c> - The videos appear in the player.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("layout")]
    public Layout1? Layout { get; init; }

    /// <summary>
    /// The name of the showcase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The showcase's password. This field is required only when <b>privacy</b> is <c>password</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    /// <summary>
    /// The privacy level of the showcase.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can access the showcase, either on Vimeo or through an embed.
    ///  * <c>embed_only</c> - The showcase doesn't appear on Vimeo, but it can be embedded on other sites.
    ///  * <c>nobody</c> - No one can access the showcase, including the authenticated user.
    ///  * <c>password</c> - Only people with the password can access the showcase.
    ///  * <c>team</c> - Only members of the authenticated user's team can access the showcase.
    ///  * <c>unlisted</c> - The showcase can't be accessed if the URL omits its unlisted hash.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privacy")]
    public Privacy12? Privacy { get; init; }

    /// <summary>
    /// Whether showcase videos use the review mode URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review_mode")]
    public bool? ReviewMode { get; init; }

    /// <summary>
    /// The default sort order of the videos as they appear in the showcase.
    /// <para>
    /// Option descriptions:
    ///  * <c>added_first</c> - The videos appear according to when they were added to the showcase, with the most recently added first.
    ///  * <c>added_last</c> - The videos appear according to when they were added to the showcase, with the most recently added last.
    ///  * <c>alphabetical</c> - The videos appear alphabetically by their title.
    ///  * <c>alphabetical_desc</c> - The videos appear alphabetically by their title in reverse order.
    ///  * <c>arranged</c> - The videos appear as arranged by the owner of the showcase.
    ///  * <c>comments</c> - The videos appear according to their number of comments.
    ///  * <c>likes</c> - The videos appear according to their number of likes.
    ///  * <c>modified_time_asc</c> - The videos appear in ascending order based on their last modified time.
    ///  * <c>modified_time_desc</c> - The videos appear in descending order based on their last modified time.
    ///  * <c>newest</c> - The videos appear in chronological order with the newest first.
    ///  * <c>oldest</c> - The videos appear in chronological order with the oldest first.
    ///  * <c>plays</c> - The videos appear according to their number of plays.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public Sort19? Sort { get; init; }

    /// <summary>
    /// The color theme of the showcase.
    /// <para>
    /// Option descriptions:
    ///  * <c>dark</c> - The showcase uses the dark theme.
    ///  * <c>standard</c> - The showcase uses the standard theme.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("theme")]
    public Theme? Theme { get; init; }

    /// <summary>
    /// The custom Vimeo URL of the showcase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    /// Whether the user has opted for a custom domain for their showcase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("use_custom_domain")]
    public bool? UseCustomDomain { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
