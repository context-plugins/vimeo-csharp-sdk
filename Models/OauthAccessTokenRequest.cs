using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record OauthAccessTokenRequest
{
    /// <summary>
    /// The authorization code received from the authorization server.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// The grant type. The value of this field must be <c>authorization_code</c>.
    /// <para>
    /// Option descriptions:
    ///  * <c>authorization_code</c> - The grant type is for an authorization code.
    /// </para>
    /// </summary>
    [JsonPropertyName("grant_type")]
    public required GrantType GrantType { get; init; }

    /// <summary>
    /// The redirect URI. The value of this field must match the URI from <c>/oauth/authorize</c>.
    /// </summary>
    [JsonPropertyName("redirect_uri")]
    public required string RedirectUri { get; init; }
}
