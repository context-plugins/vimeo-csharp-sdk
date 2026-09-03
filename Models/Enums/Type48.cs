using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type48>))]
public sealed record Type48 : StringEnum<Type48>
{
    private Type48(string value) : base(value)
    {
    }

    public static readonly Type48 Dubbing = new("dubbing");

    public static readonly Type48 Subtitling = new("subtitling");

    public static readonly Type48 Transcription = new("transcription");

    public static Type48 FromValue(string value) => FromValueCore(value);
}
