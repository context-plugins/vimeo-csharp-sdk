using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<QueryFields>))]
public sealed record QueryFields : StringEnum<QueryFields>
{
    private QueryFields(string value) : base(value)
    {
    }

    public static readonly QueryFields Chapters = new("chapters");

    public static readonly QueryFields Description = new("description");

    public static readonly QueryFields Tags = new("tags");

    public static readonly QueryFields Title = new("title");

    public static QueryFields FromValue(string value) => FromValueCore(value);
}
