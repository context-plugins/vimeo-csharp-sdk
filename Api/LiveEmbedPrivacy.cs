using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core;
using VimeoApi.Core.Authentication;
using VimeoApi.Core.Exceptions;
using VimeoApi.Core.Models;
using VimeoApi.Core.Request;
using VimeoApi.Core.Response;
using VimeoApi.Errors;
using VimeoApi.Models;

namespace VimeoApi.Api;

/// <summary>
/// Use these methods to work with embed privacy for events.
/// </summary>
public sealed class LiveEmbedPrivacy
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveEmbedPrivacy(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get all the domains on which an event can be embedded
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DomainConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventWhitelistError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every permitted domain for an event. The embed privacy setting must be <c>whitelist</c>.
    /// </remarks>
    public Task<DomainConnection> GetLiveEventWhitelist(double liveEventId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/privacy/domains"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DomainConnection>(),
            GetLiveEventWhitelistErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the domains on which an event can be embedded
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DomainConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventWhitelistAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every permitted domain for an event. The embed privacy setting must be <c>whitelist</c>.
    /// </remarks>
    public Task<DomainConnection> GetLiveEventWhitelistAlt1(double liveEventId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/privacy/domains"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DomainConnection>(),
            GetLiveEventWhitelistAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the domains on which an event can be embedded
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DomainConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventWhitelistAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every permitted domain for an event. The embed privacy setting must be <c>whitelist</c>.
    /// </remarks>
    public Task<DomainConnection> GetLiveEventWhitelistAlt2(double liveEventId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/privacy/domains"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DomainConnection>(),
            GetLiveEventWhitelistAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Embed an event on one or more domains
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetLiveEventWhitelistError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method embeds an event on the specified domains. The embed privacy setting must be <c>whitelist</c>.
    /// </remarks>
    public Task SetLiveEventWhitelist(double liveEventId,
        double userId,
        UsersLiveEventsPrivacyDomainsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/privacy/domains"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            SetLiveEventWhitelistErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Embed an event on one or more domains
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetLiveEventWhitelistAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method embeds an event on the specified domains. The embed privacy setting must be <c>whitelist</c>.
    /// </remarks>
    public Task SetLiveEventWhitelistAlt1(double liveEventId,
        LiveEventsPrivacyDomainsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/privacy/domains"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            SetLiveEventWhitelistAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Embed an event on one or more domains
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetLiveEventWhitelistAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method embeds an event on the specified domains. The embed privacy setting must be <c>whitelist</c>.
    /// </remarks>
    public Task SetLiveEventWhitelistAlt2(double liveEventId,
        MeLiveEventsPrivacyDomainsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/privacy/domains"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            SetLiveEventWhitelistAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
