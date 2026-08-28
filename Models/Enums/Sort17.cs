using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort17>))]
public sealed record Sort17 : StringEnum<Sort17>
{
    private Sort17(string value) : base(value)
    {
    }

    public static readonly Sort17 Added = new("added");

    public static readonly Sort17 Alphabetical = new("alphabetical");

    public static readonly Sort17 Arranged = new("arranged");

    public static readonly Sort17 Comments = new("comments");

    public static readonly Sort17 Date = new("date");

    public static readonly Sort17 Duration = new("duration");

    public static readonly Sort17 Likes = new("likes");

    public static readonly Sort17 Plays = new("plays");

    public static Sort17 FromValue(string value) => FromValueCore(value);
}
