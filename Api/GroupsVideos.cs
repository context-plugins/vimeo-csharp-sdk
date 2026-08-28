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
using Vimeo.Models.Enums;

namespace Vimeo.Api;

/// <summary>
/// Use these methods to manage group videos.
/// </summary>
public sealed class GroupsVideos
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GroupsVideos(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a video to a group
    /// </summary>
    /// <param name="groupId">The ID of the group.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideoToGroupError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a video to the specified group. The authenticated user must be the owner of the group.
    /// </remarks>
    public Task<Video> AddVideoToGroup(double groupId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/groups/{group_id}/videos/{video_id}"),
            [new TemplateParam("group_id", groupId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            AddVideoToGroupErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a video from a group
    /// </summary>
    /// <param name="groupId">The ID of the group.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVideoFromGroupError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes a video from the specified group. The authenticated user must be the owner of the group.
    /// </remarks>
    public Task DeleteVideoFromGroup(double groupId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/groups/{group_id}/videos/{video_id}"),
            [new TemplateParam("group_id", groupId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteVideoFromGroupErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the groups to which the user can add or remove a specific video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GroupConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAvailableVideoGroupsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every group to which the authenticated user can add or remove the specified video.
    /// </remarks>
    public Task<GroupConnection> GetAvailableVideoGroups(double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/available_groups"),
            [new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GroupConnection>(),
            GetAvailableVideoGroupsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific video in a group
    /// </summary>
    /// <param name="groupId">The ID of the group.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGroupVideoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single video from the specified group. You can use this method to determine whether the video belongs to the group.
    /// </remarks>
    public Task<Video> GetGroupVideo(double groupId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/groups/{group_id}/videos/{video_id}"),
            [new TemplateParam("group_id", groupId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            GetGroupVideoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in a group
    /// </summary>
    /// <param name="groupId">The ID of the group.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>embeddable</c> - Return embeddable videos.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by creation date.  * <c>duration</c> - Sort the results by duration.  * <c>likes</c> - Sort the results by number of likes.  * <c>plays</c> - Sort the results by number of plays.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGroupVideosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video from the specified group.
    /// </remarks>
    public Task<VideoConnection> GetGroupVideos(double groupId,
        Direction? direction,
        Filter3? filter,
        bool? filterEmbeddable,
        double? page,
        double? perPage,
        string? query,
        Sort15? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/groups/{group_id}/videos"),
            [new TemplateParam("group_id", groupId)],
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
            GetGroupVideosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
