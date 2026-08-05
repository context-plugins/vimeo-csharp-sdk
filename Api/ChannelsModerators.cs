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
/// Use these methods to work with channel moderators.
/// </summary>
public sealed class ChannelsModerators
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ChannelsModerators(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a specific moderator to a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddChannelModeratorError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a single user as a moderator to the specified channel. The authenticated user must be a follower of the requested user to add them as a channel moderator.
    /// </remarks>
    public Task AddChannelModerator(double channelId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/moderators/{user_id}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            AddChannelModeratorErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a list of moderators to a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddChannelModeratorsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds multiple users as moderators to the specified channel. Include the users by their URI as a JSON array in the body of the request using the <b>user_uri</b> field, like this: <c>[{ "user_uri": "/users/1234" }, { "user_uri": "/users/1235" }]</c>. The authenticated user must be a follower of a requested user to add this person as a moderator. For more information on batch requests like this one, see <see href="https://developer.vimeo.com/api/common-formats#working-with-batch-requests">Using Common Formats and Parameters</see>.
    /// </remarks>
    public Task AddChannelModerators(double channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/moderators"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            AddChannelModeratorsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific moderator of a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="User"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single moderator of the specified channel.
    /// </remarks>
    public Task<User> GetChannelModerator(double channelId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/moderators/{user_id}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<User>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the moderators of a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date added.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every moderator of the specified channel.
    /// </remarks>
    public Task<UserConnection> GetChannelModerators(double channelId,
        Direction? direction,
        double? page,
        double? perPage,
        string? query,
        Sort8? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/moderators"),
            [new TemplateParam("channel_id", channelId)],
            [new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UserConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a specific moderator from a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveChannelModeratorError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes a single moderator from the specified channel. The authenticated user must be the owner of the channel.
    /// </remarks>
    public Task RemoveChannelModerator(double channelId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/moderators/{user_id}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RemoveChannelModeratorErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a list of moderators from a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveChannelModeratorsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes multiple moderators from the specified channel. The authenticated user must be the owner of the channel.
    /// </remarks>
    public Task RemoveChannelModerators(double channelId,
        ChannelsModeratorsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/moderators"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RemoveChannelModeratorsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Replace the moderators of a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="User"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ReplaceChannelModeratorsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method replaces the current list of channel moderators with a new list. The authenticated user must be the owner of the channel and a follower of each requested user to add them as a channel moderator.
    /// </remarks>
    public Task<IReadOnlyList<User>> ReplaceChannelModerators(double channelId,
        ChannelsModeratorsRequest1 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/moderators"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<User>>(),
            ReplaceChannelModeratorsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
