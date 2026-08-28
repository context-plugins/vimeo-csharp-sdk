using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The preset outro type.
/// <para>
/// Option descriptions:
///  * <c>link</c> - The outro includes a link.
///  * <c>no idea</c> - The outro type is <c>no idea</c>. The outro includes uploaded videos.
///  * <c>text</c> - The outro includes text.
///  * <c>uploaded_clips</c> - The outro includes uploaded videos.
///  * <c>uploaded_videos</c> - The outro includes uploaded videos.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type26>))]
public sealed record Type26 : StringEnum<Type26>
{
    private Type26(string value) : base(value)
    {
    }

    public static readonly Type26 Link = new("link");

    public static readonly Type26 NoIdea = new("no idea");

    public static readonly Type26 Text = new("text");

    public static readonly Type26 UploadedClips = new("uploaded_clips");

    public static readonly Type26 UploadedVideos = new("uploaded_videos");

    public static Type26 FromValue(string value) => FromValueCore(value);
}
