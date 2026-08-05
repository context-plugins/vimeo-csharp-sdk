using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The authenticated user's role type. This data requires a bearer token with the <c>private</c> scope.
/// <para>
/// Option descriptions:
///  * <c>moderator</c> - The authenticated user is a moderator.
///  * <c>subscriber</c> - The authenticated user is a subscriber.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : StringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 Moderator = new("moderator");

    public static readonly Type1 Subscriber = new("subscriber");

    public static Type1 FromValue(string value) => FromValueCore(value);
}
