using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// Which logo to show in the landing page navbar.
/// <para>
/// Option descriptions:
///  * <c>custom</c> - A custom brand-kit logo (see <c>uri</c>/<c>url</c>).
///  * <c>none</c> - No logo is shown.
///  * <c>vimeo</c> - The Vimeo logo.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type14>))]
public sealed record Type14 : StringEnum<Type14>
{
    private Type14(string value) : base(value)
    {
    }

    public static readonly Type14 Custom = new("custom");

    public static readonly Type14 None = new("none");

    public static readonly Type14 Vimeo = new("vimeo");

    public static Type14 FromValue(string value) => FromValueCore(value);
}
