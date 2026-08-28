using System;
using System.Collections.Generic;
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
/// Use these methods to work with event scenes.
/// </summary>
public sealed class LiveScenes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveScenes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Attach a graphic item to a scene
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="sceneId">The ID of the scene.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ComposerScenes"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AttachGraphicItemToSceneError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method attaches a graphic item to the specified scene.
    /// </remarks>
    public Task<ComposerScenes> AttachGraphicItemToScene(double liveEventId,
        string sceneId,
        LiveEventsComposerScenesGraphicsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/composer/scenes/{scene_id}/graphics"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("scene_id", sceneId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ComposerScenes>(),
            AttachGraphicItemToSceneErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a scene for an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ComposerScenes"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateComposerSceneError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The method creates a new scene for the specified event.
    /// </remarks>
    public Task<ComposerScenes> CreateComposerScene(double liveEventId,
        LiveEventsComposerScenesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/composer/scenes"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ComposerScenes>(),
            CreateComposerSceneErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the scenes that belong to an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ComposerScenesConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetComposerScenesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The method returns every scene belonging to the specified event.
    /// </remarks>
    public Task<ComposerScenesConnection> GetComposerScenes(double liveEventId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/composer/scenes"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ComposerScenesConnection>(),
            GetComposerScenesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Reset the scenes that belong to an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ComposerScenes"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ResetComposerScenesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The method resets the scenes that belong to the specified event by deleting every existing scene and then recreating the default scene.
    /// </remarks>
    public Task<IReadOnlyList<ComposerScenes>> ResetComposerScenes(double liveEventId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/composer/scenes"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ComposerScenes>>(),
            ResetComposerScenesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Update the scene that belong to an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="sceneId">The ID of the scene.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ComposerScenes"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateComposerSceneError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The method updates a scene belonging to the specified event.
    /// </remarks>
    public Task<ComposerScenes> UpdateComposerScene(double liveEventId,
        string sceneId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/composer/scenes/{scene_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("scene_id", sceneId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<ComposerScenes>(),
            UpdateComposerSceneErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
