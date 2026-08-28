using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The approach by which to upload the version.
/// <para>
/// Option descriptions:
///  * <c>post</c> - Use the POST approach.
///  * <c>pull</c> - Use the pull approach.
///  * <c>tus</c> - Use the tus approach.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Approach4>))]
public sealed record Approach4 : StringEnum<Approach4>
{
    private Approach4(string value) : base(value)
    {
    }

    public static readonly Approach4 Post = new("post");

    public static readonly Approach4 Pull = new("pull");

    public static readonly Approach4 Tus = new("tus");

    public static Approach4 FromValue(string value) => FromValueCore(value);
}
