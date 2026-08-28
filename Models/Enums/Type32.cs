using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// Which logo to show in the landing page navbar.
/// <para>
/// Option descriptions:
///  * <c>custom</c> - A custom brand-kit logo (see <c>uri</c>).
///  * <c>none</c> - No logo is shown.
///  * <c>vimeo</c> - The Vimeo logo.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type32>))]
public sealed record Type32 : StringEnum<Type32>
{
    private Type32(string value) : base(value)
    {
    }

    public static readonly Type32 Custom = new("custom");

    public static readonly Type32 None = new("none");

    public static readonly Type32 Vimeo = new("vimeo");

    public static Type32 FromValue(string value) => FromValueCore(value);
}
