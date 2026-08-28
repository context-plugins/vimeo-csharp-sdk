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
/// Use these methods to work with the automated closed captions preferences of events.
/// </summary>
public sealed class LiveEventAutomatedClosedCaptions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveEventAutomatedClosedCaptions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Edit the automated closed captions preference of an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventAutomatedClosedCaptions"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditLiveEventAutoCcError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the automated closed captions preference for the specified event.
    /// </remarks>
    public Task<EventAutomatedClosedCaptions> EditLiveEventAutoCc(double liveEventId,
        double userId,
        UsersLiveEventsAutoCcRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/auto_cc"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<EventAutomatedClosedCaptions>(),
            EditLiveEventAutoCcErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit the automated closed captions preference of an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventAutomatedClosedCaptions"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditLiveEventAutoCcAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the automated closed captions preference for the specified event.
    /// </remarks>
    public Task<EventAutomatedClosedCaptions> EditLiveEventAutoCcAlt1(double liveEventId,
        LiveEventsAutoCcRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/auto_cc"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<EventAutomatedClosedCaptions>(),
            EditLiveEventAutoCcAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit the automated closed captions preference of an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventAutomatedClosedCaptions"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditLiveEventAutoCcAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the automated closed captions preference for the specified event.
    /// </remarks>
    public Task<EventAutomatedClosedCaptions> EditLiveEventAutoCcAlt2(double liveEventId,
        MeLiveEventsAutoCcRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/auto_cc"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<EventAutomatedClosedCaptions>(),
            EditLiveEventAutoCcAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
