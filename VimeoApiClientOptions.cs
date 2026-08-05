using VimeoApi.Core.Authentication.OAuth2;
using VimeoApi.Core.Authentication.OAuth2.AuthorizationCode;
using VimeoApi.Core.Authentication.OAuth2.ClientCredentials;
using VimeoApi.Core.Configuration;
using VimeoApi.Servers;

namespace VimeoApi;

public class VimeoApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public string? Bearer { get; set; }
    public OAuth2AuthorizationCodeCredentials? Oauth2AuthorizationCode { get; set; }
    public IOAuth2RefreshableTokenStrategy<OAuth2AuthorizationCodeCredentials>? Oauth2AuthorizationCodeTokenStrategy { get; set; }
    public OAuth2ClientCredentials? Oauth2ClientCredentials { get; set; }
    public IOAuth2TokenStrategy<OAuth2ClientCredentials>? Oauth2ClientCredentialsTokenStrategy { get; set; }
}
