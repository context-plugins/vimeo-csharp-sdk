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
/// Use these methods to work with videos in channels.
/// </summary>
public sealed class ChannelsVideos
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ChannelsVideos(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a specific video to a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideoToChannelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a single video to the specified channel. The authenticated user must be a moderator of the channel.
    /// </remarks>
    public Task AddVideoToChannel(double channelId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/videos/{video_id}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            AddVideoToChannelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a list of videos to a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideosToChannelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds multiple videos to the specified channel. The authenticated user must be a moderator of the channel.
    /// </remarks>
    public Task AddVideosToChannel(double channelId,
        ChannelsVideosRequest1 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/videos"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            AddVideosToChannelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a specific video from a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVideoFromChannelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes a single video from the specified channel. The authenticated user must be a moderator of the channel.
    /// </remarks>
    public Task DeleteVideoFromChannel(double channelId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/videos/{video_id}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteVideoFromChannelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the channels to which the user can add or remove a specific video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChannelConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAvailableVideoChannelsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every channel to which the authenticated user can add or remove the specified video. The authenticated user must be a moderator of the channel.
    /// </remarks>
    public Task<ChannelConnection> GetAvailableVideoChannels(double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/available_channels"),
            [new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChannelConnection>(),
            GetAvailableVideoChannelsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific video in a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetChannelVideoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single video in the specified channel. You can use it to determine whether the video is in the channel.
    /// </remarks>
    public Task<Video> GetChannelVideo(double channelId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/videos/{video_id}"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            GetChannelVideoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="containingUri">The page that contains the video URI.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>embeddable</c> - Return embeddable videos.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sizes">The pixel dimensions of the image in <c>{width}x{height}</c> format. For more information, see our <see href="https://developer.vimeo.com/api/common-formats#using-the-sizes-parameter">Using Common Formats and Parameters</see> guide.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>added</c> - Sort the results by date added.  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by creation date.  * <c>default</c> - Use the default sorting method.  * <c>duration</c> - Sort the results by duration.  * <c>likes</c> - Sort the results by number of likes.  * <c>manual</c> - Sort the results as the user has arranged them.  * <c>modified_time</c> - Sort the results by last modification.  * <c>plays</c> - Sort the results by number of plays.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetChannelVideosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video in the specified channel.
    /// </remarks>
    public Task<VideoConnection> GetChannelVideos(double channelId,
        string? containingUri,
        Direction? direction,
        Filter3? filter,
        bool? filterEmbeddable,
        double? page,
        double? perPage,
        string? query,
        string? sizes,
        Sort10? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/videos"),
            [new TemplateParam("channel_id", channelId)],
            [new Param("containing_uri", containingUri),
                new Param("direction", direction),
                new Param("filter", filter),
                new Param("filter_embeddable", filterEmbeddable),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sizes", sizes),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetChannelVideosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a list of videos from a channel
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RemoveVideosFromChannelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes multiple videos from the specified channel. Include the videos by their URI as a JSON block in the body of the request using the <b>video_uri</b> field, like this: <c>[{ "video_uri": "/videos/1234" }, { "video_uri": "/videos/1235" }]</c>. The authenticated user must be a moderator of the channel. For more information on batch requests like this one, see <see href="https://developer.vimeo.com/api/common-formats#working-with-batch-requests">Using Common Formats and Parameters</see>.
    /// </remarks>
    public Task RemoveVideosFromChannel(double channelId,
        ChannelsVideosRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/videos"),
            [new TemplateParam("channel_id", channelId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RemoveVideosFromChannelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
