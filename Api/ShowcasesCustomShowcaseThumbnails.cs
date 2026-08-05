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
/// Use these methods to manage custom thumbnail images for showcases. These thumbnails come from uploaded image files that aren't necessarily stills from a video.
/// </summary>
public sealed class ShowcasesCustomShowcaseThumbnails
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ShowcasesCustomShowcaseThumbnails(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a custom thumbnail to a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateShowcaseCustomThumbError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds an uploaded image file as a custom thumbnail for the specified showcase. The image doesn't need to be a still from a showcase video, unlike with the <see href="https://developer.vimeo.com/api/reference/showcases#set_video_as_showcase_thumbnail">standard thumbnail method</see>. The authenticated user must be the owner of the showcase.
    /// <para>
    /// For information on how to upload the thumbnail, see our <see href="https://developer.vimeo.com/api/upload/thumbnails">Working with Thumbnail Uploads</see> guide, and follow the same steps.
    /// </para>
    /// </remarks>
    public Task<Picture> CreateShowcaseCustomThumb(double albumId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/custom_thumbnails"),
            [new TemplateParam("album_id", albumId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            CreateShowcaseCustomThumbErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a custom showcase thumbnail
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="thumbnailId">The ID of the custom thumbnail.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteShowcaseCustomThumbnailError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified custom thumbnail from its showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task DeleteShowcaseCustomThumbnail(double albumId,
        double thumbnailId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/custom_thumbnails/{thumbnail_id}"),
            [new TemplateParam("album_id", albumId),
                new TemplateParam("thumbnail_id", thumbnailId),
                new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteShowcaseCustomThumbnailErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific custom showcase thumbnail
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="thumbnailId">The ID of the custom thumbnail.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcaseCustomThumbnailError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single custom thumbnail of the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<Picture> GetShowcaseCustomThumbnail(double albumId,
        double thumbnailId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/custom_thumbnails/{thumbnail_id}"),
            [new TemplateParam("album_id", albumId),
                new TemplateParam("thumbnail_id", thumbnailId),
                new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetShowcaseCustomThumbnailErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the custom thumbnails of a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PictureConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcaseCustomThumbsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every custom thumbnail of the specified showcase.
    /// </remarks>
    public Task<PictureConnection> GetShowcaseCustomThumbs(double albumId,
        double userId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/custom_thumbnails"),
            [new TemplateParam("album_id", albumId), new TemplateParam("user_id", userId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PictureConnection>(),
            GetShowcaseCustomThumbsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Replace a custom showcase thumbnail
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="thumbnailId">The ID of the custom thumbnail.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ReplaceShowcaseCustomThumbError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method replaces the specified custom showcase thumbnail with a new image file. The authenticated user must be the owner of the showcase.
    /// <para>
    /// For information on how to upload the thumbnail, see our <see href="https://developer.vimeo.com/api/upload/thumbnails">Working with Thumbnail Uploads</see> guide.
    /// </para>
    /// </remarks>
    public Task<Picture> ReplaceShowcaseCustomThumb(double albumId,
        double thumbnailId,
        double userId,
        UsersAlbumsCustomThumbnailsThumbnailIdRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/custom_thumbnails/{thumbnail_id}"),
            [new TemplateParam("album_id", albumId),
                new TemplateParam("thumbnail_id", thumbnailId),
                new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            ReplaceShowcaseCustomThumbErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
