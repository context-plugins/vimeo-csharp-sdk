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
/// Use these methods to search for users.
/// </summary>
public sealed class UsersSearch
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsersSearch(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Search for users
    /// </summary>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by creation date.  * <c>followers</c> - Sort the results by number of followers.  * <c>relevant</c> - Sort the results by relevance.  * <c>videos</c> - Sort the results by number of videos.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SearchUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns user search results.
    /// </remarks>
    public Task<UserConnection> SearchUsers(Direction? direction,
        double? page,
        double? perPage,
        string? query,
        Sort13? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users"),
            [],
            [new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<UserConnection>(),
            SearchUsersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
