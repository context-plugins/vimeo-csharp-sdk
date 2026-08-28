using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record VideoReportReason
{
    /// <summary>
    /// The DSA-aligned report reason taxonomy, flattened to a parent-referenced node list (categories, submittable leaves, and external-handoff leaves). A parent always precedes its descendants, so the tree rebuilds in one pass.
    /// </summary>
    [JsonPropertyName("reasons")]
    public required IReadOnlyList<ReportReasonNode> Reasons { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
