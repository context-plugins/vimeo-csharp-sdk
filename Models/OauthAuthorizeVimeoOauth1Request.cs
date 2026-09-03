using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record OauthAuthorizeVimeoOauth1Request
{
    /// <summary>
    /// The grant type. The value of this field must be <c>vimeo_oauth1</c>.
    /// <para>
    /// Option descriptions:
    ///  * <c>vimeo_oauth1</c> - The grant type is for the OAuth1 token.
    /// </para>
    /// </summary>
    [JsonPropertyName("grant_type")]
    public string GrantType { get; } = "vimeo_oauth1";

    /// <summary>
    /// The OAuth 1 token.
    /// </summary>
    [JsonPropertyName("token")]
    public required string Token { get; init; }

    /// <summary>
    /// The OAuth 1 token secret.
    /// </summary>
    [JsonPropertyName("token_secret")]
    public required string TokenSecret { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
