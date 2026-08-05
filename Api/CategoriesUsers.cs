using System;
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
/// Use these methods to manage user interactions with a category.
/// </summary>
public sealed class CategoriesUsers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CategoriesUsers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Check if the user follows a category
    /// </summary>
    /// <param name="category">The name of the category.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether the authenticated user follows the specified category.
    /// </remarks>
    public Task CheckIfUserSubscribedToCategory(string category,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/categories/{category}"),
            [new TemplateParam("category", category), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Check if the user follows a category
    /// </summary>
    /// <param name="category">The name of the category.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method determines whether the authenticated user follows the specified category.
    /// </remarks>
    public Task CheckIfUserSubscribedToCategoryAlt1(string category,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/categories/{category}"),
            [new TemplateParam("category", category)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the categories that the user follows
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>name</c> - Sort the results by name.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CategoryConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCategorySubscriptionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every category that the authenticated user follows.
    /// </remarks>
    public Task<CategoryConnection> GetCategorySubscriptions(double userId,
        Direction? direction,
        double? page,
        double? perPage,
        Sort24? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/categories"),
            [new TemplateParam("user_id", userId)],
            [new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CategoryConnection>(),
            GetCategorySubscriptionsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the categories that the user follows
    /// </summary>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>name</c> - Sort the results by name.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CategoryConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCategorySubscriptionsAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every category that the authenticated user follows.
    /// </remarks>
    public Task<CategoryConnection> GetCategorySubscriptionsAlt1(Direction? direction,
        double? page,
        double? perPage,
        Sort24? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/categories"),
            [],
            [new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CategoryConnection>(),
            GetCategorySubscriptionsAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Cause the user to follow a specific category
    /// </summary>
    /// <param name="category">The name of the category.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method causes the authenticated user to follow the specified category.
    /// </remarks>
    public Task SubscribeToCategory(string category,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/categories/{category}"),
            [new TemplateParam("category", category), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Cause the user to follow a specific category
    /// </summary>
    /// <param name="category">The name of the category.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method causes the authenticated user to follow the specified category.
    /// </remarks>
    public Task SubscribeToCategoryAlt1(string category,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/categories/{category}"),
            [new TemplateParam("category", category)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Cause the user to stop following a category
    /// </summary>
    /// <param name="category">The name of the category.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method causes the authenticated user to stop following the specified category.
    /// </remarks>
    public Task UnsubscribeFromCategory(string category,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/categories/{category}"),
            [new TemplateParam("category", category), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Cause the user to stop following a category
    /// </summary>
    /// <param name="category">The name of the category.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method causes the authenticated user to stop following the specified category.
    /// </remarks>
    public Task UnsubscribeFromCategoryAlt1(string category,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/categories/{category}"),
            [new TemplateParam("category", category)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
