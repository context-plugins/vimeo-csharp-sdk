using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The upload approach.
/// <para>
/// Option descriptions:
///  * <c>post</c> - Use the POST approach.
///  * <c>pull</c> - Use the pull approach.
///  * <c>tus</c> - Use the tus approach.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Approach2>))]
public sealed record Approach2 : StringEnum<Approach2>
{
    private Approach2(string value) : base(value)
    {
    }

    public static readonly Approach2 Post = new("post");

    public static readonly Approach2 Pull = new("pull");

    public static readonly Approach2 Tus = new("tus");

    public static Approach2 FromValue(string value) => FromValueCore(value);
}
