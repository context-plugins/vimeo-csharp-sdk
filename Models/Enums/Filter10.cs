using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter10>))]
public sealed record Filter10 : StringEnum<Filter10>
{
    private Filter10(string value) : base(value)
    {
    }

    public static readonly Filter10 Embeddable = new("embeddable");

    public static readonly Filter10 Playable = new("playable");

    public static Filter10 FromValue(string value) => FromValueCore(value);
}
