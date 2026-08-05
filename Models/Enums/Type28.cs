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
[JsonConverter(typeof(StringEnumConverter<Type28>))]
public sealed record Type28 : StringEnum<Type28>
{
    private Type28(string value) : base(value)
    {
    }

    public static readonly Type28 Captions = new("captions");

    public static readonly Type28 Subtitles = new("subtitles");

    public static Type28 FromValue(string value) => FromValueCore(value);
}
