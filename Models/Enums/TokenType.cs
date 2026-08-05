using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The token type.
/// <para>
/// Option descriptions:
///  * <c>bearer</c> - The token is of the bearer type.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TokenType>))]
public sealed record TokenType : StringEnum<TokenType>
{
    private TokenType(string value) : base(value)
    {
    }

    public static readonly TokenType Bearer = new("bearer");

    public static TokenType FromValue(string value) => FromValueCore(value);
}
