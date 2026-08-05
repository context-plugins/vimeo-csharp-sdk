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
/// Use these methods to manage videos in folders.
/// </summary>
public sealed class FoldersVideos
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FoldersVideos(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a video to a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideoToProjectError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a single video to the specified folder. The authenticated user must be the owner of the folder.
    /// </remarks>
    public Task AddVideoToProject(double projectId,
        double userId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects/{project_id}/videos/{video_id}"),
            [new TemplateParam("project_id", projectId),
                new TemplateParam("user_id", userId),
                new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            AddVideoToProjectErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a video to a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideoToProjectAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a single video to the specified folder. The authenticated user must be the owner of the folder.
    /// </remarks>
    public Task AddVideoToProjectAlt1(double projectId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects/{project_id}/videos/{video_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            AddVideoToProjectAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a list of videos to a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideosToProjectError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds multiple videos to the specified folder. The authenticated user must be the owner of the folder.
    /// </remarks>
    public Task AddVideosToProject(double projectId,
        double userId,
        UsersProjectsVideosRequest1 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects/{project_id}/videos"),
            [new TemplateParam("project_id", projectId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            AddVideosToProjectErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a list of videos to a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideosToProjectAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds multiple videos to the specified folder. The authenticated user must be the owner of the folder.
    /// </remarks>
    public Task AddVideosToProjectAlt1(double projectId,
        MeProjectsVideosRequest1 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects/{project_id}/videos"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            AddVideosToProjectAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filterTag">A comma-separated list of tags to filter on. All results must include at least one of these tags. The use of this parameter triggers a search.</param>
    /// <param name="filterTagAllOf">A comma-separated list of tags to filter on. All results must include all of these tags. The use of this parameter triggers a search.</param>
    /// <param name="filterTagExclude">A comma-separated list of tags to exclude. The use of this parameter triggers a search.</param>
    /// <param name="includeSubfolders">Whether to include subfolders.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="queryFields">A comma-separated list of fields to query over. The default value is <c>title,description,chapters,tags</c>.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>default</c> - Use the default sort order.  * <c>duration</c> - Sort the results by duration.  * <c>last_user_action_event_date</c> - Sort the results by the date of the last user action.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetProjectVideosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the videos that belong to the specified folder.
    /// </remarks>
    public Task<VideoConnection> GetProjectVideos(double projectId,
        double userId,
        Direction? direction,
        string? filterTag,
        string? filterTagAllOf,
        string? filterTagExclude,
        bool? includeSubfolders,
        double? page,
        double? perPage,
        string? query,
        string? queryFields,
        Sort37? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects/{project_id}/videos"),
            [new TemplateParam("project_id", projectId), new TemplateParam("user_id", userId)],
            [new Param("direction", direction),
                new Param("filter_tag", filterTag),
                new Param("filter_tag_all_of", filterTagAllOf),
                new Param("filter_tag_exclude", filterTagExclude),
                new Param("include_subfolders", includeSubfolders),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("query_fields", queryFields),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetProjectVideosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filterTag">A comma-separated list of tags to filter on. All results must include at least one of these tags. The use of this parameter triggers a search.</param>
    /// <param name="filterTagAllOf">A comma-separated list of tags to filter on. All results must include all of these tags. The use of this parameter triggers a search.</param>
    /// <param name="filterTagExclude">A comma-separated list of tags to exclude. The use of this parameter triggers a search.</param>
    /// <param name="includeSubfolders">Whether to include subfolders.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="queryFields">A comma-separated list of fields to query over. The default value is <c>title,description,chapters,tags</c>.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>default</c> - Use the default sort order.  * <c>duration</c> - Sort the results by duration.  * <c>last_user_action_event_date</c> - Sort the results by the date of the last user action.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetProjectVideosAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the videos that belong to the specified folder.
    /// </remarks>
    public Task<VideoConnection> GetProjectVideosAlt1(double projectId,
        Direction? direction,
        string? filterTag,
        string? filterTagAllOf,
        string? filterTagExclude,
        bool? includeSubfolders,
        double? page,
        double? perPage,
        string? query,
        string? queryFields,
        Sort37? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects/{project_id}/videos"),
            [new TemplateParam("project_id", projectId)],
            [new Param("direction", direction),
                new Param("filter_tag", filterTag),
                new Param("filter_tag_all_of", filterTagAllOf),
                new Param("filter_tag_exclude", filterTagExclude),
                new Param("include_subfolders", includeSubfolders),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("query_fields", queryFields),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetProjectVideosAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a video from a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveVideoFromProjectError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes a single video from the specified folder. Please note that this doesn't delete the video itself.
    /// </remarks>
    public Task RemoveVideoFromProject(double projectId,
        double userId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects/{project_id}/videos/{video_id}"),
            [new TemplateParam("project_id", projectId),
                new TemplateParam("user_id", userId),
                new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RemoveVideoFromProjectErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a video from a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveVideoFromProjectAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes a single video from the specified folder. Please note that this doesn't delete the video itself.
    /// </remarks>
    public Task RemoveVideoFromProjectAlt1(double projectId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects/{project_id}/videos/{video_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RemoveVideoFromProjectAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a list of videos from a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveVideosFromProjectError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes multiple videos from the specified folder. The authenticated user must be the owner of the folder.
    /// </remarks>
    public Task RemoveVideosFromProject(double projectId,
        double userId,
        UsersProjectsVideosRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects/{project_id}/videos"),
            [new TemplateParam("project_id", projectId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RemoveVideosFromProjectErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a list of videos from a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveVideosFromProjectAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes multiple videos from the specified folder. The authenticated user must be the owner of the folder.
    /// </remarks>
    public Task RemoveVideosFromProjectAlt1(double projectId,
        MeProjectsVideosRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects/{project_id}/videos"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RemoveVideosFromProjectAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
