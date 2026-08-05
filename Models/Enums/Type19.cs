using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of the simulcast destination.
/// <para>
/// Option descriptions:
///  * <c>channel</c> - The destination is a YouTube channel.
///  * <c>custom</c> - The destination is custom.
///  * <c>organization</c> - The destination is a LinkedIn organization.
///  * <c>page</c> - The destination is a Facebook page.
///  * <c>profile</c> - The destination is a Facebook or LinkedIn profile.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type19>))]
public sealed record Type19 : StringEnum<Type19>
{
    private Type19(string value) : base(value)
    {
    }

    public static readonly Type19 Channel = new("channel");

    public static readonly Type19 Custom = new("custom");

    public static readonly Type19 Organization = new("organization");

    public static readonly Type19 Page = new("page");

    public static readonly Type19 Profile = new("profile");

    public static Type19 FromValue(string value) => FromValueCore(value);
}
