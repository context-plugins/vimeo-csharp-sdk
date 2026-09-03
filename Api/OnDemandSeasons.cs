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
using VimeoApi.Models.Enums;

namespace VimeoApi.Api;

/// <summary>
/// Use these methods to work with On Demand seasons.
/// </summary>
public sealed class OnDemandSeasons
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OnDemandSeasons(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a specific season on an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="seasonId">The ID of the season.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandSeason"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodSeasonError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single season on the specified On Demand page.
    /// </remarks>
    public Task<OnDemandSeason> GetVodSeason(double ondemandId,
        double seasonId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/seasons/{season_id}"),
            [new TemplateParam("ondemand_id", ondemandId), new TemplateParam("season_id", seasonId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandSeason>(),
            GetVodSeasonErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in a season on an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="seasonId">The ID of the season.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>viewable</c> - Filter by viewable videos.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>date</c> - Sort the results by date.  * <c>default</c> - Use the default sorting method.  * <c>manual</c> - Sort the results manually.  * <c>name</c> - Sort the results by name.  * <c>purchase_time</c> - Sort the results by time of purchase.  * <c>release_date</c> - Sort the results by release date.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video in the specified season on an On Demand page.
    /// </remarks>
    public Task<VideoConnection> GetVodSeasonVideos(double ondemandId,
        double seasonId,
        Filter27? filter,
        double? page,
        double? perPage,
        Sort44? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/seasons/{season_id}/videos"),
            [new TemplateParam("ondemand_id", ondemandId), new TemplateParam("season_id", seasonId)],
            [new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the seasons on an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>viewable</c> - Filter by viewable seasons.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>date</c> - Sort the results by date.  * <c>manual</c> - Sort the results manually.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandSeasonConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodSeasonsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every season on the specified On Demand page.
    /// </remarks>
    public Task<OnDemandSeasonConnection> GetVodSeasons(double ondemandId,
        Direction? direction,
        Filter27? filter,
        double? page,
        double? perPage,
        Sort43? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/seasons"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandSeasonConnection>(),
            GetVodSeasonsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
