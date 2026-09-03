using System;
using System.Collections.Generic;
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
/// Use these methods to work with tags in channels.
/// </summary>
public sealed class ChannelsTags
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ChannelsTags(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a specific tag to a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="word">The word to use as the tag.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddChannelTagError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a single tag to the specified channel. The authenticated user must be the owner of the channel.
    /// </remarks>
    public Task AddChannelTag(double channelId,
        string word,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/tags/{word}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("word", word)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            AddChannelTagErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a list of tags to a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Tag"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddTagsToChannelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds multiple tags to the specified channel. Include the tags as a JSON array in the body of the request using the <b>tag</b> field, like this: <c>[{ "tag": "funny" }, { "tag": "concert" }]</c>. The authenticated user must be the owner of the channel. For more information on batch requests like this one, see <see href="https://developer.vimeo.com/api/common-formats#working-with-batch-requests">Using Common Formats and Parameters</see>.
    /// </remarks>
    public Task<IReadOnlyList<Tag>> AddTagsToChannel(double channelId,
        IReadOnlyList<ChannelsTagsRequest> body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/tags"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<Tag>>(),
            AddTagsToChannelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Check if a tag has been added to a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="word">The word to use as the tag.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckIfChannelHasTagError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether a tag has been added to the specified channel.
    /// </remarks>
    public Task CheckIfChannelHasTag(double channelId,
        string word,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/tags/{word}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("word", word)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            CheckIfChannelHasTagErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a tag from a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="word">The word to use as the tag.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteTagFromChannelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes a single tag from the specified channel. The authenticated user must be the owner of the channel.
    /// </remarks>
    public Task DeleteTagFromChannel(double channelId,
        string word,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/tags/{word}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("word", word)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteTagFromChannelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the tags that have been added to a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TagConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetChannelTagsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every tag that has been added to the specified channel.
    /// </remarks>
    public Task<TagConnection> GetChannelTags(double channelId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/tags"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TagConnection>(),
            GetChannelTagsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
