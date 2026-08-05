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
/// Use these methods to work with the ending of events.
/// </summary>
public sealed class LiveEventEnd
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveEventEnd(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// End an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId"></param>
    /// <param name="clipId">The ID of the streamable video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EndLiveEventError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method ends the specified event. The authenticated user must be the owner of the event.
    /// </remarks>
    public Task<Video> EndLiveEvent(double liveEventId,
        string userId,
        double? clipId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/end"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [new Param("clip_id", clipId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            EndLiveEventErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// End an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="clipId">The ID of the streamable video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EndLiveEventAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method ends the specified event. The authenticated user must be the owner of the event.
    /// </remarks>
    public Task<Video> EndLiveEventAlt1(double liveEventId,
        double? clipId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/end"),
            [new TemplateParam("live_event_id", liveEventId)],
            [new Param("clip_id", clipId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            EndLiveEventAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// End an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="clipId">The ID of the streamable video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EndLiveEventAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method ends the specified event. The authenticated user must be the owner of the event.
    /// </remarks>
    public Task<Video> EndLiveEventAlt2(double liveEventId,
        double? clipId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/end"),
            [new TemplateParam("live_event_id", liveEventId)],
            [new Param("clip_id", clipId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            EndLiveEventAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
