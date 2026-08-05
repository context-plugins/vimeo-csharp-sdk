using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort35>))]
public sealed record Sort35 : StringEnum<Sort35>
{
    private Sort35(string value) : base(value)
    {
    }

    public static readonly Sort35 Alphabetical = new("alphabetical");

    public static readonly Sort35 Comments = new("comments");

    public static readonly Sort35 Date = new("date");

    public static readonly Sort35 Default = new("default");

    public static readonly Sort35 Likes = new("likes");

    public static readonly Sort35 Manual = new("manual");

    public static readonly Sort35 Plays = new("plays");

    public static Sort35 FromValue(string value) => FromValueCore(value);
}
