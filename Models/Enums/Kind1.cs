using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of caption that the segment originates from.
/// <para>
/// Option descriptions:
///  * <c>captions</c> - The segment originates from a captions file.
///  * <c>subtitles</c> - The segment originates from a captions and subtitles file.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Kind1>))]
public sealed record Kind1 : StringEnum<Kind1>
{
    private Kind1(string value) : base(value)
    {
    }

    public static readonly Kind1 Captions = new("captions");

    public static readonly Kind1 Subtitles = new("subtitles");

    public static Kind1 FromValue(string value) => FromValueCore(value);
}
