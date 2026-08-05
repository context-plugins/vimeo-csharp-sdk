using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The grant type. The value of this field must be <c>authorization_code</c>.
/// <para>
/// Option descriptions:
///  * <c>authorization_code</c> - The grant type is for an authorization code.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GrantType>))]
public sealed record GrantType : StringEnum<GrantType>
{
    private GrantType(string value) : base(value)
    {
    }

    public static readonly GrantType AuthorizationCode = new("authorization_code");

    public static GrantType FromValue(string value) => FromValueCore(value);
}
