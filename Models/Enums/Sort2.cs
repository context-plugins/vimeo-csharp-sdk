using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort2>))]
public sealed record Sort2 : StringEnum<Sort2>
{
    private Sort2(string value) : base(value)
    {
    }

    public static readonly Sort2 Alphabetical = new("alphabetical");

    public static readonly Sort2 Comments = new("comments");

    public static readonly Sort2 Date = new("date");

    public static readonly Sort2 Default = new("default");

    public static readonly Sort2 Duration = new("duration");

    public static readonly Sort2 LastUserActionEventDate = new("last_user_action_event_date");

    public static readonly Sort2 Likes = new("likes");

    public static readonly Sort2 ModifiedTime = new("modified_time");

    public static readonly Sort2 Plays = new("plays");

    public static Sort2 FromValue(string value) => FromValueCore(value);
}
