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
/// Use these methods to work with event media.
/// </summary>
public sealed class LiveGraphics
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveGraphics(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a new video graphics item to an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ComposerGraphics"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddComposerVideoGraphicItemError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method add a new video graphics item to the specified event.
    /// </remarks>
    public Task<ComposerGraphics> AddComposerVideoGraphicItem(double liveEventId,
        LiveEventsComposerGraphicsVideosRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/composer/graphics/videos"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ComposerGraphics>(),
            AddComposerVideoGraphicItemErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a video graphics item that belongs to an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="videoId">The ID of the associated video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteComposerVideoGraphicItemError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes a video graphics item belonging to the specified event.
    /// </remarks>
    public Task DeleteComposerVideoGraphicItem(double liveEventId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/composer/graphics/videos/{video_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteComposerVideoGraphicItemErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the video graphics items that belong to an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ComposerGraphicsConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetComposerVideoGraphicItemsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The method returns every video graphics item belonging to the specified event.
    /// </remarks>
    public Task<ComposerGraphicsConnection> GetComposerVideoGraphicItems(double liveEventId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/composer/graphics/videos"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ComposerGraphicsConnection>(),
            GetComposerVideoGraphicItemsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
