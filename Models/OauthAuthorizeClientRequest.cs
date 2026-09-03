using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record OauthAuthorizeClientRequest
{
    /// <summary>
    /// The grant type. The value of this field must be <c>client_credentials</c>.
    /// <para>
    /// Option descriptions:
    ///  * <c>client_credentials</c> - The grant type is for the client credentials.
    /// </para>
    /// </summary>
    [JsonPropertyName("grant_type")]
    public string GrantType { get; } = "client_credentials";

    /// <summary>
    /// A space-separated list of the authentication scopes to access. The default is <c>public</c>.
    /// </summary>
    [JsonPropertyName("scope")]
    public required string Scope { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
