using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The user's role type. This data requires a bearer token with the <c>private</c> scope.
/// <para>
/// Option descriptions:
///  * <c>member</c> - The user is a member.
///  * <c>moderator</c> - The user is a moderator.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type8>))]
public sealed record Type8 : StringEnum<Type8>
{
    private Type8(string value) : base(value)
    {
    }

    public static readonly Type8 Member = new("member");

    public static readonly Type8 Moderator = new("moderator");

    public static Type8 FromValue(string value) => FromValueCore(value);
}
