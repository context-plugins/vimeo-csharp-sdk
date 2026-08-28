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
/// Use these methods to work with user feeds.
/// </summary>
public sealed class UsersFeeds
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsersFeeds(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get all the videos in the user's feed
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="offset">The pagination offset. We recommend that you use the pagination links in the feed response instead of working with this value directly. For more details, see our <see href="https://developer.vimeo.com/api/common-formats#using-the-pagination-parameter">pagination documentation</see>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="type">The feed type.  Option descriptions:  * <c>appears</c> - Videos in which the user appears.  * <c>category_featured</c> - Featured videos.  * <c>channel</c> - Channel videos.  * <c>facebook_feed</c> - Videos from the user's Facebook feed.  * <c>following</c> - Videos from accounts that the user follows.  * <c>group</c> - Group videos.  * <c>likes</c> - Liked videos.  * <c>ondemand_publish</c> - On Demand videos.  * <c>share</c> - Shared videos.  * <c>tagged_with</c> - Tagged videos.  * <c>twitter_timeline</c> - Videos from the user's Twitter timeline.  * <c>uploads</c> - Uploaded videos.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Activity31Connection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFeedError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video in the authenticated user's feed.
    /// </remarks>
    public Task<Activity31Connection> GetFeed(double userId,
        string? offset,
        double? page,
        double? perPage,
        Type33? type,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/feed"),
            [new TemplateParam("user_id", userId)],
            [new Param("offset", offset),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("type", type)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Activity31Connection>(),
            GetFeedErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in the user's feed
    /// </summary>
    /// <param name="offset">The pagination offset. We recommend that you use the pagination links in the feed response instead of working with this value directly. For more details, see our <see href="https://developer.vimeo.com/api/common-formats#using-the-pagination-parameter">pagination documentation</see>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="type">The feed type.  Option descriptions:  * <c>appears</c> - Videos in which the user appears.  * <c>category_featured</c> - Featured videos.  * <c>channel</c> - Channel videos.  * <c>facebook_feed</c> - Videos from the user's Facebook feed.  * <c>following</c> - Videos from accounts that the user follows.  * <c>group</c> - Group videos.  * <c>likes</c> - Liked videos.  * <c>ondemand_publish</c> - On Demand videos.  * <c>share</c> - Shared videos.  * <c>tagged_with</c> - Tagged videos.  * <c>twitter_timeline</c> - Videos from the user's Twitter timeline.  * <c>uploads</c> - Uploaded videos.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Activity31Connection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFeedAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video in the authenticated user's feed.
    /// </remarks>
    public Task<Activity31Connection> GetFeedAlt1(string? offset,
        double? page,
        double? perPage,
        Type33? type,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/feed"),
            [],
            [new Param("offset", offset),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("type", type)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Activity31Connection>(),
            GetFeedAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
