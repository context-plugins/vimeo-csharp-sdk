using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core;
using Vimeo.Core.Authentication;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Exceptions;
using Vimeo.Core.Models;
using Vimeo.Core.Request;
using Vimeo.Core.Response;
using Vimeo.Errors;
using Vimeo.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Api;

/// <summary>
/// Use these methods to work with associated tags.
/// </summary>
public sealed class VideosTags
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VideosTags(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a specific tag to a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="word">The tag word.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Tag"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideoTagError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a single tag to the specified video. The authenticated user must have edit access to the video.
    /// </remarks>
    public Task<Tag> AddVideoTag(double videoId,
        string word,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/tags/{word}"),
            [new TemplateParam("video_id", videoId), new TemplateParam("word", word)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<Tag>(),
            AddVideoTagErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a list of tags to a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Tag"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideoTagsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds multiple tags to the specified video. Include the tags as a JSON array  as the body of the request with the  <b>name</b> field, like this: <c>[{ "name": "funny"}, {"name": "concert" }]</c>. The authenticated user must have edit access to the video. For more information on batch requests like this one, see <see href="https://developer.vimeo.com/api/common-formats#working-with-batch-requests">Using Common Formats and Parameters</see>.
    /// </remarks>
    public Task<IReadOnlyList<Tag>> AddVideoTags(double videoId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/tags"),
            [new TemplateParam("video_id", videoId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Tag>>(),
            AddVideoTagsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Check if a tag has been added to a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="word">The tag word.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Tag"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckVideoForTagError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether the specified tag has been added to a video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<Tag> CheckVideoForTag(double videoId,
        string word,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/tags/{word}"),
            [new TemplateParam("video_id", videoId), new TemplateParam("word", word)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Tag>(),
            CheckVideoForTagErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a tag from a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="word">The tag word.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVideoTagError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes the specified tag from a video. The authenticated user must have edit access to the video.
    /// </remarks>
    public Task DeleteVideoTag(double videoId,
        string word,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/tags/{word}"),
            [new TemplateParam("video_id", videoId), new TemplateParam("word", word)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteVideoTagErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the tags of a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TagConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the tags associated with the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<TagConnection> GetVideoTags(double videoId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/tags"),
            [new TemplateParam("video_id", videoId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TagConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos with a specific tag
    /// </summary>
    /// <param name="word">The tag word.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>created_time</c> - Sort the results by creation time.  * <c>duration</c> - Sort the results by duration.  * <c>name</c> - Sort the results by name.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVideosWithTagError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the public videos associated with the specified tag.
    /// </remarks>
    public Task<VideoConnection> GetVideosWithTag(string word,
        Direction? direction,
        double? page,
        double? perPage,
        Sort47? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tags/{word}/videos"),
            [new TemplateParam("word", word)],
            [new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetVideosWithTagErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
