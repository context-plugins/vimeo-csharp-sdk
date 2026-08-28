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

namespace Vimeo.Api;

/// <summary>
/// Use these methods to work with video text tracks.
/// </summary>
public sealed class VideosTextTracks
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VideosTextTracks(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a text track to a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TextTrack"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateTextTrackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a text track to the specified video. For more information, see <see href="https://developer.vimeo.com/api/upload/texttracks">Working with Text Track Uploads</see>.
    /// </remarks>
    public Task<TextTrack> CreateTextTrack(double videoId,
        VideosTexttracksRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/texttracks"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TextTrack>(),
            CreateTextTrackErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a text track to a video
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TextTrack"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateTextTrackAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a text track to the specified video. For more information, see <see href="https://developer.vimeo.com/api/upload/texttracks">Working with Text Track Uploads</see>.
    /// </remarks>
    public Task<TextTrack> CreateTextTrackAlt1(double channelId,
        double videoId,
        ChannelsVideosTexttracksRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/videos/{video_id}/texttracks"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TextTrack>(),
            CreateTextTrackAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a text track
    /// </summary>
    /// <param name="texttrackId">The ID of the text track.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteTextTrackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified text track from a video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task DeleteTextTrack(double texttrackId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/texttracks/{texttrack_id}"),
            [new TemplateParam("texttrack_id", texttrackId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteTextTrackErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit a text track
    /// </summary>
    /// <param name="texttrackId">The ID of the text track.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TextTrack"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditTextTrackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the specified text track of a video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<TextTrack> EditTextTrack(double texttrackId,
        double videoId,
        VideosTexttracksRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/texttracks/{texttrack_id}"),
            [new TemplateParam("texttrack_id", texttrackId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<TextTrack>(),
            EditTextTrackErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific text track
    /// </summary>
    /// <param name="texttrackId">The ID of the text track.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TextTrack"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTextTrackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single text track of the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<TextTrack> GetTextTrack(double texttrackId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/texttracks/{texttrack_id}"),
            [new TemplateParam("texttrack_id", texttrackId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TextTrack>(),
            GetTextTrackErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the text tracks of a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TextTrackConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTextTracksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every text track of the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<TextTrackConnection> GetTextTracks(double videoId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/texttracks"),
            [new TemplateParam("video_id", videoId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TextTrackConnection>(),
            GetTextTracksErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the text tracks of a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="versionId"></param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TextTrackConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTextTracksAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every text track of the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<TextTrackConnection> GetTextTracksAlt1(double videoId,
        string versionId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions/{version_id}/texttracks"),
            [new TemplateParam("video_id", videoId), new TemplateParam("version_id", versionId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TextTrackConnection>(),
            GetTextTracksAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the text tracks of a video
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TextTrackConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTextTracksAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every text track of the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<TextTrackConnection> GetTextTracksAlt2(double channelId,
        double videoId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/videos/{video_id}/texttracks"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("video_id", videoId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TextTrackConnection>(),
            GetTextTracksAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the text tracks of a video
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TextTrackConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTextTracksAlt3Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every text track of the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<TextTrackConnection> GetTextTracksAlt3(double albumId,
        double videoId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/albums/{album_id}/videos/{video_id}/texttracks"),
            [new TemplateParam("album_id", albumId), new TemplateParam("video_id", videoId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TextTrackConnection>(),
            GetTextTracksAlt3ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
