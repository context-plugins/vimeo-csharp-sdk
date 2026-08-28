using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record ReportReasonNode
{
    /// <summary>
    /// A human-readable description of the category or leaf.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// For external-handoff leaves, the dedicated form to use instead of this endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_url")]
    public string? ExternalUrl { get; init; }

    /// <summary>
    /// For reason leaves with a gender fork, the distinct variant to submit when the target is a woman or girl.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gendered")]
    public ReportReasonGenderedVariant? Gendered { get; init; }

    /// <summary>
    /// Stable identifier for this node: the opaque reason UUID for a submittable leaf, or a slug for a category or external-handoff leaf.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The node kind.
    /// <para>
    /// Option descriptions:
    ///  * <c>category</c> - A grouping node; its children reference it via <c>parent_id</c>.
    ///  * <c>external</c> - Handed off to a dedicated form (see <c>external_url</c>), not POST-able here.
    ///  * <c>reason</c> - A submittable leaf; its <c>id</c> is the opaque reason UUID to POST.
    /// </para>
    /// </summary>
    [JsonPropertyName("kind")]
    public required Kind Kind { get; init; }

    /// <summary>
    /// The display name for the category or leaf.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The <c>id</c> of the node this is nested under, or <c>null</c> at the top level.
    /// </summary>
    [JsonPropertyName("parent_id")]
    public required string? ParentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
