using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The way in which the promotion generates promo codes.
/// <para>
/// Option descriptions:
///  * <c>batch</c> - The promotion provides a unique promotional code for each user.
///  * <c>batch_prefix</c> - Like <c>batch</c>, except that all codes have a similar prefix string. _This option is deprecated, yet it may still appear for some users._
///  * <c>single</c> - The promotion provides a single promotional code for all users.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type22>))]
public sealed record Type22 : StringEnum<Type22>
{
    private Type22(string value) : base(value)
    {
    }

    public static readonly Type22 Batch = new("batch");

    public static readonly Type22 BatchPrefix = new("batch_prefix");

    public static readonly Type22 Single = new("single");

    public static Type22 FromValue(string value) => FromValueCore(value);
}
