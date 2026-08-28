using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The review status of the video.
/// <para>
/// Option descriptions:
///  * <c>approved</c> - The video review was approved.
///  * <c>in_progress</c> - The video review is in progress.
///  * <c>needs_review</c> - The video needs to be reviewed.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReviewStatus>))]
public sealed record ReviewStatus : StringEnum<ReviewStatus>
{
    private ReviewStatus(string value) : base(value)
    {
    }

    public static readonly ReviewStatus Approved = new("approved");

    public static readonly ReviewStatus InProgress = new("in_progress");

    public static readonly ReviewStatus NeedsReview = new("needs_review");

    public static ReviewStatus FromValue(string value) => FromValueCore(value);
}
