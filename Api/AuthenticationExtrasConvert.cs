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
/// Use these methods to convert authentication resources.
/// </summary>
public sealed class AuthenticationExtrasConvert
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AuthenticationExtrasConvert(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Convert an OAuth 1 access token to an OAuth 2 access token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Auth"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ConvertAccessTokenError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method exchanges a legacy Advanced API OAuth 1 token for an API v3 OAuth 2 token.
    /// </remarks>
    public Task<Auth> ConvertAccessToken(OauthAuthorizeVimeoOauth1Request body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth/authorize/vimeo_oauth1"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Auth>(),
            ConvertAccessTokenErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
