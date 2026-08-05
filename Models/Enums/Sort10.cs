using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort10>))]
public sealed record Sort10 : StringEnum<Sort10>
{
    private Sort10(string value) : base(value)
    {
    }

    public static readonly Sort10 Added = new("added");

    public static readonly Sort10 Alphabetical = new("alphabetical");

    public static readonly Sort10 Comments = new("comments");

    public static readonly Sort10 Date = new("date");

    public static readonly Sort10 Default = new("default");

    public static readonly Sort10 Duration = new("duration");

    public static readonly Sort10 Likes = new("likes");

    public static readonly Sort10 Manual = new("manual");

    public static readonly Sort10 ModifiedTime = new("modified_time");

    public static readonly Sort10 Plays = new("plays");

    public static Sort10 FromValue(string value) => FromValueCore(value);
}
