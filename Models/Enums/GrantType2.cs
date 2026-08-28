using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The grant type. The value of this field must be <c>vimeo_oauth1</c>.
/// <para>
/// Option descriptions:
///  * <c>vimeo_oauth1</c> - The grant type is for the OAuth1 token.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GrantType2>))]
public sealed record GrantType2 : StringEnum<GrantType2>
{
    private GrantType2(string value) : base(value)
    {
    }

    public static readonly GrantType2 VimeoOauth1 = new("vimeo_oauth1");

    public static GrantType2 FromValue(string value) => FromValueCore(value);
}
