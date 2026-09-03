using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of text track.
/// <para>
/// Option descriptions:
///  * <c>captions</c> - The text track is the captions type.
///  * <c>chapters</c> - The text track is the chapters type.
///  * <c>descriptions</c> - The text track is the descriptions type.
///  * <c>metadata</c> - The text track is the metadata type.
///  * <c>subtitles</c> - The text track is the subtitles type.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type25>))]
public sealed record Type25 : StringEnum<Type25>
{
    private Type25(string value) : base(value)
    {
    }

    public static readonly Type25 Captions = new("captions");

    public static readonly Type25 Chapters = new("chapters");

    public static readonly Type25 Descriptions = new("descriptions");

    public static readonly Type25 Metadata = new("metadata");

    public static readonly Type25 Subtitles = new("subtitles");

    public static Type25 FromValue(string value) => FromValueCore(value);
}
