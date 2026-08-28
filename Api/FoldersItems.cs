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
using Vimeo.Models.Enums;

namespace Vimeo.Api;

/// <summary>
/// Use these methods to manage items in folders.
/// </summary>
public sealed class FoldersItems
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FoldersItems(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Remove items from a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="uris">A comma-separated list of video, event, or folder URIs to remove. Folder URIs are moved to the library root (with their contents).</param>
    /// <param name="sendToRecentlyDeleted">When <c>should_delete_items</c> is true, send deleted clips to Recently Deleted purgatory (<c>TYPE_RECENTLY_DELETED</c>) instead of legacy user delete purgatory.</param>
    /// <param name="shouldDeleteItems">Whether to delete the items when removing them from the folder.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteFolderItemsAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes all items from the specified folder.
    /// </remarks>
    public Task DeleteFolderItemsAlt1(double projectId,
        string uris,
        bool? sendToRecentlyDeleted,
        bool? shouldDeleteItems,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects/{project_id}/items"),
            [new TemplateParam("project_id", projectId)],
            [new Param("uris", uris),
                new Param("send_to_recently_deleted", sendToRecentlyDeleted),
                new Param("should_delete_items", shouldDeleteItems)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteFolderItemsAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the items in a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="clipPrivacyFilters">A comma-separated list of video privacy types to filter on. The accepted values are <c>private</c> for when only the creator and users with access grants can play the video; <c>public</c> for when anyone can play the video; <c>password</c> for when only users with the correct password can play the video; <c>hide_from_vimeo</c> for when the video is private but embeddable anywhere; and <c>unlisted</c> for when only users with the link can play the video.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>folder</c> - Filter the results by folder.  * <c>live_event</c> - Filter the results by event.  * <c>video</c> - Filter the results by video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>default</c> - Use the default sort order.  * <c>duration</c> - Sort the results by duration. Items without a duration, namely events and folders, are grouped by type in ascending alphabetical order, with events first.  * <c>last_user_action_event_date</c> - Sort the results by the date of the last user action.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every item that belongs to the specified folder.
    /// </remarks>
    public Task GetFolderItems(double projectId,
        string? clipPrivacyFilters,
        Direction? direction,
        Filter21? filter,
        double? page,
        double? perPage,
        Sort37? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects/{project_id}/items"),
            [new TemplateParam("project_id", projectId)],
            [new Param("clip_privacy_filters", clipPrivacyFilters),
                new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the items in a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="clipPrivacyFilters">A comma-separated list of video privacy types to filter on. The accepted values are <c>private</c> for when only the creator and users with access grants can play the video; <c>public</c> for when anyone can play the video; <c>password</c> for when only users with the correct password can play the video; <c>hide_from_vimeo</c> for when the video is private but embeddable anywhere; and <c>unlisted</c> for when only users with the link can play the video.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>folder</c> - Filter the results by folder.  * <c>live_event</c> - Filter the results by event.  * <c>video</c> - Filter the results by video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date.  * <c>default</c> - Use the default sort order.  * <c>duration</c> - Sort the results by duration. Items without a duration, namely events and folders, are grouped by type in ascending alphabetical order, with events first.  * <c>last_user_action_event_date</c> - Sort the results by the date of the last user action.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every item that belongs to the specified folder.
    /// </remarks>
    public Task GetFolderItems2(double projectId,
        double userId,
        string? clipPrivacyFilters,
        Direction? direction,
        Filter21? filter,
        double? page,
        double? perPage,
        Sort37? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects/{project_id}/items"),
            [new TemplateParam("project_id", projectId), new TemplateParam("user_id", userId)],
            [new Param("clip_privacy_filters", clipPrivacyFilters),
                new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
