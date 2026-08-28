using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core;
using Vimeo.Core.Authentication;
using Vimeo.Core.Exceptions;
using Vimeo.Core.Models;
using Vimeo.Core.Request;
using Vimeo.Core.Response;
using Vimeo.Errors;
using Vimeo.Models;

namespace Vimeo.Api;

/// <summary>
/// Use these methods to perform authentication.
/// </summary>
public sealed class AuthenticationExtrasAuthenticate
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AuthenticationExtrasAuthenticate(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Authorize a client with OAuth
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Auth"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClientAuthError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method uses the OAuth protocol to authorize a client. For details on OAuth client authorization, see our <see href="/api/authentication">Working with Authentication</see> guide or the <see href="https://tools.ietf.org/html/draft-ietf-oauth-v2-31#section-4.4">OAuth spec</see>.
    /// </remarks>
    public Task<Auth> ClientAuth(OauthAuthorizeClientRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth/authorize/client"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Auth>(),
            ClientAuthErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
