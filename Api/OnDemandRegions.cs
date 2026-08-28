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

namespace Vimeo.Api;

/// <summary>
/// Use these methods to work with regions on On Demand pages.
/// </summary>
public sealed class OnDemandRegions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OnDemandRegions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a specific region to an On Demand page
    /// </summary>
    /// <param name="country">The country code of the region to add.</param>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandRegion"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVodRegionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a single region to the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<OnDemandRegion> AddVodRegion(string country,
        double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/regions/{country}"),
            [new TemplateParam("country", country), new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandRegion>(),
            AddVodRegionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a specific region from an On Demand page
    /// </summary>
    /// <param name="country">The country code of the region to remove.</param>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVodRegionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes a single region from the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task DeleteVodRegion(string country,
        double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/regions/{country}"),
            [new TemplateParam("country", country), new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteVodRegionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a list of regions from an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="OnDemandRegion"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVodRegionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes multiple regions from the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<IReadOnlyList<OnDemandRegion>> DeleteVodRegions(double ondemandId,
        OndemandPagesRegionsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/regions"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<OnDemandRegion>>(),
            DeleteVodRegionsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific On Demand region
    /// </summary>
    /// <param name="country">The country code of the region to return.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandRegion"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetRegionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single On Demand region.
    /// </remarks>
    public Task<OnDemandRegion> GetRegion(string country,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/regions/{country}"),
            [new TemplateParam("country", country)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandRegion>(),
            GetRegionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the On Demand regions
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandRegionConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every existing On Demand region.
    /// </remarks>
    public Task<OnDemandRegionConnection> GetRegions(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/regions"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandRegionConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific region on an On Demand page
    /// </summary>
    /// <param name="country">The country code of the region to return.</param>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandRegion"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodRegionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single region on the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<OnDemandRegion> GetVodRegion(string country,
        double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/regions/{country}"),
            [new TemplateParam("country", country), new TemplateParam("ondemand_id", ondemandId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandRegion>(),
            GetVodRegionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the regions on an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandRegionConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodRegionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every region on the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<OnDemandRegionConnection> GetVodRegions(double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/regions"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandRegionConnection>(),
            GetVodRegionsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add a list of regions to an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandRegion"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SetVodRegionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds multiple regions to the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<OnDemandRegion> SetVodRegions(double ondemandId,
        OndemandPagesRegionsRequest1 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/regions"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<OnDemandRegion>(),
            SetVodRegionsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
