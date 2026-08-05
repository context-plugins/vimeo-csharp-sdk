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
/// Vimeo members with access to embed presets can include their own logo images in the embedded player. These custom logos can be part of an embed preset.
/// <para>
///             Use these methods to work with custom logos.
/// </para>
/// </summary>
public sealed class EmbedPresetsCustomLogos
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal EmbedPresetsCustomLogos(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a custom user logo
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateCustomLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a custom logo representing the authenticated user for display in the embedded player. Be sure to use this method in the context of the multi-step upload procedure described in our <see href="https://developer.vimeo.com/api/upload/thumbnails#uploading-a-thumbnail">Working with Thumbnail Uploads</see> guide. This method represents Step 2 of the procedure.
    /// </remarks>
    public Task<Picture> CreateCustomLogo(double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/customlogos"),
            [new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            CreateCustomLogoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a custom user logo
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateCustomLogoAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a custom logo representing the authenticated user for display in the embedded player. Be sure to use this method in the context of the multi-step upload procedure described in our <see href="https://developer.vimeo.com/api/upload/thumbnails#uploading-a-thumbnail">Working with Thumbnail Uploads</see> guide. This method represents Step 2 of the procedure.
    /// </remarks>
    public Task<Picture> CreateCustomLogoAlt1(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/customlogos"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            CreateCustomLogoAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a custom user logo
    /// </summary>
    /// <param name="logoId">The ID of the custom logo.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteCustomLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified custom logo belonging to the authenticated user.
    /// </remarks>
    public Task DeleteCustomLogo(double logoId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/customlogos/{logo_id}"),
            [new TemplateParam("logo_id", logoId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteCustomLogoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a custom user logo
    /// </summary>
    /// <param name="logoId">The ID of the custom logo.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteCustomLogoAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified custom logo belonging to the authenticated user.
    /// </remarks>
    public Task DeleteCustomLogoAlt1(double logoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/customlogos/{logo_id}"),
            [new TemplateParam("logo_id", logoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteCustomLogoAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific custom user logo
    /// </summary>
    /// <param name="logoId">The ID of the custom logo.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCustomLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single custom logo belonging to the authenticated user.
    /// </remarks>
    public Task<Picture> GetCustomLogo(double logoId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/customlogos/{logo_id}"),
            [new TemplateParam("logo_id", logoId), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetCustomLogoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific custom user logo
    /// </summary>
    /// <param name="logoId">The ID of the custom logo.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCustomLogoAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single custom logo belonging to the authenticated user.
    /// </remarks>
    public Task<Picture> GetCustomLogoAlt1(double logoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/customlogos/{logo_id}"),
            [new TemplateParam("logo_id", logoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetCustomLogoAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the custom logos that belong to the user
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sizes">The pixel dimensions of the image in <c>{width}x{height}</c> format. For more information, see our <see href="https://developer.vimeo.com/api/common-formats#using-the-sizes-parameter">Using Common Formats and Parameters</see> guide.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PictureConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCustomLogosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every custom logo that belongs to the authenticated user or team owner.
    /// </remarks>
    public Task<PictureConnection> GetCustomLogos(double userId,
        double? page,
        double? perPage,
        string? sizes,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/customlogos"),
            [new TemplateParam("user_id", userId)],
            [new Param("page", page), new Param("per_page", perPage), new Param("sizes", sizes)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PictureConnection>(),
            GetCustomLogosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the custom logos that belong to the user
    /// </summary>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sizes">The pixel dimensions of the image in <c>{width}x{height}</c> format. For more information, see our <see href="https://developer.vimeo.com/api/common-formats#using-the-sizes-parameter">Using Common Formats and Parameters</see> guide.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PictureConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCustomLogosAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every custom logo that belongs to the authenticated user or team owner.
    /// </remarks>
    public Task<PictureConnection> GetCustomLogosAlt1(double? page,
        double? perPage,
        string? sizes,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/customlogos"),
            [],
            [new Param("page", page), new Param("per_page", perPage), new Param("sizes", sizes)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PictureConnection>(),
            GetCustomLogosAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
