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
/// Use these methods to work with groups in a category.
/// </summary>
public sealed class CategoriesGroups
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CategoriesGroups(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get all the groups in a category
    /// </summary>
    /// <param name="category">The name of the category.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>members</c> - Sort the results by number of members.  * <c>videos</c> - Sort the results by number of videos.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GroupConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCategoryGroupsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every group that belongs to the specified category.
    /// </remarks>
    public Task<GroupConnection> GetCategoryGroups(string category,
        Direction? direction,
        double? page,
        double? perPage,
        string? query,
        Sort5? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/categories/{category}/groups"),
            [new TemplateParam("category", category)],
            [new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GroupConnection>(),
            GetCategoryGroupsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
