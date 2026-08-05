using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The status of the user's age verification.
/// <para>
/// Option descriptions:
///  * <c>failed</c> - The user has failed age verification.
///  * <c>passed</c> - The user has passed age verification.
///  * <c>pending</c> - The user's age verification is pending.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AgeVerificationStatus>))]
public sealed record AgeVerificationStatus : StringEnum<AgeVerificationStatus>
{
    private AgeVerificationStatus(string value) : base(value)
    {
    }

    public static readonly AgeVerificationStatus Failed = new("failed");

    public static readonly AgeVerificationStatus Passed = new("passed");

    public static readonly AgeVerificationStatus Pending = new("pending");

    public static AgeVerificationStatus FromValue(string value) => FromValueCore(value);
}
