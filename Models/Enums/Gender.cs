using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The authenticated user's gender.
/// <para>
/// Option descriptions:
///  * <c>f</c> - The user's preferred pronouns are she and her.
///  * <c>m</c> - The user's preferred pronouns are he and him.
///  * <c>n</c> - The user would rather not give preferred pronouns.
///  * <c>o</c> - The user's preferred pronouns are they and them.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Gender>))]
public sealed record Gender : StringEnum<Gender>
{
    private Gender(string value) : base(value)
    {
    }

    public static readonly Gender F = new("f");

    public static readonly Gender M = new("m");

    public static readonly Gender N = new("n");

    public static readonly Gender O = new("o");

    public static Gender FromValue(string value) => FromValueCore(value);
}
