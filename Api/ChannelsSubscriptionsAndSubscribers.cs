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
/// Use these methods to work with channel subscriptions.
/// </summary>
public sealed class ChannelsSubscriptionsAndSubscribers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ChannelsSubscriptionsAndSubscribers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Check if a user follows a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckIfUserSubscribedToChannelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether the specified user is a follower of a particular channel.
    /// </remarks>
    public Task CheckIfUserSubscribedToChannel(double channelId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/channels/{channel_id}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            CheckIfUserSubscribedToChannelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Check if a user follows a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckIfUserSubscribedToChannelAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether the specified user is a follower of a particular channel.
    /// </remarks>
    public Task CheckIfUserSubscribedToChannelAlt1(double channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/channels/{channel_id}"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            CheckIfUserSubscribedToChannelAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the followers of a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>moderators</c> - Return moderators.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by follow date.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetChannelSubscribersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every follower of the specified channel.
    /// </remarks>
    public Task<UserConnection> GetChannelSubscribers(double channelId,
        Filter2 filter,
        Direction? direction,
        double? page,
        double? perPage,
        string? query,
        Sort8? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/users"),
            [new TemplateParam("channel_id", channelId)],
            [new Param("filter", filter),
                new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UserConnection>(),
            GetChannelSubscribersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Subscribe the user to a specific channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubscribeToChannelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method subscribes the authenticated user to the specified channel.
    /// </remarks>
    public Task SubscribeToChannel(double channelId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/channels/{channel_id}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            SubscribeToChannelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Subscribe the user to a specific channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubscribeToChannelAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method subscribes the authenticated user to the specified channel.
    /// </remarks>
    public Task SubscribeToChannelAlt1(double channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/channels/{channel_id}"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            SubscribeToChannelAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Unsubscribe the user from a specific channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UnsubscribeFromChannelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method unsubscribes the authenticated user from the specified channel.
    /// </remarks>
    public Task UnsubscribeFromChannel(double channelId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/channels/{channel_id}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            UnsubscribeFromChannelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Unsubscribe the user from a specific channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UnsubscribeFromChannelAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method unsubscribes the authenticated user from the specified channel.
    /// </remarks>
    public Task UnsubscribeFromChannelAlt1(double channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/channels/{channel_id}"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            UnsubscribeFromChannelAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
