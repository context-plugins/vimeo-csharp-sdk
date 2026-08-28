using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record User
{
    /// <summary>
    /// Account dictionary usage and entry limits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_dictionary_quota")]
    public AccountDictionaryQuota? AccountDictionaryQuota { get; init; }

    /// <summary>
    /// The status of the user's age verification.
    /// <para>
    /// Option descriptions:
    ///  * <c>failed</c> - The user has failed age verification.
    ///  * <c>passed</c> - The user has passed age verification.
    ///  * <c>pending</c> - The user's age verification is pending.
    /// </para>
    /// </summary>
    [JsonPropertyName("age_verification_status")]
    public required AgeVerificationStatus AgeVerificationStatus { get; init; }

    /// <summary>
    /// Information about the user's AI credits quota.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ai_credits_quota")]
    public AiCreditsQuota? AiCreditsQuota { get; init; }

    /// <summary>
    /// Whether the authenticated user is available for hire.
    /// </summary>
    [JsonPropertyName("available_for_hire")]
    public required bool AvailableForHire { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bandwidth")]
    public Bandwidth? Bandwidth { get; init; }

    /// <summary>
    /// The authenticated user's long biography text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bio")]
    public string? Bio { get; init; }

    /// <summary>
    /// Whether the authenticated user can work remotely.
    /// </summary>
    [JsonPropertyName("can_work_remotely")]
    public required bool CanWorkRemotely { get; init; }

    /// <summary>
    /// The users's capabilities list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capabilities")]
    public object? Capabilities { get; init; }

    /// <summary>
    /// The comma-separated list of clients.
    /// </summary>
    [JsonPropertyName("clients")]
    public required string Clients { get; init; }

    /// <summary>
    /// The authenticated user's content filters.
    /// <para>
    /// Option descriptions:
    ///  * <c>drugs</c> - The content contains drug or alcohol use.
    ///  * <c>language</c> - The content contains profanity or sexually suggestive language.
    ///  * <c>nudity</c> - The content contains nudity.
    ///  * <c>safe</c> - The content is suitable for all audiences.
    ///  * <c>unrated</c> - The content hasn't been rated.
    ///  * <c>violence</c> - The content contains violence or is graphic.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("content_filter")]
    public ContentFilter? ContentFilter { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the user account was created.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// Information about the user's DRM usage quota.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("drm_licenses_quota")]
    public DrmLicensesQuota? DrmLicensesQuota { get; init; }

    /// <summary>
    /// The authenticated user's gender.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gender")]
    public string? Gender { get; init; }

    /// <summary>
    /// Whether the user's email is invalid.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_invalid_email")]
    public bool? HasInvalidEmail { get; init; }

    /// <summary>
    /// Whether the creator enrolled in and successfully completed the Vimeo Experts program.
    /// </summary>
    [JsonPropertyName("is_expert")]
    public required bool IsExpert { get; init; }

    /// <summary>
    /// Whether the user has had a staff-picked video.
    /// </summary>
    [JsonPropertyName("is_staff_picked")]
    public required bool IsStaffPicked { get; init; }

    /// <summary>
    /// The time in ISO 8601 format of the user's most recent video upload, or null if the user has no videos. Backed by a lean, indexed clip lookup cached for one hour.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_video_upload_date")]
    public string? LastVideoUploadDate { get; init; }

    /// <summary>
    /// The absolute URL of the authenticated users's profile page.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// When the user's access to the exclusive live-localization features (caption translations, multi-audio streams) comes from the launch free trial, the date (YYYY-MM-DD) the trial expires. Null for users with permanent access (staff or a granted SKU) or no trial.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("live_localization_trial_expires_on")]
    public string? LiveLocalizationTrialExpiresOn { get; init; }

    /// <summary>
    /// Information about the user's learning management system learner seats quota.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lms_learner_seats_quota")]
    public LmsLearnerSeatsQuota? LmsLearnerSeatsQuota { get; init; }

    /// <summary>
    /// The authenticated user's location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string? Location { get; init; }

    /// <summary>
    /// The authenticated user's location details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_details")]
    public Location? LocationDetails { get; init; }

    /// <summary>
    /// The maximum number of team members the user may have.
    /// </summary>
    [JsonPropertyName("max_team_members")]
    public required double MaxTeamMembers { get; init; }

    /// <summary>
    /// Information about the authenticated user's Vimeo membership.
    /// </summary>
    [JsonPropertyName("membership")]
    public required Membership Membership { get; init; }

    /// <summary>
    /// The authenticated user's metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata3 Metadata { get; init; }

    /// <summary>
    /// The authenticated user's display name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The active portrait of the authenticated user.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Picture Pictures { get; init; }

    [JsonPropertyName("preferences")]
    public required Preferences Preferences { get; init; }

    /// <summary>
    /// Whether the user has enabled profile discovery from their profile settings.
    /// </summary>
    [JsonPropertyName("profile_discovery")]
    public required bool ProfileDiscovery { get; init; }

    /// <summary>
    /// Whether the user is required to verify their age.
    /// </summary>
    [JsonPropertyName("requires_age_verification")]
    public required bool RequiresAgeVerification { get; init; }

    /// <summary>
    /// The authenticated user's resource key string.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// The authenticated user's short biography text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short_bio")]
    public string? ShortBio { get; init; }

    /// <summary>
    /// A list of the authenticated user's skills.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skills")]
    public IReadOnlyList<Skill>? Skills { get; init; }

    /// <summary>
    /// The maximum number of transcript phrases permitted for the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transcript_phrases_limit")]
    public double? TranscriptPhrasesLimit { get; init; }

    /// <summary>
    /// The upload quota. This information appears only when the authenticated user has upload access and is looking at their own user record.
    /// </summary>
    [JsonPropertyName("upload_quota")]
    public required UploadQuota UploadQuota { get; init; }

    /// <summary>
    /// The authenticated user's canonical relative URI.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The authenticated user's websites.
    /// </summary>
    [JsonPropertyName("websites")]
    public required IReadOnlyList<Website> Websites { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
