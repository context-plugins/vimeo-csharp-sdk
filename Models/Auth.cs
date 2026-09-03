using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Auth
{
    /// <summary>
    /// The access token string.
    /// </summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    /// <summary>
    /// The API application associated with the token.
    /// </summary>
    [JsonPropertyName("app")]
    public required ApiApp App { get; init; }

    /// <summary>
    /// The token's expiration date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_on")]
    public string? ExpiresOn { get; init; }

    /// <summary>
    /// The refresh token string. The Vimeo API doesn't currently support refresh tokens, but we plan to add this support in the future.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; init; }

    /// <summary>
    /// The scope or scopes that the token supports.
    /// </summary>
    [JsonPropertyName("scope")]
    public required string Scope { get; init; }

    /// <summary>
    /// The token type.
    /// <para>
    /// Option descriptions:
    ///  * <c>bearer</c> - The token is of the bearer type.
    /// </para>
    /// </summary>
    [JsonPropertyName("token_type")]
    public string TokenType { get; } = "bearer";

    /// <summary>
    /// The user associated with the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public User? User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
