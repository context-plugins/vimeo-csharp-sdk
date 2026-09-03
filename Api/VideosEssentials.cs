using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core;
using VimeoApi.Core.Authentication;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Exceptions;
using VimeoApi.Core.Models;
using VimeoApi.Core.Request;
using VimeoApi.Core.Response;
using VimeoApi.Errors;
using VimeoApi.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Api;

/// <summary>
/// These are the most common methods for working with videos.
/// </summary>
public sealed class VideosEssentials
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VideosEssentials(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Check if the user owns a video
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckIfUserOwnsVideoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether the authenticated user is the owner of the specified video.
    /// </remarks>
    public Task<Video> CheckIfUserOwnsVideo(double userId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/videos/{video_id}"),
            [new TemplateParam("user_id", userId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            CheckIfUserOwnsVideoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Check if the user owns a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckIfUserOwnsVideoAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether the authenticated user is the owner of the specified video.
    /// </remarks>
    public Task<Video> CheckIfUserOwnsVideoAlt1(double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/videos/{video_id}"),
            [new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            CheckIfUserOwnsVideoAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Copy a video
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CopyVideoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a copy of the specified video. Only the source's
    /// current version is copied; prior version history is not carried over.
    /// </remarks>
    public Task<Video> CopyVideo(double userId,
        double videoId,
        UsersVideosCopyRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/videos/{video_id}/copy"),
            [new TemplateParam("user_id", userId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Video>(),
            CopyVideoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Copy a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CopyVideoAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a copy of the specified video. Only the source's
    /// current version is copied; prior version history is not carried over.
    /// </remarks>
    public Task<Video> CopyVideoAlt2(double videoId,
        MeVideosCopyRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/videos/{video_id}/copy"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Video>(),
            CopyVideoAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVideoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task DeleteVideo(double videoId,
        VideosRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            DeleteVideoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a user's videos
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="uris">A comma-separated list of the video URIs to delete.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVideosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes one or more videos belonging to the specified user. The authenticated user must have permission to delete the videos.
    /// <para>
    /// Specify the videos to delete in a comma-separated list by URI using the <b>uris</b> query parameter.
    /// </para>
    /// </remarks>
    public Task DeleteVideos(double userId,
        string uris,
        UsersVideosRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/videos"),
            [new TemplateParam("user_id", userId)],
            [new Param("uris", uris)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            DeleteVideosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a user's videos
    /// </summary>
    /// <param name="uris">A comma-separated list of the video URIs to delete.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVideosAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes one or more videos belonging to the specified user. The authenticated user must have permission to delete the videos.
    /// <para>
    /// Specify the videos to delete in a comma-separated list by URI using the <b>uris</b> query parameter.
    /// </para>
    /// </remarks>
    public Task DeleteVideosAlt1(string uris,
        MeVideosRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/videos"),
            [],
            [new Param("uris", uris)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            DeleteVideosAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditVideoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the specified video.
    /// </remarks>
    public Task<Video> EditVideo(double videoId,
        VideosRequest1 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Video>(),
            EditVideoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in which the user appears
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>embeddable</c> - Return embeddable videos.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by date.  * <c>duration</c> - Sort the results by duration.  * <c>likes</c> - Sort the results by number of likes.  * <c>plays</c> - Sort the results by number of plays.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAppearancesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the videos in which the authenticated user has a credited appearance.
    /// </remarks>
    public Task<VideoConnection> GetAppearances(double userId,
        Direction? direction,
        Filter3? filter,
        bool? filterEmbeddable,
        double? page,
        double? perPage,
        string? query,
        Sort15? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/appearances"),
            [new TemplateParam("user_id", userId)],
            [new Param("direction", direction),
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
            GetAppearancesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in which the user appears
    /// </summary>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>embeddable</c> - Return embeddable videos.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by date.  * <c>duration</c> - Sort the results by duration.  * <c>likes</c> - Sort the results by number of likes.  * <c>plays</c> - Sort the results by number of plays.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAppearancesAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the videos in which the authenticated user has a credited appearance.
    /// </remarks>
    public Task<VideoConnection> GetAppearancesAlt1(Direction? direction,
        Filter3? filter,
        bool? filterEmbeddable,
        double? page,
        double? perPage,
        string? query,
        Sort15? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/appearances"),
            [],
            [new Param("direction", direction),
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
            GetAppearancesAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="timeLinks">Whether to return timestamps in the description as links.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVideoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single video.
    /// </remarks>
    public Task<Video> GetVideo(double videoId,
        bool? timeLinks,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}"),
            [new TemplateParam("video_id", videoId)],
            [new Param("time_links", timeLinks)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            GetVideoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos that the user has uploaded
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="containingUri">The page that contains the video URI. The field is available only when not paired with <b>query</b>.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>app_only</c> - Return app-only videos.  * <c>cold_privacy</c> - Return the owner's active videos whose privacy is suppressed because their plan no longer supports it (cold privacy).  * <c>cold_storage</c> - Return cold storage videos.  * <c>embeddable</c> - Return embeddable videos.  * <c>featured</c> - Return featured videos.  * <c>live</c> - Return only live videos.  * <c>no_placeholder</c> - Return no placeholder videos.  * <c>nolive</c> - Return no live videos.  * <c>playable</c> - Return playable videos.  * <c>screen_recorded</c> - Return screen-recorded videos.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="filterPlayable">Whether to filter the results by playable videos (<c>true</c>) or non-playable videos (<c>false</c>).</param>
    /// <param name="filterScreenRecorded">Whether to filter the results by screen-recorded videos (<c>true</c>) or non-screen-recorded videos (<c>false</c>).</param>
    /// <param name="filterTag">A comma-separated list of tags to filter on. All results must include at least one of these tags.</param>
    /// <param name="filterTagAllOf">A comma-separated list of tags to filter on. All results must include all of these tags.</param>
    /// <param name="filterTagExclude">A comma-separated list of tags to exclude. All results must exclude all of these tags.</param>
    /// <param name="filterUploader">The ID of the team member or team owner uploader to filter for.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="queryFields">A comma-separated list of fields to query over. The default value is <c>title,description,chapters,tags</c>.  Option descriptions:  * <c>chapters</c> - Query by chapter titles that have been added to the video.  * <c>description</c> - Query by the description of the video.  * <c>tags</c> - Query by tag names that have been added to the video.  * <c>title</c> - Query by the title of the video.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically by title.  * <c>date</c> - Sort the results by date.  * <c>default</c> - Use the default sorting method.  * <c>duration</c> - Sort the results by duration.  * <c>last_user_action_event_date</c> - Sort the results by last user interaction. If a result hasn't had an interaction, the upload date is used instead.  * <c>likes</c> - Sort the results by number of likes. To use this option, <b>direction</b> must be <c>desc</c>.  * <c>modified_time</c> - Sort the results by last modification.  * <c>plays</c> - Sort the results by number of plays. To use this option, <b>direction</b> must be <c>desc</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the videos that the authenticated user has uploaded.
    /// </remarks>
    public Task<VideoConnection> GetVideos(double userId,
        string? containingUri,
        Direction? direction,
        Filter22? filter,
        bool? filterEmbeddable,
        bool? filterPlayable,
        bool? filterScreenRecorded,
        string? filterTag,
        string? filterTagAllOf,
        string? filterTagExclude,
        double? filterUploader,
        double? page,
        double? perPage,
        string? query,
        QueryFields? queryFields,
        Sort39? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/videos"),
            [new TemplateParam("user_id", userId)],
            [new Param("containing_uri", containingUri),
                new Param("direction", direction),
                new Param("filter", filter),
                new Param("filter_embeddable", filterEmbeddable),
                new Param("filter_playable", filterPlayable),
                new Param("filter_screen_recorded", filterScreenRecorded),
                new Param("filter_tag", filterTag),
                new Param("filter_tag_all_of", filterTagAllOf),
                new Param("filter_tag_exclude", filterTagExclude),
                new Param("filter_uploader", filterUploader),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("query_fields", queryFields),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos that the user has uploaded
    /// </summary>
    /// <param name="containingUri">The page that contains the video URI. The field is available only when not paired with <b>query</b>.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>app_only</c> - Return app-only videos.  * <c>cold_privacy</c> - Return the owner's active videos whose privacy is suppressed because their plan no longer supports it (cold privacy).  * <c>cold_storage</c> - Return cold storage videos.  * <c>embeddable</c> - Return embeddable videos.  * <c>featured</c> - Return featured videos.  * <c>live</c> - Return only live videos.  * <c>no_placeholder</c> - Return no placeholder videos.  * <c>nolive</c> - Return no live videos.  * <c>playable</c> - Return playable videos.  * <c>screen_recorded</c> - Return screen-recorded videos.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="filterPlayable">Whether to filter the results by playable videos (<c>true</c>) or non-playable videos (<c>false</c>).</param>
    /// <param name="filterScreenRecorded">Whether to filter the results by screen-recorded videos (<c>true</c>) or non-screen-recorded videos (<c>false</c>).</param>
    /// <param name="filterTag">A comma-separated list of tags to filter on. All results must include at least one of these tags.</param>
    /// <param name="filterTagAllOf">A comma-separated list of tags to filter on. All results must include all of these tags.</param>
    /// <param name="filterTagExclude">A comma-separated list of tags to exclude. All results must exclude all of these tags.</param>
    /// <param name="filterUploader">The ID of the team member or team owner uploader to filter for.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="queryFields">A comma-separated list of fields to query over. The default value is <c>title,description,chapters,tags</c>.  Option descriptions:  * <c>chapters</c> - Query by chapter titles that have been added to the video.  * <c>description</c> - Query by the description of the video.  * <c>tags</c> - Query by tag names that have been added to the video.  * <c>title</c> - Query by the title of the video.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically by title.  * <c>date</c> - Sort the results by date.  * <c>default</c> - Use the default sorting method.  * <c>duration</c> - Sort the results by duration.  * <c>last_user_action_event_date</c> - Sort the results by last user interaction. If a result hasn't had an interaction, the upload date is used instead.  * <c>likes</c> - Sort the results by number of likes. To use this option, <b>direction</b> must be <c>desc</c>.  * <c>modified_time</c> - Sort the results by last modification.  * <c>plays</c> - Sort the results by number of plays. To use this option, <b>direction</b> must be <c>desc</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the videos that the authenticated user has uploaded.
    /// </remarks>
    public Task<VideoConnection> GetVideosAlt1(string? containingUri,
        Direction? direction,
        Filter22? filter,
        bool? filterEmbeddable,
        bool? filterPlayable,
        bool? filterScreenRecorded,
        string? filterTag,
        string? filterTagAllOf,
        string? filterTagExclude,
        double? filterUploader,
        double? page,
        double? perPage,
        string? query,
        QueryFields? queryFields,
        Sort39? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/videos"),
            [],
            [new Param("containing_uri", containingUri),
                new Param("direction", direction),
                new Param("filter", filter),
                new Param("filter_embeddable", filterEmbeddable),
                new Param("filter_playable", filterPlayable),
                new Param("filter_screen_recorded", filterScreenRecorded),
                new Param("filter_tag", filterTag),
                new Param("filter_tag_all_of", filterTagAllOf),
                new Param("filter_tag_exclude", filterTagExclude),
                new Param("filter_uploader", filterUploader),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("query_fields", queryFields),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Search for videos
    /// </summary>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results. <c>CC</c> and related filters target videos with the corresponding Creative Commons licenses. For more information, see our <see href="https://vimeo.com/creativecommons">Creative Commons</see> page.  Option descriptions:  * <c>CC</c> - Return videos under any Creative Commons license.  * <c>CC-BY</c> - Return CC BY, or attribution-only, videos.  * <c>CC-BY-NC</c> - Return CC BY-NC, or Attribution-NonCommercial, videos.  * <c>CC-BY-NC-ND</c> - Return CC BY-NC-ND, or Attribution-NonCommercial-NoDerivs, videos.  * <c>CC-BY-NC-SA</c> - Return CC BY-NC-SA, or Attribution-NonCommercial-ShareAlike, videos.  * <c>CC-BY-ND</c> - Return CC BY-ND, or Attribution-NoDerivs, videos.  * <c>CC-BY-SA</c> - Return CC BY-SA, or Attribution-ShareAlike, videos.  * <c>CC0</c> - Return CC0, or public domain, videos.  * <c>categories</c> - Filter by categories.  * <c>duration</c> - Filter by duration.  * <c>in-progress</c> - Return in-progress videos.  * <c>minimum_likes</c> - Filter by minimum likes.  * <c>trending</c> - Return trending videos.  * <c>upload_date</c> - Filter by upload date.</param>
    /// <param name="links">A comma-separated list of video URLs to find. Querying, filtering, and sorting aren't supported when using this field.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by date.  * <c>duration</c> - Sort the results by duration.  * <c>likes</c> - Sort the results by number of likes.  * <c>plays</c> - Sort the results by number of plays.  * <c>relevant</c> - Sort the results by relevance.</param>
    /// <param name="uris">A comma-separated list of video URIs to find. Querying, filtering, and sorting aren't supported when using this field.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SearchVideosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the videos that match custom search criteria.
    /// </remarks>
    public Task<VideoConnection> SearchVideos(Direction? direction,
        Filter45? filter,
        string? links,
        double? page,
        double? perPage,
        string? query,
        Sort73? sort,
        string? uris,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos"),
            [],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("links", links),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort),
                new Param("uris", uris)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            SearchVideosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Set custom metadata values for a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CustomMetadataValues"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateVideoCustomMetadataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method sets, updates, or clears custom metadata values on a single video.
    /// <para>
    /// The authenticated user must own the video or have team permission to edit it.
    /// </para>
    /// <para>
    /// Send each value as a <c>{field_id, field_value}</c> pair under the <c>fields</c> array.
    /// The value's data type is validated against the field's definition (set via
    /// <c>POST /teams/{user_id}/custom_metadata</c>):
    /// </para>
    /// <para>
    /// | Type           | Accepted format                                         |
    /// | -------------- | ------------------------------------------------------- |
    /// | <c>str</c>          | A non-empty string of up to 50 characters               |
    /// | <c>int</c>          | An integer, optionally negative (for example, <c>42</c>)     |
    /// | <c>date</c>         | <c>YYYY-MM-DD</c>                                            |
    /// | <c>bool</c>         | <c>"true"</c>, <c>"false"</c>, <c>"1"</c>, or <c>"0"</c>                    |
    /// | <c>select</c>       | One of the values defined for the field                 |
    /// | <c>multi-select</c> | A JSON-encoded array of allowed values                  |
    /// </para>
    /// <para>
    /// To clear an existing value, send <c>field_value: null</c>. The field will return to
    /// its default value (if one is defined) or become unset.
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<CustomMetadataValues>> UpdateVideoCustomMetadata(double videoId,
        VideosCustomMetadataRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/custom_metadata"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<CustomMetadataValues>>(),
            UpdateVideoCustomMetadataErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
