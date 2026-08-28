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
using Vimeo.Models.Enums;

namespace Vimeo.Api;

/// <summary>
/// Use these methods to work with promotions on On Demand pages.
/// </summary>
public sealed class OnDemandPromotions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OnDemandPromotions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a promotion to an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPromotion"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateVodPromotionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a promotion to the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<OnDemandPromotion> CreateVodPromotion(double ondemandId,
        OndemandPagesPromotionsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/promotions"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<OnDemandPromotion>(),
            CreateVodPromotionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a promotion on an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="promotionId">The ID of the promotion.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVodPromotionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes a promotion on the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task DeleteVodPromotion(double ondemandId,
        double promotionId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/promotions/{promotion_id}"),
            [new TemplateParam("ondemand_id", ondemandId), new TemplateParam("promotion_id", promotionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteVodPromotionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific promotion on an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="promotionId">The ID of the promotion.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPromotion"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodPromotionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single promotion on the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<OnDemandPromotion> GetVodPromotion(double ondemandId,
        double promotionId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/promotions/{promotion_id}"),
            [new TemplateParam("ondemand_id", ondemandId), new TemplateParam("promotion_id", promotionId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandPromotion>(),
            GetVodPromotionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the codes of a promotion on an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="promotionId">The ID of the promotion.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPromotionCode"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodPromotionCodesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every code of the specified promotion on an On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<OnDemandPromotionCode> GetVodPromotionCodes(double ondemandId,
        double promotionId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/promotions/{promotion_id}/codes"),
            [new TemplateParam("ondemand_id", ondemandId), new TemplateParam("promotion_id", promotionId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandPromotionCode>(),
            GetVodPromotionCodesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the promotions on an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="filter">The type of filter to apply to the results.  Option descriptions:  * <c>batch</c> - Filter the results by the <c>batch</c> promotion.  * <c>default</c> - Filter the results by the default promotion.  * <c>single</c> - Filter the results by the <c>single</c> promotion.  * <c>vip</c> - Filter the results by the <c>vip</c> promotion.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPromotion"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodPromotionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every promotion on the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<OnDemandPromotion> GetVodPromotions(double ondemandId,
        Filter26 filter,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/promotions"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [new Param("filter", filter), new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandPromotion>(),
            GetVodPromotionsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
