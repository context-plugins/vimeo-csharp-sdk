using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The rendition of the audio track.
/// <para>
/// Option descriptions:
///  * <c>source</c> - The audio is the source file.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Rendition2>))]
public sealed record Rendition2 : StringEnum<Rendition2>
{
    private Rendition2(string value) : base(value)
    {
    }

    public static readonly Rendition2 Source = new("source");

    public static Rendition2 FromValue(string value) => FromValueCore(value);
}
