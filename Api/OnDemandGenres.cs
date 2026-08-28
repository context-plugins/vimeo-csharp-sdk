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
/// Use these methods to work with On Demand genres.
/// </summary>
public sealed class OnDemandGenres
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OnDemandGenres(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a genre to an On Demand page
    /// </summary>
    /// <param name="genreId">The ID of the genre.</param>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandGenre"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVodGenreError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds the specified genre designation to an On Demand page. A page can be associated with a maximum of two genres. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<OnDemandGenre> AddVodGenre(string genreId,
        double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/genres/{genre_id}"),
            [new TemplateParam("genre_id", genreId), new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandGenre>(),
            AddVodGenreErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a genre from an On Demand page
    /// </summary>
    /// <param name="genreId">The ID of the genre.</param>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVodGenreError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes a genre association from the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task DeleteVodGenre(string genreId,
        double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/genres/{genre_id}"),
            [new TemplateParam("genre_id", genreId), new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteVodGenreErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific On Demand page in a genre
    /// </summary>
    /// <param name="genreId">The ID of the genre.</param>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPage"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGenreVodError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single On Demand page that belongs to the specified genre.
    /// </remarks>
    public Task<OnDemandPage> GetGenreVod(string genreId,
        double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/genres/{genre_id}/pages/{ondemand_id}"),
            [new TemplateParam("genre_id", genreId), new TemplateParam("ondemand_id", ondemandId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandPage>(),
            GetGenreVodErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the On Demand pages in a genre
    /// </summary>
    /// <param name="genreId">The ID of the genre.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>country</c> - Sort the results by country.  * <c>my_region</c> - Sort the results by user's region.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>name</c> - Sort the results by name.  * <c>publish.time</c> - Sort the results by time of publishing.  * <c>videos</c> - Sort the results by video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPageConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGenreVodsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every On Demand page that belongs to the specified genre.
    /// </remarks>
    public Task<OnDemandPageConnection> GetGenreVods(string genreId,
        Direction? direction,
        Filter24? filter,
        double? page,
        double? perPage,
        string? query,
        Sort41? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/genres/{genre_id}/pages"),
            [new TemplateParam("genre_id", genreId)],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandPageConnection>(),
            GetGenreVodsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific On Demand genre
    /// </summary>
    /// <param name="genreId">The ID of the genre.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandGenre"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodGenreError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single On Demand genre.
    /// </remarks>
    public Task<OnDemandGenre> GetVodGenre(string genreId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/genres/{genre_id}"),
            [new TemplateParam("genre_id", genreId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandGenre>(),
            GetVodGenreErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Check whether an On Demand page belongs to a specific genre
    /// </summary>
    /// <param name="genreId">The ID of the genre.</param>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandGenre"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodGenreByOndemandIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether an On Demand page is associated with the specified genre.
    /// </remarks>
    public Task<OnDemandGenre> GetVodGenreByOndemandId(string genreId,
        double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/genres/{genre_id}"),
            [new TemplateParam("genre_id", genreId), new TemplateParam("ondemand_id", ondemandId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandGenre>(),
            GetVodGenreByOndemandIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all On Demand genres
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandGenreConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodGenresError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every existing On Demand genre.
    /// </remarks>
    public Task<OnDemandGenreConnection> GetVodGenres(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/genres"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandGenreConnection>(),
            GetVodGenresErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the genres of an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandGenreConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodGenresByOndemandIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every genre associated with the specified On Demand page.
    /// </remarks>
    public Task<OnDemandGenreConnection> GetVodGenresByOndemandId(double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/genres"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandGenreConnection>(),
            GetVodGenresByOndemandIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
