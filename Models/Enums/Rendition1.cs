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
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Rendition1>))]
public sealed record Rendition1 : StringEnum<Rendition1>
{
    private Rendition1(string value) : base(value)
    {
    }

    public static readonly Rendition1 _2K = new("2k");

    public static readonly Rendition1 _4K = new("4k");

    public static readonly Rendition1 _5K = new("5k");

    public static readonly Rendition1 _6K = new("6k");

    public static readonly Rendition1 _7K = new("7k");

    public static readonly Rendition1 _8K = new("8k");

    public static readonly Rendition1 _240P = new("240p");

    public static readonly Rendition1 _360P = new("360p");

    public static readonly Rendition1 _480P = new("480p");

    public static readonly Rendition1 _540P = new("540p");

    public static readonly Rendition1 _720P = new("720p");

    public static readonly Rendition1 _1080P = new("1080p");

    public static Rendition1 FromValue(string value) => FromValueCore(value);
}
