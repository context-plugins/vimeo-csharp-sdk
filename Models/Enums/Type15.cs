using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The Vimeo content to which the comment relates.
/// <para>
/// Option descriptions:
///  * <c>video</c> - The comment is about a video.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type15>))]
public sealed record Type15 : StringEnum<Type15>
{
    private Type15(string value) : base(value)
    {
    }

    public static readonly Type15 Video = new("video");

    public static Type15 FromValue(string value) => FromValueCore(value);
}
