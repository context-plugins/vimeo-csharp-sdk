using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort37>))]
public sealed record Sort37 : StringEnum<Sort37>
{
    private Sort37(string value) : base(value)
    {
    }

    public static readonly Sort37 Alphabetical = new("alphabetical");

    public static readonly Sort37 Date = new("date");

    public static readonly Sort37 Default = new("default");

    public static readonly Sort37 Duration = new("duration");

    public static readonly Sort37 LastUserActionEventDate = new("last_user_action_event_date");

    public static Sort37 FromValue(string value) => FromValueCore(value);
}
