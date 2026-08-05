using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of upload approach. For more information about upload approaches, refer to <see href="https://developer.vimeo.com/api/upload/videos#understanding-upload-approaches">Working with Video Uploads</see>.
/// <para>
/// Option descriptions:
///  * <c>post</c> - The upload approach is POST.
///  * <c>pull</c> - The upload approach is pull.
///  * <c>tus</c> - The upload approach is tus.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Approach5>))]
public sealed record Approach5 : StringEnum<Approach5>
{
    private Approach5(string value) : base(value)
    {
    }

    public static readonly Approach5 Post = new("post");

    public static readonly Approach5 Pull = new("pull");

    public static readonly Approach5 Tus = new("tus");

    public static Approach5 FromValue(string value) => FromValueCore(value);
}
