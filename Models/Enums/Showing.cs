using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of quota for the values of the <b>upload_quota.space</b> field.
/// <para>
/// Option descriptions:
///  * <c>lifetime</c> - The quota type is lifetime.
///  * <c>periodic</c> - The quota type is periodic.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Showing>))]
public sealed record Showing : StringEnum<Showing>
{
    private Showing(string value) : base(value)
    {
    }

    public static readonly Showing Lifetime = new("lifetime");

    public static readonly Showing Periodic = new("periodic");

    public static Showing FromValue(string value) => FromValueCore(value);
}
