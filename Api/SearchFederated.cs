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
/// Use these methods to work with federated searches.
/// </summary>
public sealed class SearchFederated
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SearchFederated(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get the federated search results of the user's items
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>video</c> - Return videos.</param>
    /// <param name="filterPrivacy">A comma-separated list of privacy settings to filter the results by. Possible values include <c>unlisted</c> for videos that are accessible but not searchable from Vimeo, <c>password</c> for videos on Vimeo that anyone can access with the correct password, <c>hide-from-vimeo</c> for videos that don't appear on Vimeo, <c>private</c> for videos on Vimeo that only their owner can access, and <c>public</c> for videos on Vimeo that anyone can access. By default, all privacy settings are considered.</param>
    /// <param name="modifiedEndDate">The inclusive end date of the range.</param>
    /// <param name="modifiedStartDate">The inclusive start date of the range. This value must be earlier than the modified end date.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="queryFields">A comma-separated list of fields to query over. The default value is <c>title,description,chapters,tags</c>.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by creation date.  * <c>default</c> - Use the default sorting order.  * <c>duration</c> - Sort the results by duration, where available.  * <c>folder_path</c> - Sort the results by the hierarchy of folders.  * <c>last_user_action_event_date</c> - Sort the results by most recent user interaction.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FederatedSearchItemsConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FederatedSearchUserItemsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the federated search results of the authenticated user's videos and folders according to a search query.
    /// <para>
    /// If no query is provided, the method returns items sorted by the most recent user action.
    /// </para>
    /// </remarks>
    public Task<FederatedSearchItemsConnection> FederatedSearchUserItems(double userId,
        Direction? direction,
        Filter30? filter,
        string? filterPrivacy,
        string? modifiedEndDate,
        string? modifiedStartDate,
        double? page,
        double? perPage,
        string? query,
        string? queryFields,
        Sort46? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/search/{user_id}/items"),
            [new TemplateParam("user_id", userId)],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("filter_privacy", filterPrivacy),
                new Param("modified_end_date", modifiedEndDate),
                new Param("modified_start_date", modifiedStartDate),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("query_fields", queryFields),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FederatedSearchItemsConnection>(),
            FederatedSearchUserItemsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the federated search results of the user's items
    /// </summary>
    /// <param name="workspaceUuid">The UUID of the workspace.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>video</c> - Return videos.</param>
    /// <param name="filterPrivacy">A comma-separated list of privacy settings to filter the results by. Possible values include <c>unlisted</c> for videos that are accessible but not searchable from Vimeo, <c>password</c> for videos on Vimeo that anyone can access with the correct password, <c>hide-from-vimeo</c> for videos that don't appear on Vimeo, <c>private</c> for videos on Vimeo that only their owner can access, and <c>public</c> for videos on Vimeo that anyone can access. By default, all privacy settings are considered.</param>
    /// <param name="modifiedEndDate">The inclusive end date of the range.</param>
    /// <param name="modifiedStartDate">The inclusive start date of the range. This value must be earlier than the modified end date.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="queryFields">A comma-separated list of fields to query over. The default value is <c>title,description,chapters,tags</c>.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by creation date.  * <c>default</c> - Use the default sorting order.  * <c>duration</c> - Sort the results by duration, where available.  * <c>folder_path</c> - Sort the results by the hierarchy of folders.  * <c>last_user_action_event_date</c> - Sort the results by most recent user interaction.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FederatedSearchItemsConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="FederatedSearchUserItemsAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the federated search results of the authenticated user's videos and folders according to a search query.
    /// <para>
    /// If no query is provided, the method returns items sorted by the most recent user action.
    /// </para>
    /// </remarks>
    public Task<FederatedSearchItemsConnection> FederatedSearchUserItemsAlt1(string workspaceUuid,
        Direction? direction,
        Filter30? filter,
        string? filterPrivacy,
        string? modifiedEndDate,
        string? modifiedStartDate,
        double? page,
        double? perPage,
        string? query,
        string? queryFields,
        Sort46? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/workspaces/search/{workspace_uuid}/items"),
            [new TemplateParam("workspace_uuid", workspaceUuid)],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("filter_privacy", filterPrivacy),
                new Param("modified_end_date", modifiedEndDate),
                new Param("modified_start_date", modifiedStartDate),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("query_fields", queryFields),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FederatedSearchItemsConnection>(),
            FederatedSearchUserItemsAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
