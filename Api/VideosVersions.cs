using System;
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

namespace VimeoApi.Api;

/// <summary>
/// Use these methods to work with video versioning.
/// </summary>
public sealed class VideosVersions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VideosVersions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an audio track for a video version
    /// </summary>
    /// <param name="versionId">The ID of the video version.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlternateAudioTrack"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateAudioTrackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a new audio track for a video version.
    /// </remarks>
    public Task<AlternateAudioTrack> CreateAudioTrack(double versionId,
        double videoId,
        VideosVersionsAudiotracksRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions/{version_id}/audiotracks"),
            [new TemplateParam("version_id", versionId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AlternateAudioTrack>(),
            CreateAudioTrackErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a version to a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoVersion"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateVideoVersionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a version to the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<VideoVersion> CreateVideoVersion(double videoId,
        VideosVersionsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<VideoVersion>(),
            CreateVideoVersionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete an audio track from a video version
    /// </summary>
    /// <param name="audiotrackId">The ID of the audio track.</param>
    /// <param name="versionId">The ID of the video version.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteAudioTrackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes an audio track from the specified video version.
    /// </remarks>
    public Task DeleteAudioTrack(string audiotrackId,
        double versionId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions/{version_id}/audiotracks/{audiotrack_id}"),
            [new TemplateParam("audiotrack_id", audiotrackId),
                new TemplateParam("version_id", versionId),
                new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteAudioTrackErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a video version
    /// </summary>
    /// <param name="versionId">The ID of the video version.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVideoVersionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified version from a video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task DeleteVideoVersion(double versionId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions/{version_id}"),
            [new TemplateParam("version_id", versionId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteVideoVersionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit an audio track for a video version
    /// </summary>
    /// <param name="audiotrackId">The ID of the audio track.</param>
    /// <param name="versionId">The ID of the video version.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlternateAudioTrack"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditAudioTrackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the metadata for the specified audio track.
    /// </remarks>
    public Task<AlternateAudioTrack> EditAudioTrack(string audiotrackId,
        double versionId,
        double videoId,
        VideosVersionsAudiotracksAudiotrackIdRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions/{version_id}/audiotracks/{audiotrack_id}"),
            [new TemplateParam("audiotrack_id", audiotrackId),
                new TemplateParam("version_id", versionId),
                new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<AlternateAudioTrack>(),
            EditAudioTrackErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit a video version
    /// </summary>
    /// <param name="versionId">The ID of the video version.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoVersion"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditVideoVersionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the specified version of a video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<VideoVersion> EditVideoVersion(double versionId,
        double videoId,
        VideosVersionsRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions/{version_id}"),
            [new TemplateParam("version_id", versionId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<VideoVersion>(),
            EditVideoVersionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get an audio track for a video version
    /// </summary>
    /// <param name="audiotrackId">The ID of the audio track.</param>
    /// <param name="versionId">The ID of the video version.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlternateAudioTrack"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAudioTrackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the specified audio track that is associated with a video version.
    /// </remarks>
    public Task<AlternateAudioTrack> GetAudioTrack(string audiotrackId,
        double versionId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions/{version_id}/audiotracks/{audiotrack_id}"),
            [new TemplateParam("audiotrack_id", audiotrackId),
                new TemplateParam("version_id", versionId),
                new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AlternateAudioTrack>(),
            GetAudioTrackErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all audio tracks for a video version
    /// </summary>
    /// <param name="versionId">The ID of the video version.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlternateAudioTrackConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAudioTracksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all audio tracks that are associated with the specified video version.
    /// </remarks>
    public Task<AlternateAudioTrackConnection> GetAudioTracks(double versionId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions/{version_id}/audiotracks"),
            [new TemplateParam("version_id", versionId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AlternateAudioTrackConnection>(),
            GetAudioTracksErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of downloadable file links for a video with an alternate audio track
    /// </summary>
    /// <param name="versionId">The ID of the video version.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a list of downloadable file links for a version of a video that contains the specified alternate audio track.
    /// </remarks>
    public Task GetAudiotrackDownloads(double versionId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions/{version_id}/downloads"),
            [new TemplateParam("version_id", versionId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the thumbnail for a video version
    /// </summary>
    /// <param name="versionId">The ID of the version.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the thumbnail associated with the specified version of a video.
    /// </remarks>
    public Task<Picture> GetVersionThumbnail(double versionId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions/{version_id}/picture"),
            [new TemplateParam("version_id", versionId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific video version
    /// </summary>
    /// <param name="versionId">The ID of the video version.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoVersion"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVideoVersionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single version of the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<VideoVersion> GetVideoVersion(double versionId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions/{version_id}"),
            [new TemplateParam("version_id", versionId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoVersion>(),
            GetVideoVersionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the versions of a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoVersionConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVideoVersionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every version of the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<VideoVersionConnection> GetVideoVersions(double videoId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/versions"),
            [new TemplateParam("video_id", videoId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoVersionConnection>(),
            GetVideoVersionsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the versions of a video
    /// </summary>
    /// <param name="channelId">The ID of the channel.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoVersionConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVideoVersionsAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every version of the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<VideoVersionConnection> GetVideoVersionsAlt1(double channelId,
        double videoId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/channels/{channel_id}/videos/{video_id}/versions"),
            [new TemplateParam("channel_id", channelId), new TemplateParam("video_id", videoId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoVersionConnection>(),
            GetVideoVersionsAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
