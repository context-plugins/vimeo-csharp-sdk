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
/// Use these methods to work with the thumbnail images of events.
/// </summary>
public sealed class LiveEventThumbnails
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveEventThumbnails(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateLiveEventThumbnailError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a thumbnail image for the specified event.
    /// </remarks>
    public Task<Picture> CreateLiveEventThumbnail(double liveEventId,
        double userId,
        UsersLiveEventsPicturesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/pictures"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            CreateLiveEventThumbnailErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create an event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateLiveEventThumbnailAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a thumbnail image for the specified event.
    /// </remarks>
    public Task<Picture> CreateLiveEventThumbnailAlt1(double liveEventId,
        LiveEventsPicturesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/pictures"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            CreateLiveEventThumbnailAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create an event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateLiveEventThumbnailAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a thumbnail image for the specified event.
    /// </remarks>
    public Task<Picture> CreateLiveEventThumbnailAlt2(double liveEventId,
        MeLiveEventsPicturesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/pictures"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            CreateLiveEventThumbnailAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete an event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="thumbnailId">The ID of the thumbnail.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteLiveEventThumbnailError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes a thumbnail image for the specified event.
    /// </remarks>
    public Task DeleteLiveEventThumbnail(double liveEventId,
        double thumbnailId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/pictures/{thumbnail_id}"),
            [new TemplateParam("live_event_id", liveEventId),
                new TemplateParam("thumbnail_id", thumbnailId),
                new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteLiveEventThumbnailErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete an event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="thumbnailId">The ID of the thumbnail.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteLiveEventThumbnailAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes a thumbnail image for the specified event.
    /// </remarks>
    public Task DeleteLiveEventThumbnailAlt1(double liveEventId,
        double thumbnailId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/pictures/{thumbnail_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("thumbnail_id", thumbnailId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteLiveEventThumbnailAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete an event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="thumbnailId">The ID of the thumbnail.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteLiveEventThumbnailAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes a thumbnail image for the specified event.
    /// </remarks>
    public Task DeleteLiveEventThumbnailAlt2(double liveEventId,
        double thumbnailId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/pictures/{thumbnail_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("thumbnail_id", thumbnailId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteLiveEventThumbnailAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit an event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="thumbnailId">The ID of the thumbnail.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditLiveEventThumbnailError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits a thumbnail image for the specified event.
    /// </remarks>
    public Task<Picture> EditLiveEventThumbnail(double liveEventId,
        double thumbnailId,
        double userId,
        UsersLiveEventsPicturesThumbnailIdRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/pictures/{thumbnail_id}"),
            [new TemplateParam("live_event_id", liveEventId),
                new TemplateParam("thumbnail_id", thumbnailId),
                new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            EditLiveEventThumbnailErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit an event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="thumbnailId">The ID of the thumbnail.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditLiveEventThumbnailAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits a thumbnail image for the specified event.
    /// </remarks>
    public Task<Picture> EditLiveEventThumbnailAlt1(double liveEventId,
        double thumbnailId,
        LiveEventsPicturesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/pictures/{thumbnail_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("thumbnail_id", thumbnailId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            EditLiveEventThumbnailAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit an event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="thumbnailId">The ID of the thumbnail.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditLiveEventThumbnailAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits a thumbnail image for the specified event.
    /// </remarks>
    public Task<Picture> EditLiveEventThumbnailAlt2(double liveEventId,
        double thumbnailId,
        MeLiveEventsPicturesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/pictures/{thumbnail_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("thumbnail_id", thumbnailId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            EditLiveEventThumbnailAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="thumbnailId">The ID of the thumbnail.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventThumbnailError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single thumbnail image of the specified event.
    /// </remarks>
    public Task<Picture> GetLiveEventThumbnail(double liveEventId,
        double thumbnailId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/pictures/{thumbnail_id}"),
            [new TemplateParam("live_event_id", liveEventId),
                new TemplateParam("thumbnail_id", thumbnailId),
                new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetLiveEventThumbnailErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="thumbnailId">The ID of the thumbnail.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventThumbnailAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single thumbnail image of the specified event.
    /// </remarks>
    public Task<Picture> GetLiveEventThumbnailAlt1(double liveEventId,
        double thumbnailId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/pictures/{thumbnail_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("thumbnail_id", thumbnailId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetLiveEventThumbnailAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific event thumbnail
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="thumbnailId">The ID of the thumbnail.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventThumbnailAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single thumbnail image of the specified event.
    /// </remarks>
    public Task<Picture> GetLiveEventThumbnailAlt2(double liveEventId,
        double thumbnailId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/pictures/{thumbnail_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("thumbnail_id", thumbnailId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetLiveEventThumbnailAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the thumbnails of an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PictureConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventThumbnailsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every thumbnail image of the specified event.
    /// </remarks>
    public Task<PictureConnection> GetLiveEventThumbnails(double liveEventId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/pictures"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PictureConnection>(),
            GetLiveEventThumbnailsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the thumbnails of an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PictureConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventThumbnailsAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every thumbnail image of the specified event.
    /// </remarks>
    public Task<PictureConnection> GetLiveEventThumbnailsAlt1(double liveEventId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/pictures"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PictureConnection>(),
            GetLiveEventThumbnailsAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the thumbnails of an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PictureConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventThumbnailsAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every thumbnail image of the specified event.
    /// </remarks>
    public Task<PictureConnection> GetLiveEventThumbnailsAlt2(double liveEventId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/pictures"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PictureConnection>(),
            GetLiveEventThumbnailsAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
