using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type52>))]
public sealed record Type52 : StringEnum<Type52>
{
    private Type52(string value) : base(value)
    {
    }

    public static readonly Type52 Dubbing = new("dubbing");

    public static readonly Type52 Subtitling = new("subtitling");

    public static readonly Type52 Transcription = new("transcription");

    public static Type52 FromValue(string value) => FromValueCore(value);
}
