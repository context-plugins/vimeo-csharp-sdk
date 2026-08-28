using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort73>))]
public sealed record Sort73 : StringEnum<Sort73>
{
    private Sort73(string value) : base(value)
    {
    }

    public static readonly Sort73 Alphabetical = new("alphabetical");

    public static readonly Sort73 Comments = new("comments");

    public static readonly Sort73 Date = new("date");

    public static readonly Sort73 Duration = new("duration");

    public static readonly Sort73 Likes = new("likes");

    public static readonly Sort73 Plays = new("plays");

    public static readonly Sort73 Relevant = new("relevant");

    public static Sort73 FromValue(string value) => FromValueCore(value);
}
