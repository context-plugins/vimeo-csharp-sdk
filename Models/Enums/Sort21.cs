using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort21>))]
public sealed record Sort21 : StringEnum<Sort21>
{
    private Sort21(string value) : base(value)
    {
    }

    public static readonly Sort21 Alphabetical = new("alphabetical");

    public static readonly Sort21 Comments = new("comments");

    public static readonly Sort21 Date = new("date");

    public static readonly Sort21 Default = new("default");

    public static readonly Sort21 Duration = new("duration");

    public static readonly Sort21 Likes = new("likes");

    public static readonly Sort21 Manual = new("manual");

    public static readonly Sort21 ModifiedTime = new("modified_time");

    public static readonly Sort21 Plays = new("plays");

    public static Sort21 FromValue(string value) => FromValueCore(value);
}
