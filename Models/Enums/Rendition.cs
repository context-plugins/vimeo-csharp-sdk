using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The video rendition.
/// <para>
/// Option descriptions:
///  * <c>2k</c> - The video has 2K resolution.
///  * <c>4k</c> - The video has 4K resolution.
///  * <c>5k</c> - The video has 5K resolution.
///  * <c>6k</c> - The video has 6K resolution.
///  * <c>7k</c> - The video has 7K resolution.
///  * <c>8k</c> - The video has 8K resolution.
///  * <c>240p</c> - The video has 240p resolution.
///  * <c>360p</c> - The video has 360p resolution.
///  * <c>480p</c> - The video has 480p resolution.
///  * <c>540p</c> - The video has 540p resolution.
///  * <c>720p</c> - The video has 720p resolution.
///  * <c>1080p</c> - The video has 1080p resolution.
///  * <c>adaptive</c> - The video rendition is adaptive (for example, HLS or DASH).
///  * <c>audio</c> - The file is audio-only.
///  * <c>source</c> - The video is the source file.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Rendition>))]
public sealed record Rendition : StringEnum<Rendition>
{
    private Rendition(string value) : base(value)
    {
    }

    public static readonly Rendition _2K = new("2k");

    public static readonly Rendition _4K = new("4k");

    public static readonly Rendition _5K = new("5k");

    public static readonly Rendition _6K = new("6k");

    public static readonly Rendition _7K = new("7k");

    public static readonly Rendition _8K = new("8k");

    public static readonly Rendition _240P = new("240p");

    public static readonly Rendition _360P = new("360p");

    public static readonly Rendition _480P = new("480p");

    public static readonly Rendition _540P = new("540p");

    public static readonly Rendition _720P = new("720p");

    public static readonly Rendition _1080P = new("1080p");

    public static readonly Rendition Adaptive = new("adaptive");

    public static readonly Rendition Audio = new("audio");

    public static readonly Rendition Source = new("source");

    public static Rendition FromValue(string value) => FromValueCore(value);
}
