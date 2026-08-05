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
/// Use these methods to work with animated thumbnails for videos.
/// </summary>
public sealed class VideosAnimatedThumbnails
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VideosAnimatedThumbnails(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a set of animated thumbnails for a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AnimatedThumbset"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateAnimatedThumbsetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a set of animated thumbnails for the specified video. Please note that you can't create more than four sets of animated thumbnails for the same video.
    /// </remarks>
    public Task<AnimatedThumbset> CreateAnimatedThumbset(double videoId,
        VideosAnimatedThumbsetsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/animated_thumbsets"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AnimatedThumbset>(),
            CreateAnimatedThumbsetErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a set of animated thumbnails for a video
    /// </summary>
    /// <param name="pictureId">The UUID of the set of animated thumbnails.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteAnimatedThumbsetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes a set of animated thumbnails for the specified video.
    /// </remarks>
    public Task DeleteAnimatedThumbset(string pictureId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/animated_thumbsets/{picture_id}"),
            [new TemplateParam("picture_id", pictureId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteAnimatedThumbsetErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the animated thumbnails of a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AnimatedThumbsetConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAllAnimatedThumbsetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the sets of animated thumbnails associated with the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<AnimatedThumbsetConnection> GetAllAnimatedThumbset(double videoId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/animated_thumbsets"),
            [new TemplateParam("video_id", videoId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AnimatedThumbsetConnection>(),
            GetAllAnimatedThumbsetErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific set of animated thumbnails
    /// </summary>
    /// <param name="pictureId">The UUID of the set of animated thumbnails.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AnimatedThumbset"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAnimatedThumbsetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a particular set of animated thumbnails associated with the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<AnimatedThumbset> GetAnimatedThumbset(string pictureId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/animated_thumbsets/{picture_id}"),
            [new TemplateParam("picture_id", pictureId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AnimatedThumbset>(),
            GetAnimatedThumbsetErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the status of a set of animated thumbnails
    /// </summary>
    /// <param name="pictureId">The UUID of the set of animated thumbnails.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AnimatedThumbset"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAnimatedThumbsetStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the status of a particular set of animated thumbnails associated with the specified video. The status indicates whether the thumbnails are ready to use. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<AnimatedThumbset> GetAnimatedThumbsetStatus(string pictureId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/animated_thumbsets/{picture_id}/status"),
            [new TemplateParam("picture_id", pictureId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AnimatedThumbset>(),
            GetAnimatedThumbsetStatusErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
