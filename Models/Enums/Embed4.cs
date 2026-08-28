using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The event's embed permission setting.
/// <para>
/// Option descriptions:
///  * <c>private</c> - The event can't be embedded on any domain.
///  * <c>public</c> - The event can be embedded on any domain.
///  * <c>whitelist</c> - The event can be embedded on permitted domains only.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Embed4>))]
public sealed record Embed4 : StringEnum<Embed4>
{
    private Embed4(string value) : base(value)
    {
    }

    public static readonly Embed4 Private = new("private");

    public static readonly Embed4 Public = new("public");

    public static readonly Embed4 Whitelist = new("whitelist");

    public static Embed4 FromValue(string value) => FromValueCore(value);
}
