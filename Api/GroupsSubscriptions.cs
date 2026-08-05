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

namespace VimeoApi.Api;

/// <summary>
/// Use these methods to manage group membership.
/// </summary>
public sealed class GroupsSubscriptions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GroupsSubscriptions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add the user to a group
    /// </summary>
    /// <param name="groupId">The ID of the group.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="JoinGroupError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds the authenticated user to the specified group.
    /// </remarks>
    public Task JoinGroup(double groupId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/groups/{group_id}"),
            [new TemplateParam("group_id", groupId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            JoinGroupErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add the user to a group
    /// </summary>
    /// <param name="groupId">The ID of the group.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="JoinGroupAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds the authenticated user to the specified group.
    /// </remarks>
    public Task JoinGroupAlt1(double groupId, RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/groups/{group_id}"),
            [new TemplateParam("group_id", groupId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            JoinGroupAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove the user from a group
    /// </summary>
    /// <param name="groupId">The ID of the group.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="LeaveGroupError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes the authenticated user from the specified group. The authenticated user can't be the owner of the group; assign a new owner through a PATCH request first.
    /// </remarks>
    public Task LeaveGroup(double groupId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/groups/{group_id}"),
            [new TemplateParam("group_id", groupId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            LeaveGroupErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove the user from a group
    /// </summary>
    /// <param name="groupId">The ID of the group.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="LeaveGroupAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes the authenticated user from the specified group. The authenticated user can't be the owner of the group; assign a new owner through a PATCH request first.
    /// </remarks>
    public Task LeaveGroupAlt1(double groupId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/groups/{group_id}"),
            [new TemplateParam("group_id", groupId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            LeaveGroupAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
