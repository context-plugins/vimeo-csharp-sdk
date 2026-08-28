using Vimeo.Core;
using Vimeo.Core.Authentication;
using Vimeo.Core.Authentication.Bearer;
using Vimeo.Core.Authentication.OAuth2;
using Vimeo.Core.Authentication.OAuth2.AuthorizationCode;
using Vimeo.Core.Authentication.OAuth2.ClientCredentials;

namespace Vimeo;

internal sealed class AuthSchemes
{
    public IAuthScheme Bearer { get; }
    public IAuthScheme Oauth2ClientCredentials { get; }
    public IAuthScheme Oauth2AuthorizationCode { get; }

    public AuthSchemes(VimeoClientOptions options, Server server, RawClient rawClient, UriFactory urlFactory)
    {
        Bearer = BearerAuthScheme.Create(options.Bearer);
        Oauth2ClientCredentials =
            OAuth2Scheme<OAuth2ClientCredentials>.Create(options.Oauth2ClientCredentials,
                options.Oauth2ClientCredentialsTokenStrategy ??
                    OAuth2ClientCredentialsStrategy.ForBasicAuthRequest(server.Default("/oauth/authorize/client"), rawClient));
        Oauth2AuthorizationCode =
            OAuth2RefreshableScheme<OAuth2AuthorizationCodeCredentials>.Create(options.Oauth2AuthorizationCode,
                options.Oauth2AuthorizationCodeTokenStrategy ??
                    OAuth2AuthorizationCodeStrategy.ForBasicAuthRequest(server.Default("/oauth/authorize"),
                        server.Default("/oauth/access_token"),
                        rawClient,
                        urlFactory));
    }
}
