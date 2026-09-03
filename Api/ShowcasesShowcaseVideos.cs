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
/// Use these methods to manage showcase videos.
/// </summary>
public sealed class ShowcasesShowcaseVideos
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ShowcasesShowcaseVideos(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a specific video to a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideoToShowcaseError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a single video to the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task AddVideoToShowcase(double albumId,
        double userId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/videos/{video_id}"),
            [new TemplateParam("album_id", albumId),
                new TemplateParam("user_id", userId),
                new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            AddVideoToShowcaseErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a specific video to a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideoToShowcaseAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a single video to the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task AddVideoToShowcaseAlt2(double albumId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums/{album_id}/videos/{video_id}"),
            [new TemplateParam("album_id", albumId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            AddVideoToShowcaseAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the user's videos that can be added to or removed from a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by date.  * <c>default</c> - Sort the results by the default method.  * <c>duration</c> - Sort the results by duration.  * <c>last_user_action_event_date</c> - Sort the results by most recent user interaction.  * <c>likes</c> - Sort the results by number of likes.  * <c>modified_time</c> - Sort the results by last modification.  * <c>plays</c> - Sort the results by number of plays.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAvailableShowcaseVideosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video belonging to the authenticated user that can be added to or removed from the specified showcase.
    /// </remarks>
    public Task<VideoConnection> GetAvailableShowcaseVideos(double albumId,
        Direction? direction,
        double? page,
        double? perPage,
        string? query,
        Sort2? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/albums/{album_id}/available_videos"),
            [new TemplateParam("album_id", albumId)],
            [new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetAvailableShowcaseVideosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the showcases to which the user can add or remove a specific video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by creation date.  * <c>duration</c> - Sort the results by duration.  * <c>videos</c> - Sort the results by number of videos.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlbumConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAvailableVideoShowcasesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every showcase to which the authenticated user can add or remove the specified video. The user must be the owner of the showcase.
    /// </remarks>
    public Task<AlbumConnection> GetAvailableVideoShowcases(double videoId,
        Direction? direction,
        double? page,
        double? perPage,
        string? query,
        Sort74? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/available_albums"),
            [new TemplateParam("video_id", videoId)],
            [new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AlbumConnection>(),
            GetAvailableVideoShowcasesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific video in a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="password">The password of the showcase.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcaseVideoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single video belonging to the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<Video> GetShowcaseVideo(double albumId,
        double userId,
        double videoId,
        string? password,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/videos/{video_id}"),
            [new TemplateParam("album_id", albumId),
                new TemplateParam("user_id", userId),
                new TemplateParam("video_id", videoId)],
            [new Param("password", password)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            GetShowcaseVideoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific video in a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="password">The password of the showcase.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcaseVideoAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single video belonging to the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<Video> GetShowcaseVideoAlt2(double albumId,
        double videoId,
        string? password,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums/{album_id}/videos/{video_id}"),
            [new TemplateParam("album_id", albumId), new TemplateParam("video_id", videoId)],
            [new Param("password", password)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            GetShowcaseVideoAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="containingUri">The page containing the video URI.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>embeddable</c> - Filter the results by the <b>embeddable</b> attribute.  * <c>playable</c> - Filter the results by the <b>playable</b> attribute.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="password">The password of the showcase.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by date.  * <c>default</c> - Sort the results by the default method.  * <c>duration</c> - Sort the results by duration.  * <c>likes</c> - Sort the results by number of likes.  * <c>manual</c> - Sort the results by their manual order.  * <c>modified_time</c> - Sort the results by last modification.  * <c>plays</c> - Sort the results by number of plays.</param>
    /// <param name="weakSearch">Whether to include private videos in the search. Please note that a separate search service provides this functionality. The service performs a partial text search on the video's name.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcaseVideosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video in the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<VideoConnection> GetShowcaseVideos(double albumId,
        double userId,
        string? containingUri,
        Direction? direction,
        Filter10? filter,
        bool? filterEmbeddable,
        double? page,
        string? password,
        double? perPage,
        string? query,
        Sort21? sort,
        bool? weakSearch,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/videos"),
            [new TemplateParam("album_id", albumId), new TemplateParam("user_id", userId)],
            [new Param("containing_uri", containingUri),
                new Param("direction", direction),
                new Param("filter", filter),
                new Param("filter_embeddable", filterEmbeddable),
                new Param("page", page),
                new Param("password", password),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort),
                new Param("weak_search", weakSearch)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetShowcaseVideosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="containingUri">The page containing the video URI.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>embeddable</c> - Filter the results by the <b>embeddable</b> attribute.  * <c>playable</c> - Filter the results by the <b>playable</b> attribute.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="password">The password of the showcase.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by date.  * <c>default</c> - Sort the results by the default method.  * <c>duration</c> - Sort the results by duration.  * <c>likes</c> - Sort the results by number of likes.  * <c>manual</c> - Sort the results by their manual order.  * <c>modified_time</c> - Sort the results by last modification.  * <c>plays</c> - Sort the results by number of plays.</param>
    /// <param name="weakSearch">Whether to include private videos in the search. Please note that a separate search service provides this functionality. The service performs a partial text search on the video's name.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcaseVideosAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video in the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<VideoConnection> GetShowcaseVideosAlt2(double albumId,
        string? containingUri,
        Direction? direction,
        Filter10? filter,
        bool? filterEmbeddable,
        double? page,
        string? password,
        double? perPage,
        string? query,
        Sort21? sort,
        bool? weakSearch,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums/{album_id}/videos"),
            [new TemplateParam("album_id", albumId)],
            [new Param("containing_uri", containingUri),
                new Param("direction", direction),
                new Param("filter", filter),
                new Param("filter_embeddable", filterEmbeddable),
                new Param("page", page),
                new Param("password", password),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort),
                new Param("weak_search", weakSearch)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetShowcaseVideosAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a video from a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveVideoFromShowcaseError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes the specified video from its showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task RemoveVideoFromShowcase(double albumId,
        double userId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/videos/{video_id}"),
            [new TemplateParam("album_id", albumId),
                new TemplateParam("user_id", userId),
                new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RemoveVideoFromShowcaseErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a video from a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveVideoFromShowcaseAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes the specified video from its showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task RemoveVideoFromShowcaseAlt2(double albumId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums/{album_id}/videos/{video_id}"),
            [new TemplateParam("album_id", albumId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RemoveVideoFromShowcaseAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Replace all the videos in a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ReplaceVideosInShowcaseError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method replaces all the videos in the specified showcase with a new set of one or more videos. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task ReplaceVideosInShowcase(double albumId,
        double userId,
        UsersAlbumsVideosRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/videos"),
            [new TemplateParam("album_id", albumId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            ReplaceVideosInShowcaseErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Replace all the videos in a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ReplaceVideosInShowcaseAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method replaces all the videos in the specified showcase with a new set of one or more videos. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task ReplaceVideosInShowcaseAlt2(double albumId,
        MeAlbumsVideosRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums/{album_id}/videos"),
            [new TemplateParam("album_id", albumId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            ReplaceVideosInShowcaseAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Set the featured video of a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetVideoAsShowcaseFeaturedError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method sets the featured video of the specified showcase. The authenticated user must be the owner of the showcase, and the featured video must belong to it.
    /// </remarks>
    public Task<Album> SetVideoAsShowcaseFeatured(double albumId,
        double userId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/videos/{video_id}/set_featured_video"),
            [new TemplateParam("album_id", albumId),
                new TemplateParam("user_id", userId),
                new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<Album>(),
            SetVideoAsShowcaseFeaturedErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Set the featured video of a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetVideoAsShowcaseFeaturedAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method sets the featured video of the specified showcase. The authenticated user must be the owner of the showcase, and the featured video must belong to it.
    /// </remarks>
    public Task<Album> SetVideoAsShowcaseFeaturedAlt2(double albumId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums/{album_id}/videos/{video_id}/set_featured_video"),
            [new TemplateParam("album_id", albumId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<Album>(),
            SetVideoAsShowcaseFeaturedAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a thumbnail for a showcase from a showcase video
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetVideoAsShowcaseThumbnailError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a thumbnail image for a showcase from the specified frame of a showcase video. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<Album> SetVideoAsShowcaseThumbnail(double albumId,
        double userId,
        double videoId,
        UsersAlbumsVideosVideoIdSetAlbumThumbnailRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/videos/{video_id}/set_album_thumbnail"),
            [new TemplateParam("album_id", albumId),
                new TemplateParam("user_id", userId),
                new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Album>(),
            SetVideoAsShowcaseThumbnailErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a thumbnail for a showcase from a showcase video
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetVideoAsShowcaseThumbnailAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a thumbnail image for a showcase from the specified frame of a showcase video. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<Album> SetVideoAsShowcaseThumbnailAlt2(double albumId,
        double videoId,
        MeAlbumsVideosSetAlbumThumbnailRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums/{album_id}/videos/{video_id}/set_album_thumbnail"),
            [new TemplateParam("album_id", albumId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Album>(),
            SetVideoAsShowcaseThumbnailAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
