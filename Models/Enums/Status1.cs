using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The status of the authenticated user's trial.
/// <para>
/// Option descriptions:
///  * <c>free_trial</c> - The user is currently in a free trial.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : StringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 FreeTrial = new("free_trial");

    public static Status1 FromValue(string value) => FromValueCore(value);
}
