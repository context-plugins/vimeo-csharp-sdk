using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort15>))]
public sealed record Sort15 : StringEnum<Sort15>
{
    private Sort15(string value) : base(value)
    {
    }

    public static readonly Sort15 Alphabetical = new("alphabetical");

    public static readonly Sort15 Comments = new("comments");

    public static readonly Sort15 Date = new("date");

    public static readonly Sort15 Duration = new("duration");

    public static readonly Sort15 Likes = new("likes");

    public static readonly Sort15 Plays = new("plays");

    public static Sort15 FromValue(string value) => FromValueCore(value);
}
