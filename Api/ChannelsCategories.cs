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

namespace VimeoApi.Api;

/// <summary>
/// Use these methods to work with channel categories.
/// </summary>
public sealed class ChannelsCategories
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ChannelsCategories(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a channel to a list of categories
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddChannelCategoriesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds the specified channel to multiple categories.
    /// </remarks>
    public Task AddChannelCategories(double channelId,
        ChannelsCategoriesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/categories"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            AddChannelCategoriesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a channel to a specific category
    /// </summary>
    /// <param name="category">The name of the category.</param>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CategorizeChannelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds the specified channel to a single category. The authenticated user must be the owner of the channel.
    /// </remarks>
    public Task CategorizeChannel(string category,
        double channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/categories/{category}"),
            [new TemplateParam("category", category), new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            CategorizeChannelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a channel from a category
    /// </summary>
    /// <param name="category">The name of the category.</param>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteChannelCategoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes a channel from the specified category. The authenticated user must be the owner of the channel.
    /// </remarks>
    public Task DeleteChannelCategory(string category,
        double channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/categories/{category}"),
            [new TemplateParam("category", category), new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteChannelCategoryErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the categories to which a channel belongs
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CategoryConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetChannelCategoriesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every category to which the specified channel belongs.
    /// </remarks>
    public Task<CategoryConnection> GetChannelCategories(double channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/categories"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CategoryConnection>(),
            GetChannelCategoriesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
