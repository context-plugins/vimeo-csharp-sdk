using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UsersProjectsRequest
{
    /// <summary>
    /// The name of the folder.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The URI of the parent folder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parent_folder_uri")]
    public string? ParentFolderUri { get; init; }
}
