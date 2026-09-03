using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ScoringAlgorithm>))]
public sealed record ScoringAlgorithm : StringEnum<ScoringAlgorithm>
{
    private ScoringAlgorithm(string value) : base(value)
    {
    }

    public static readonly ScoringAlgorithm Passfail = new("passfail");

    public static readonly ScoringAlgorithm Percentage = new("percentage");

    public static readonly ScoringAlgorithm Quiz = new("quiz");

    public static ScoringAlgorithm FromValue(string value) => FromValueCore(value);
}
