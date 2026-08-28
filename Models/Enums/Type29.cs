using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Type29>))]
public sealed record Type29 : StringEnum<Type29>
{
    private Type29(string value) : base(value)
    {
    }

    public static readonly Type29 Captions = new("captions");

    public static readonly Type29 Chapters = new("chapters");

    public static readonly Type29 Descriptions = new("descriptions");

    public static readonly Type29 Metadata = new("metadata");

    public static readonly Type29 Subtitles = new("subtitles");

    public static Type29 FromValue(string value) => FromValueCore(value);
}
