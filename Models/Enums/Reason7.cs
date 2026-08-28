using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The reason why the translation method is disabled.
/// <para>
/// Option descriptions:
///  * <c>owner_account_blocked</c> - The owner account is blocked due to billing issues.
///  * <c>owner_disabled_feature_group</c> - The owner has disabled the feature group.
///  * <c>owner_payment_disabled</c> - The owner account can't use the payments service.
///  * <c>transcript_status_does_not_exist</c> - The video transcript doesn't exist.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason7>))]
public sealed record Reason7 : StringEnum<Reason7>
{
    private Reason7(string value) : base(value)
    {
    }

    public static readonly Reason7 OwnerAccountBlocked = new("owner_account_blocked");

    public static readonly Reason7 OwnerDisabledFeatureGroup = new("owner_disabled_feature_group");

    public static readonly Reason7 OwnerPaymentDisabled = new("owner_payment_disabled");

    public static readonly Reason7 TranscriptStatusDoesNotExist = new("transcript_status_does_not_exist");

    public static Reason7 FromValue(string value) => FromValueCore(value);
}
