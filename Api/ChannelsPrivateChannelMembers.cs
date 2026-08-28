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
using Vimeo.Models.Enums;

namespace Vimeo.Api;

/// <summary>
/// Use these methods to work with private channel members.
/// </summary>
public sealed class ChannelsPrivateChannelMembers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ChannelsPrivateChannelMembers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Restrict a user from accessing a private channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteChannelPrivacyUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method prevents a single user from being able to access the specified private channel. The authenticated user must be the owner of the channel.
    /// </remarks>
    public Task DeleteChannelPrivacyUser(double channelId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/privacy/users/{user_id}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteChannelPrivacyUserErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the users who can access a private channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetChannelPrivacyUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the users who have access to the specified private channel. The authenticated user must be the owner of the channel.
    /// </remarks>
    public Task<UserConnection> GetChannelPrivacyUsers(double channelId,
        Direction? direction,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/privacy/users"),
            [new TemplateParam("channel_id", channelId)],
            [new Param("direction", direction), new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UserConnection>(),
            GetChannelPrivacyUsersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Permit a specific user to access a private channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetChannelPrivacyUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method gives a single user access to the specified private channel. The authenticated user must be the owner of the channel.
    /// </remarks>
    public Task SetChannelPrivacyUser(double channelId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/privacy/users/{user_id}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            SetChannelPrivacyUserErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Permit a list of users to access a private channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="User"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetChannelPrivacyUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method gives multiple users access to the specified private channel. The authenticated user must be the owner of the channel.
    /// </remarks>
    public Task<IReadOnlyList<User>> SetChannelPrivacyUsers(double channelId,
        ChannelsPrivacyUsersRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/privacy/users"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<User>>(),
            SetChannelPrivacyUsersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
