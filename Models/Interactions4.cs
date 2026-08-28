using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// A list of permitted interactions related to the folder.
/// </summary>
public record Interactions4
{
    /// <summary>
    /// Information about adding a subfolder to the current folder.
    /// </summary>
    [JsonPropertyName("add_subfolder")]
    public required AddSubfolder AddSubfolder { get; init; }

    /// <summary>
    /// Whether the folder can have multiple review links.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_multiple_review_links")]
    public bool? AllowMultipleReviewLinks { get; init; }

    /// <summary>
    /// Whether the user can comment on the videos of the current folder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_comment")]
    public bool? CanComment { get; init; }

    /// <summary>
    /// The user's delete permissions information for this project.
    /// </summary>
    [JsonPropertyName("delete")]
    public required Delete1 Delete { get; init; }

    /// <summary>
    /// The user's delete permissions information for this project.
    /// </summary>
    [JsonPropertyName("delete_video")]
    public required DeleteVideo DeleteVideo { get; init; }

    /// <summary>
    /// The user's edit permissions information for this project.
    /// </summary>
    [JsonPropertyName("edit")]
    public required Edit1 Edit { get; init; }

    /// <summary>
    /// The user's edit settings permissions information for this project.
    /// </summary>
    [JsonPropertyName("edit_settings")]
    public required EditSettings EditSettings { get; init; }

    /// <summary>
    /// The user's invite permissions information for this project.
    /// </summary>
    [JsonPropertyName("invite")]
    public required Invite1 Invite { get; init; }

    /// <summary>
    /// The user's move permissions information for this project.
    /// </summary>
    [JsonPropertyName("move_video")]
    public required MoveVideo MoveVideo { get; init; }

    /// <summary>
    /// The default review redirect link for the current folder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review_redirect_link")]
    public string? ReviewRedirectLink { get; init; }

    /// <summary>
    /// The user's upload permissions information for this project.
    /// </summary>
    [JsonPropertyName("upload_video")]
    public required UploadVideo UploadVideo { get; init; }

    /// <summary>
    /// The user's view permissions information for this project.
    /// </summary>
    [JsonPropertyName("view")]
    public required View2 View { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
