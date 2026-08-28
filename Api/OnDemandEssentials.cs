using System;
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
using Vimeo.Models.Enums;

namespace Vimeo.Api;

/// <summary>
/// These are the most common methods for working with On Demand pages.
/// </summary>
public sealed class OnDemandEssentials
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OnDemandEssentials(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an On Demand page
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPage"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a new On Demand page for the specified user. To publish the page, use the <see href="https://developer.vimeo.com/api/reference/on-demand#edit_vod">edit</see> method.
    /// </remarks>
    public Task<OnDemandPage> CreateVod(double userId,
        UsersOndemandPagesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/ondemand/pages"),
            [new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<OnDemandPage>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create an On Demand page
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPage"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a new On Demand page for the specified user. To publish the page, use the <see href="https://developer.vimeo.com/api/reference/on-demand#edit_vod">edit</see> method.
    /// </remarks>
    public Task<OnDemandPage> CreateVodAlt1(MeOndemandPagesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/ondemand/pages"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<OnDemandPage>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVodDraftError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified On Demand page.
    /// </remarks>
    public Task DeleteVodDraft(double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteVodDraftErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPage"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditVodError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the specified On Demand page. Use this method to enable preorders on the page or to publish the page.
    /// </remarks>
    public Task<OnDemandPage> EditVod(double ondemandId,
        OndemandPagesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<OnDemandPage>(),
            EditVodErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the On Demand pages of the user
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The type of the page to return.  Option descriptions:  * <c>film</c> - The page type is a film.  * <c>series</c> - The page type is a series.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>added</c> - Sort the results by most recently added page.  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>modified_time</c> - Sort the results by time of page modification.  * <c>name</c> - Sort the results by page name.  * <c>publish.time</c> - Sort the results by time of page publishing.  * <c>rating</c> - Sort the results by content rating.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPageConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetUserVodsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every On Demand page belonging to the authenticated user.
    /// </remarks>
    public Task<OnDemandPageConnection> GetUserVods(double userId,
        Direction? direction,
        Filter18? filter,
        double? page,
        double? perPage,
        Sort32? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/ondemand/pages"),
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
            GetUserVodsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the On Demand pages of the user
    /// </summary>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The type of the page to return.  Option descriptions:  * <c>film</c> - The page type is a film.  * <c>series</c> - The page type is a series.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>added</c> - Sort the results by most recently added page.  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>modified_time</c> - Sort the results by time of page modification.  * <c>name</c> - Sort the results by page name.  * <c>publish.time</c> - Sort the results by time of page publishing.  * <c>rating</c> - Sort the results by content rating.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPageConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetUserVodsAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every On Demand page belonging to the authenticated user.
    /// </remarks>
    public Task<OnDemandPageConnection> GetUserVodsAlt1(Direction? direction,
        Filter18? filter,
        double? page,
        double? perPage,
        Sort32? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/ondemand/pages"),
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
            GetUserVodsAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandPage"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVodError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the specified On Demand page.
    /// </remarks>
    public Task<OnDemandPage> GetVod(double ondemandId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandPage>(),
            GetVodErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
