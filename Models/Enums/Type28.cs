using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// Which logo to show in the landing page navbar.
/// <para>
/// Option descriptions:
///  * <c>custom</c> - A custom brand-kit logo (see <c>uri</c>).
///  * <c>none</c> - No logo is shown.
///  * <c>vimeo</c> - The Vimeo logo.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type28>))]
public sealed record Type28 : StringEnum<Type28>
{
    private Type28(string value) : base(value)
    {
    }

    public static readonly Type28 Custom = new("custom");

    public static readonly Type28 None = new("none");

    public static readonly Type28 Vimeo = new("vimeo");

    public static Type28 FromValue(string value) => FromValueCore(value);
}
