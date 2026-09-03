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
/// Use these methods to manage an event's low-latency option.
/// </summary>
public sealed class LiveEventLowLatency
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveEventLowLatency(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Toggle the low-latency option of an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEventLowLatency"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ToggleRleLowLatencyError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method toggles the low-latency option of the specified event.
    /// </remarks>
    public Task<RecurringEventLowLatency> ToggleRleLowLatency(double liveEventId,
        double userId,
        UsersLiveEventsLowLatencyRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/low_latency"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringEventLowLatency>(),
            ToggleRleLowLatencyErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Toggle the low-latency option of an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEventLowLatency"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ToggleRleLowLatencyAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method toggles the low-latency option of the specified event.
    /// </remarks>
    public Task<RecurringEventLowLatency> ToggleRleLowLatencyAlt1(double liveEventId,
        LiveEventsLowLatencyRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/low_latency"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringEventLowLatency>(),
            ToggleRleLowLatencyAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Toggle the low-latency option of an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEventLowLatency"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ToggleRleLowLatencyAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method toggles the low-latency option of the specified event.
    /// </remarks>
    public Task<RecurringEventLowLatency> ToggleRleLowLatencyAlt2(double liveEventId,
        MeLiveEventsLowLatencyRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/low_latency"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringEventLowLatency>(),
            ToggleRleLowLatencyAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
