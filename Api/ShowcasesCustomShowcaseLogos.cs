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
/// Use these methods to manage custom showcase logos, or the supplementary images, usually logos, that appear on a showcase's page. These images aren't the same as showcase thumbnails, or the images that represent the showcase across Vimeo.
/// </summary>
public sealed class ShowcasesCustomShowcaseLogos
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ShowcasesCustomShowcaseLogos(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a custom logo to a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateShowcaseLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds an image file as a custom logo to the specified showcase. The authenticated user must be the owner of the showcase.
    /// <para>
    /// For information on how to upload the logo, see our <see href="https://developer.vimeo.com/api/upload/thumbnails">Working with Thumbnail Uploads</see> guide.
    /// </para>
    /// </remarks>
    public Task<Picture> CreateShowcaseLogo(double albumId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/logos"),
            [new TemplateParam("album_id", albumId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            CreateShowcaseLogoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a custom showcase logo
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="logoId">The ID of the custom logo.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteShowcaseLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified custom logo from its showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task DeleteShowcaseLogo(double albumId,
        double logoId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/logos/{logo_id}"),
            [new TemplateParam("album_id", albumId),
                new TemplateParam("logo_id", logoId),
                new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteShowcaseLogoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific custom showcase logo
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="logoId">The ID of the custom logo.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcaseLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single custom logo of the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<Picture> GetShowcaseLogo(double albumId,
        double logoId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/logos/{logo_id}"),
            [new TemplateParam("album_id", albumId),
                new TemplateParam("logo_id", logoId),
                new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetShowcaseLogoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the custom logos of a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PictureConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcaseLogosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every custom logo of the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<PictureConnection> GetShowcaseLogos(double albumId,
        double userId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/logos"),
            [new TemplateParam("album_id", albumId), new TemplateParam("user_id", userId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PictureConnection>(),
            GetShowcaseLogosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Replace a custom showcase logo
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="logoId">The ID of the custom logo.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ReplaceShowcaseLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method replaces the specified custom showcase logo with a new image file. The authenticated user must be the owner of the showcase.
    /// <para>
    /// For information on how to upload the logo, see our <see href="https://developer.vimeo.com/api/upload/thumbnails">Working with Thumbnail Uploads</see> guide.
    /// </para>
    /// </remarks>
    public Task<Picture> ReplaceShowcaseLogo(double albumId,
        double logoId,
        double userId,
        UsersAlbumsLogosLogoIdRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/logos/{logo_id}"),
            [new TemplateParam("album_id", albumId),
                new TemplateParam("logo_id", logoId),
                new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            ReplaceShowcaseLogoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
