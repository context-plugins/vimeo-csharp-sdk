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
using VimeoApi.Models.Enums;

namespace VimeoApi.Api;

/// <summary>
/// Use these methods to work with purchases and rentals on On Demand pages.
/// </summary>
public sealed class OnDemandPurchasesAndRentals
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OnDemandPurchasesAndRentals(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Check if a user has made a purchase or rental from an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPage"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckIfVodWasPurchasedAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether the authenticated user has made a purchase or rental from the specified On Demand page.
    /// </remarks>
    public Task<OnDemandPage> CheckIfVodWasPurchasedAlt1(double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/ondemand/purchases/{ondemand_id}"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandPage>(),
            CheckIfVodWasPurchasedAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all of the user's On Demand purchases and rentals
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The type of the On Demand video to filter on.  Option descriptions:  * <c>all</c> - Filter by all video types.  * <c>expiring_soon</c> - Filter by videos that expire soon.  * <c>film</c> - Filter by film.  * <c>important</c> - Filter by pages that are about to expire.  * <c>purchased</c> - Filter by purchased videos.  * <c>rented</c> - Filter by rented videos.  * <c>series</c> - Filter by series.  * <c>subscription</c> - Filter by video subscription.  * <c>unwatched</c> - Filter by unwatched videos.  * <c>watched</c> - Filter by watched videos.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>added</c> - Sort the results by most recently added video.  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>name</c> - Sort the results by video name.  * <c>purchase_time</c> - Sort the results by time of video purchase.  * <c>rating</c> - Sort the results by content rating.  * <c>release_date</c> - Sort the results by video release date.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPageConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodPurchasesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every purchase and rental that the authenticated user has made across all On Demand pages.
    /// </remarks>
    public Task<OnDemandPageConnection> GetVodPurchases(double userId,
        Direction? direction,
        Filter19? filter,
        double? page,
        double? perPage,
        Sort33? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/ondemand/purchases"),
            [new TemplateParam("user_id", userId)],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandPageConnection>(),
            GetVodPurchasesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all of the user's On Demand purchases and rentals
    /// </summary>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The type of the On Demand video to filter on.  Option descriptions:  * <c>all</c> - Filter by all video types.  * <c>expiring_soon</c> - Filter by videos that expire soon.  * <c>film</c> - Filter by film.  * <c>important</c> - Filter by pages that are about to expire.  * <c>purchased</c> - Filter by purchased videos.  * <c>rented</c> - Filter by rented videos.  * <c>series</c> - Filter by series.  * <c>subscription</c> - Filter by video subscription.  * <c>unwatched</c> - Filter by unwatched videos.  * <c>watched</c> - Filter by watched videos.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>added</c> - Sort the results by most recently added video.  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>name</c> - Sort the results by video name.  * <c>purchase_time</c> - Sort the results by time of video purchase.  * <c>rating</c> - Sort the results by content rating.  * <c>release_date</c> - Sort the results by video release date.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPageConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodPurchasesAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every purchase and rental that the authenticated user has made across all On Demand pages.
    /// </remarks>
    public Task<OnDemandPageConnection> GetVodPurchasesAlt1(Direction? direction,
        Filter19? filter,
        double? page,
        double? perPage,
        Sort33? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/ondemand/purchases"),
            [],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandPageConnection>(),
            GetVodPurchasesAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
