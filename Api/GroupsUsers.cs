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
/// Use these methods to manage group members.
/// </summary>
public sealed class GroupsUsers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GroupsUsers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Check if a user has joined a group
    /// </summary>
    /// <param name="groupId">The ID of the group.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckIfUserJoinedGroupError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether the authenticated user belongs to the specified group.
    /// </remarks>
    public Task CheckIfUserJoinedGroup(double groupId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/groups/{group_id}"),
            [new TemplateParam("group_id", groupId), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            CheckIfUserJoinedGroupErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Check if a user has joined a group
    /// </summary>
    /// <param name="groupId">The ID of the group.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckIfUserJoinedGroupAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether the authenticated user belongs to the specified group.
    /// </remarks>
    public Task CheckIfUserJoinedGroupAlt1(double groupId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/groups/{group_id}"),
            [new TemplateParam("group_id", groupId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            CheckIfUserJoinedGroupAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the members of a group
    /// </summary>
    /// <param name="groupId">The ID of the group.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>moderators</c> - Return group moderators.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by creation date.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGroupMembersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every user who belongs to the specified group.
    /// </remarks>
    public Task<UserConnection> GetGroupMembers(double groupId,
        Direction? direction,
        Filter2? filter,
        double? page,
        double? perPage,
        string? query,
        Sort8? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/groups/{group_id}/users"),
            [new TemplateParam("group_id", groupId)],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UserConnection>(),
            GetGroupMembersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the groups that the user has joined
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>moderated</c> - Return moderated groups.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by creation date.  * <c>members</c> - Sort the results by number of members.  * <c>videos</c> - Sort the results by number of videos.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GroupConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetUserGroupsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every group to which the authenticated user belongs.
    /// </remarks>
    public Task<GroupConnection> GetUserGroups(double userId,
        Direction? direction,
        Filter12? filter,
        double? page,
        double? perPage,
        string? query,
        Sort5? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/groups"),
            [new TemplateParam("user_id", userId)],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GroupConnection>(),
            GetUserGroupsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the groups that the user has joined
    /// </summary>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>moderated</c> - Return moderated groups.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by creation date.  * <c>members</c> - Sort the results by number of members.  * <c>videos</c> - Sort the results by number of videos.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GroupConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetUserGroupsAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every group to which the authenticated user belongs.
    /// </remarks>
    public Task<GroupConnection> GetUserGroupsAlt1(Direction? direction,
        Filter12? filter,
        double? page,
        double? perPage,
        string? query,
        Sort5? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/groups"),
            [],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GroupConnection>(),
            GetUserGroupsAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
