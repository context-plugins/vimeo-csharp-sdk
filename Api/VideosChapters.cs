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
/// Use these methods to work with video chapters.
/// </summary>
public sealed class VideosChapters
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VideosChapters(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a chapter to a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Chapter"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateChapterError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a chapter to the specified video.
    /// </remarks>
    public Task<Chapter> CreateChapter(double videoId,
        VideosChaptersRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Chapter>(),
            CreateChapterErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Generate an upload link or timecode-based thumbnail for a saved video chapter
    /// </summary>
    /// <param name="chapterId">The ID of the chapter.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateChapterThumbnailOrUploadLinkError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method generates either an upload link or a timecode-based thumbnail for the specified saved video chapter. To generate the upload link, which enables the authenticated user to upload a chapter thumbnail image manually, leave the body of the request empty. To generate an automatic timecode-based thumbnail, include the <b>timecode</b> parameter in the body of the request.
    /// </remarks>
    public Task<Picture> CreateChapterThumbnailOrUploadLink(double chapterId,
        double videoId,
        VideosChaptersPicturesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters/{chapter_id}/pictures"),
            [new TemplateParam("chapter_id", chapterId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            CreateChapterThumbnailOrUploadLinkErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Generate an upload link or timecode-based thumbnail for an unsaved video chapter
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateUnsavedChapterThumbnailOrUploadLinkError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method generates either an upload link or a timecode-based thumbnail for an unsaved video chapter. To generate the upload link, which enables the authenticated user to upload a chapter thumbnail image manually, leave the body of the request empty. To generate an automatic timecode-based thumbnail, specify the <b>timecode</b> parameter in the body of the request.
    /// </remarks>
    public Task<Picture> CreateUnsavedChapterThumbnailOrUploadLink(double videoId,
        VideosChaptersTemporaryPicturesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters/temporary/pictures"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            CreateUnsavedChapterThumbnailOrUploadLinkErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a chapter
    /// </summary>
    /// <param name="chapterId">The ID of the chapter.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteChapterError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified chapter from a video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task DeleteChapter(double chapterId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters/{chapter_id}"),
            [new TemplateParam("chapter_id", chapterId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteChapterErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a chapter thumbnail
    /// </summary>
    /// <param name="chapterId">The ID of the chapter.</param>
    /// <param name="uid">The unique ID of the thumbnail.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteChapterThumbnailError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified chapter thumbnail from a video.
    /// <para>
    /// The authenticated user must be the owner of the video that the chapter belongs to.
    /// This method deletes both timecode-generated and custom-uploaded thumbnails.
    /// </para>
    /// </remarks>
    public Task DeleteChapterThumbnail(double chapterId,
        string uid,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters/{chapter_id}/pictures/{uid}"),
            [new TemplateParam("chapter_id", chapterId),
                new TemplateParam("uid", uid),
                new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteChapterThumbnailErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit a chapter
    /// </summary>
    /// <param name="chapterId">The ID of the chapter.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Chapter"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditChapterError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the specified chapter of a video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<Chapter> EditChapter(double chapterId,
        double videoId,
        VideosChaptersRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters/{chapter_id}"),
            [new TemplateParam("chapter_id", chapterId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Chapter>(),
            EditChapterErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific chapter
    /// </summary>
    /// <param name="chapterId">The ID of the chapter.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Chapter"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetChapterError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single chapter of the specified video.
    /// </remarks>
    public Task<Chapter> GetChapter(double chapterId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters/{chapter_id}"),
            [new TemplateParam("chapter_id", chapterId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Chapter>(),
            GetChapterErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a single chapter thumbnail associated with a saved video chapter
    /// </summary>
    /// <param name="chapterId">The ID of the chapter.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="uid"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetChapterThumbnailError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the specified thumbnail associated with a saved video chapter.
    /// </remarks>
    public Task<Picture> GetChapterThumbnail(double chapterId,
        double videoId,
        string uid,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters/{chapter_id}/pictures/{uid}"),
            [new TemplateParam("chapter_id", chapterId),
                new TemplateParam("video_id", videoId),
                new TemplateParam("uid", uid)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetChapterThumbnailErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the thumbnails associated with a saved video chapter
    /// </summary>
    /// <param name="chapterId">The ID of the chapter.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetChapterThumbnailsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every thumbnail associated with the specified saved video chapter.
    /// </remarks>
    public Task<Picture> GetChapterThumbnails(double chapterId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters/{chapter_id}/pictures"),
            [new TemplateParam("chapter_id", chapterId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetChapterThumbnailsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the chapters of a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChapterConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetChaptersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every chapter of the specified video.
    /// </remarks>
    public Task<ChapterConnection> GetChapters(double videoId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters"),
            [new TemplateParam("video_id", videoId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ChapterConnection>(),
            GetChaptersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a single chapter thumbnail associated with an unsaved video chapter
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="uid"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetUnsavedChapterThumbnailError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the specified thumbnail associated with an unsaved video chapter.
    /// </remarks>
    public Task<Picture> GetUnsavedChapterThumbnail(double videoId,
        string uid,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters/temporary/pictures/{uid}"),
            [new TemplateParam("video_id", videoId), new TemplateParam("uid", uid)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetUnsavedChapterThumbnailErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Set a chapter thumbnail as active
    /// </summary>
    /// <param name="chapterId">The ID of the chapter.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="uid"></param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetChapterThumbnailActiveError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method sets the specified chapter thumbnail for a video as active.
    /// </remarks>
    public Task<Picture> SetChapterThumbnailActive(double chapterId,
        double videoId,
        string uid,
        VideosChaptersPicturesUidRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/chapters/{chapter_id}/pictures/{uid}"),
            [new TemplateParam("chapter_id", chapterId),
                new TemplateParam("video_id", videoId),
                new TemplateParam("uid", uid)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            SetChapterThumbnailActiveErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
