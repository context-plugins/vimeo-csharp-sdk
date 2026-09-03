using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of text track.
/// <para>
/// Option descriptions:
///  * <c>captions</c> - The text track is for captions.
///  * <c>subtitles</c> - The text track is for subtitles.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type24>))]
public sealed record Type24 : StringEnum<Type24>
{
    private Type24(string value) : base(value)
    {
    }

    public static readonly Type24 Captions = new("captions");

    public static readonly Type24 Subtitles = new("subtitles");

    public static Type24 FromValue(string value) => FromValueCore(value);
}
