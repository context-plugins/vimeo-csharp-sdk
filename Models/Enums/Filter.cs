using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter>))]
public sealed record Filter : StringEnum<Filter>
{
    private Filter(string value) : base(value)
    {
    }

    public static readonly Filter ConditionalFeatured = new("conditional_featured");

    public static readonly Filter Embeddable = new("embeddable");

    public static Filter FromValue(string value) => FromValueCore(value);
}
