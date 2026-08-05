using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of text decoration.
/// <para>
/// Option descriptions:
///  * <c>url</c> - The URL of the Vimeo video.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type12>))]
public sealed record Type12 : StringEnum<Type12>
{
    private Type12(string value) : base(value)
    {
    }

    public static readonly Type12 Url = new("url");

    public static Type12 FromValue(string value) => FromValueCore(value);
}
