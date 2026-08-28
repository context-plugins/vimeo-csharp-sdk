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
/// Use these methods to work with background images on an On Demand page.
/// </summary>
public sealed class OnDemandBackgrounds
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OnDemandBackgrounds(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a background to an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateVodBackgroundError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a background image to the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<Picture> CreateVodBackground(double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/backgrounds"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            CreateVodBackgroundErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a background on an On Demand page
    /// </summary>
    /// <param name="backgroundId">The ID of the background image.</param>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVodBackgroundError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified background image on an On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task DeleteVodBackground(double backgroundId,
        double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/backgrounds/{background_id}"),
            [new TemplateParam("background_id", backgroundId), new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteVodBackgroundErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit a background on an On Demand page
    /// </summary>
    /// <param name="backgroundId">The ID of the background image.</param>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditVodBackgroundError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the specified background image on an On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<Picture> EditVodBackground(double backgroundId,
        double ondemandId,
        OndemandPagesBackgroundsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/backgrounds/{background_id}"),
            [new TemplateParam("background_id", backgroundId), new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Picture>(),
            EditVodBackgroundErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific background on an On Demand page
    /// </summary>
    /// <param name="backgroundId">The ID of the background image.</param>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodBackgroundError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single background image on the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<Picture> GetVodBackground(double backgroundId,
        double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/backgrounds/{background_id}"),
            [new TemplateParam("background_id", backgroundId), new TemplateParam("ondemand_id", ondemandId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetVodBackgroundErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the backgrounds on an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PictureConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodBackgroundsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every background image on the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<PictureConnection> GetVodBackgrounds(double ondemandId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/backgrounds"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PictureConnection>(),
            GetVodBackgroundsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
