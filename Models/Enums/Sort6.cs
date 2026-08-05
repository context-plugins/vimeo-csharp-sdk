using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort6>))]
public sealed record Sort6 : StringEnum<Sort6>
{
    private Sort6(string value) : base(value)
    {
    }

    public static readonly Sort6 Alphabetical = new("alphabetical");

    public static readonly Sort6 Comments = new("comments");

    public static readonly Sort6 Date = new("date");

    public static readonly Sort6 Duration = new("duration");

    public static readonly Sort6 Featured = new("featured");

    public static readonly Sort6 Likes = new("likes");

    public static readonly Sort6 Plays = new("plays");

    public static readonly Sort6 Relevant = new("relevant");

    public static Sort6 FromValue(string value) => FromValueCore(value);
}
