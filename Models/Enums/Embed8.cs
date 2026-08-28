using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The embed permission level for the event.
/// <para>
/// Option descriptions:
///  * <c>private</c> - Only the user can embed the event.
///  * <c>public</c> - Anyone can embed the event.
///  * <c>whitelist</c> - Only specified users can embed the event.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Embed8>))]
public sealed record Embed8 : StringEnum<Embed8>
{
    private Embed8(string value) : base(value)
    {
    }

    public static readonly Embed8 Private = new("private");

    public static readonly Embed8 Public = new("public");

    public static readonly Embed8 Whitelist = new("whitelist");

    public static Embed8 FromValue(string value) => FromValueCore(value);
}
