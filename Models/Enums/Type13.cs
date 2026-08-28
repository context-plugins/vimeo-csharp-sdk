using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The Vimeo content to which the reply relates.
/// <para>
/// Option descriptions:
///  * <c>video</c> - The comment is about a video.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type13>))]
public sealed record Type13 : StringEnum<Type13>
{
    private Type13(string value) : base(value)
    {
    }

    public static readonly Type13 Video = new("video");

    public static Type13 FromValue(string value) => FromValueCore(value);
}
