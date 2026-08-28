using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record UsersRequest
{
    /// <summary>
    /// The user's bio.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bio")]
    public string? Bio { get; init; }

    /// <summary>
    /// A list of values describing the content in the user's videos. Find the full list in the <see href="https://developer.vimeo.com/api/reference/videos#get_content_ratings">/contentratings</see> endpoint. You must provide a comma-separated list if you're using a query string or an array if you're using JSON.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("content_filter")]
    public IReadOnlyList<string>? ContentFilter { get; init; }

    /// <summary>
    /// The authenticated user's gender.
    /// <para>
    /// Option descriptions:
    ///  * <c>f</c> - The user's preferred pronouns are she and her.
    ///  * <c>m</c> - The user's preferred pronouns are he and him.
    ///  * <c>n</c> - The user would rather not give preferred pronouns.
    ///  * <c>o</c> - The user's preferred pronouns are they and them.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gender")]
    public Gender? Gender { get; init; }

    /// <summary>
    /// The user's custom Vimeo URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public string? Link { get; init; }

    /// <summary>
    /// The user's location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string? Location { get; init; }

    /// <summary>
    /// The user's display name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The default password for all future videos that this user uploads. To use this field, the <b>videos.privacy.view</b> field must be <c>password</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("videos")]
    public Videos18? Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
