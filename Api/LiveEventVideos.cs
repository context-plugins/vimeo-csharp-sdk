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
using VimeoApi.Models.Enums;

namespace VimeoApi.Api;

/// <summary>
/// Use these methods to work with event videos.
/// </summary>
public sealed class LiveEventVideos
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveEventVideos(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a list of videos to an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideosToLiveEventError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds multiple videos to the specified event.
    /// </remarks>
    public Task AddVideosToLiveEvent(double liveEventId,
        double userId,
        UsersLiveEventsVideosRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/videos"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            AddVideosToLiveEventErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a list of videos to an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideosToLiveEventAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds multiple videos to the specified event.
    /// </remarks>
    public Task AddVideosToLiveEventAlt1(double liveEventId,
        LiveEventsVideosRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/videos"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            AddVideosToLiveEventAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a list of videos to an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideosToLiveEventAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds multiple videos to the specified event.
    /// </remarks>
    public Task AddVideosToLiveEventAlt2(double liveEventId,
        MeLiveEventsVideosRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/videos"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            AddVideosToLiveEventAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific video in an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventVideoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single video in the specified event.
    /// </remarks>
    public Task<Video> GetLiveEventVideo(double liveEventId,
        double userId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/videos/{video_id}"),
            [new TemplateParam("live_event_id", liveEventId),
                new TemplateParam("user_id", userId),
                new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            GetLiveEventVideoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific video in an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventVideoAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single video in the specified event.
    /// </remarks>
    public Task<Video> GetLiveEventVideoAlt1(double liveEventId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/videos/{video_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            GetLiveEventVideoAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific video in an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventVideoAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single video in the specified event.
    /// </remarks>
    public Task<Video> GetLiveEventVideoAlt2(double liveEventId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/videos/{video_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            GetLiveEventVideoAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="containingUri">The page that contains the video URI.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>embeddable</c> - Return embeddable events.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>added</c> - Sort the results by most recently added videos.  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>arranged</c> - Sort the results in the order that the user has arranged the videos.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by creation date.  * <c>duration</c> - Sort the results by duration.  * <c>likes</c> - Sort the results by number of likes.  * <c>plays</c> - Sort the results by number of plays.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventVideosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video in the specified event.
    /// </remarks>
    public Task<VideoConnection> GetLiveEventVideos(double liveEventId,
        double userId,
        string? containingUri,
        Direction? direction,
        Filter3? filter,
        bool? filterEmbeddable,
        double? page,
        double? perPage,
        string? query,
        Sort17? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/videos"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [new Param("containing_uri", containingUri),
                new Param("direction", direction),
                new Param("filter", filter),
                new Param("filter_embeddable", filterEmbeddable),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetLiveEventVideosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="containingUri">The page that contains the video URI.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>embeddable</c> - Return embeddable events.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>added</c> - Sort the results by most recently added videos.  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>arranged</c> - Sort the results in the order that the user has arranged the videos.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by creation date.  * <c>duration</c> - Sort the results by duration.  * <c>likes</c> - Sort the results by number of likes.  * <c>plays</c> - Sort the results by number of plays.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventVideosAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video in the specified event.
    /// </remarks>
    public Task<VideoConnection> GetLiveEventVideosAlt1(double liveEventId,
        string? containingUri,
        Direction? direction,
        Filter3? filter,
        bool? filterEmbeddable,
        double? page,
        double? perPage,
        string? query,
        Sort17? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/videos"),
            [new TemplateParam("live_event_id", liveEventId)],
            [new Param("containing_uri", containingUri),
                new Param("direction", direction),
                new Param("filter", filter),
                new Param("filter_embeddable", filterEmbeddable),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetLiveEventVideosAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="containingUri">The page that contains the video URI.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>embeddable</c> - Return embeddable events.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>added</c> - Sort the results by most recently added videos.  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>arranged</c> - Sort the results in the order that the user has arranged the videos.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by creation date.  * <c>duration</c> - Sort the results by duration.  * <c>likes</c> - Sort the results by number of likes.  * <c>plays</c> - Sort the results by number of plays.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventVideosAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video in the specified event.
    /// </remarks>
    public Task<VideoConnection> GetLiveEventVideosAlt2(double liveEventId,
        string? containingUri,
        Direction? direction,
        Filter3? filter,
        bool? filterEmbeddable,
        double? page,
        double? perPage,
        string? query,
        Sort17? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/videos"),
            [new TemplateParam("live_event_id", liveEventId)],
            [new Param("containing_uri", containingUri),
                new Param("direction", direction),
                new Param("filter", filter),
                new Param("filter_embeddable", filterEmbeddable),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetLiveEventVideosAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a list of videos from an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveVideosFromLiveEventError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes multiple videos from the specified event.
    /// </remarks>
    public Task RemoveVideosFromLiveEvent(double liveEventId,
        double userId,
        UsersLiveEventsVideosRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/videos"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RemoveVideosFromLiveEventErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a list of videos from an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveVideosFromLiveEventAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes multiple videos from the specified event.
    /// </remarks>
    public Task RemoveVideosFromLiveEventAlt1(double liveEventId,
        LiveEventsVideosRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/videos"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RemoveVideosFromLiveEventAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a list of videos from an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveVideosFromLiveEventAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes multiple videos from the specified event.
    /// </remarks>
    public Task RemoveVideosFromLiveEventAlt2(double liveEventId,
        MeLiveEventsVideosRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/videos"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RemoveVideosFromLiveEventAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
