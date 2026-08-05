using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record LiveEventOccurrenceConnection
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    public int? Total { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page")]
    public int? Page { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("per_page")]
    public int? PerPage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paging")]
    public Paging? Paging { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<LiveEventOccurrence>? Data { get; init; }
}
