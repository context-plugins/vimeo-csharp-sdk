using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort39>))]
public sealed record Sort39 : StringEnum<Sort39>
{
    private Sort39(string value) : base(value)
    {
    }

    public static readonly Sort39 Alphabetical = new("alphabetical");

    public static readonly Sort39 Date = new("date");

    public static readonly Sort39 Default = new("default");

    public static readonly Sort39 Duration = new("duration");

    public static readonly Sort39 LastUserActionEventDate = new("last_user_action_event_date");

    public static readonly Sort39 Likes = new("likes");

    public static readonly Sort39 ModifiedTime = new("modified_time");

    public static readonly Sort39 Plays = new("plays");

    public static Sort39 FromValue(string value) => FromValueCore(value);
}
