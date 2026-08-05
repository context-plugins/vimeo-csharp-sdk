using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record CreativeCommons
{
    /// <summary>
    /// The type of Creative Commons license.
    /// <para>
    /// Option descriptions:
    ///  * <c>by</c> - Attribution.
    ///  * <c>by-nc</c> - Attribution Non-Commercial.
    ///  * <c>by-nc-nd</c> - Attribution Non-Commercial No Derivatives.
    ///  * <c>by-nc-sa</c> - Attribution Non-Commercial Share Alike.
    ///  * <c>by-nd</c> - Attribution No Derivatives.
    ///  * <c>by-sa</c> - Attribution Share Alike.
    ///  * <c>cc0</c> - Public Domain Dedication.
    /// </para>
    /// </summary>
    [JsonPropertyName("code")]
    public required Code1 Code { get; init; }

    /// <summary>
    /// The description of the Creative Commons license.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The canonical relative URI of the Creative Commons license.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string? Uri { get; init; }
}
