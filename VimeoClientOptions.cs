using System.Collections.Generic;
using Vimeo.Core.Authentication.OAuth2;
using Vimeo.Core.Authentication.OAuth2.AuthorizationCode;
using Vimeo.Core.Authentication.OAuth2.ClientCredentials;
using Vimeo.Core.Configuration;
using Vimeo.Core.Hooks;
using Vimeo.Servers;

namespace Vimeo;

public class VimeoClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    public string? Bearer { get; set; }
    public OAuth2AuthorizationCodeCredentials? Oauth2AuthorizationCode { get; set; }
    public IOAuth2RefreshableTokenStrategy<OAuth2AuthorizationCodeCredentials>? Oauth2AuthorizationCodeTokenStrategy { get; set; }
    public OAuth2ClientCredentials? Oauth2ClientCredentials { get; set; }
    public IOAuth2TokenStrategy<OAuth2ClientCredentials>? Oauth2ClientCredentialsTokenStrategy { get; set; }
}
