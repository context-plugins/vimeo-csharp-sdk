using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// The privacy settings of the folder.
/// </summary>
public record Privacy2
{
    /// <summary>
    /// The privacy setting for accessing the folder.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone with the link can access the contents of the folder. This privacy setting appears as <c>Public</c> on the Vimeo front end.
    ///  * <c>nobody</c> - Only the owner and those team members that the owner has explicitly invited can access the contents of the folder. This privacy setting appears as <c>Private</c> on the Vimeo front end.
    ///  * <c>team</c> - Only those team members with the link can access the contents of the folder.
    /// </para>
    /// </summary>
    [JsonPropertyName("view")]
    public required View3 View { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
