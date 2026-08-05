using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The grant type. The value of this field must be <c>client_credentials</c>.
/// <para>
/// Option descriptions:
///  * <c>client_credentials</c> - The grant type is for the client credentials.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GrantType1>))]
public sealed record GrantType1 : StringEnum<GrantType1>
{
    private GrantType1(string value) : base(value)
    {
    }

    public static readonly GrantType1 ClientCredentials = new("client_credentials");

    public static GrantType1 FromValue(string value) => FromValueCore(value);
}
