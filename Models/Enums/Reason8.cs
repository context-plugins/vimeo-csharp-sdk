using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The reason why the translation method is disabled.
/// <para>
/// Option descriptions:
///  * <c>language_not_supported</c> - The video language isn't supported.
///  * <c>owner_account_blocked</c> - The owner account is blocked due to billing issues.
///  * <c>owner_disabled_feature_group</c> - The owner has disabled the feature group.
///  * <c>video_too_long</c> - The video is too long.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason8>))]
public sealed record Reason8 : StringEnum<Reason8>
{
    private Reason8(string value) : base(value)
    {
    }

    public static readonly Reason8 LanguageNotSupported = new("language_not_supported");

    public static readonly Reason8 OwnerAccountBlocked = new("owner_account_blocked");

    public static readonly Reason8 OwnerDisabledFeatureGroup = new("owner_disabled_feature_group");

    public static readonly Reason8 VideoTooLong = new("video_too_long");

    public static Reason8 FromValue(string value) => FromValueCore(value);
}
