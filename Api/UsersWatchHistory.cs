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

namespace VimeoApi.Api;

/// <summary>
/// Use these methods to work with a user's watch history.
/// </summary>
public sealed class UsersWatchHistory
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsersWatchHistory(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a specific video from the user's watch history
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified video from the authenticated user's watch history.
    /// </remarks>
    public Task DeleteFromWatchHistory(double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/watched/videos/{video_id}"),
            [new TemplateParam("video_id", videoId)],
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
    /// Delete the user's watch history
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the entire watch history of the authenticated user.
    /// </remarks>
    public Task DeleteWatchHistory(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/watched/videos"),
            [],
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
    /// Get all the videos that a user has watched
    /// </summary>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetWatchHistoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video on the authenticated user's watch history. _This endpoint is deprecated. Any request to it returns empty data with HTTP status code 200._
    /// </remarks>
    public Task<VideoConnection> GetWatchHistory(double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/watched/videos"),
            [],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetWatchHistoryErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
