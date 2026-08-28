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
/// Use these methods to work with videos on On Demand pages.
/// </summary>
public sealed class OnDemandVideos
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OnDemandVideos(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a video to an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandVideo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideoToVodError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a video to the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task<OnDemandVideo> AddVideoToVod(double ondemandId,
        double videoId,
        OndemandPagesVideosRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/videos/{video_id}"),
            [new TemplateParam("ondemand_id", ondemandId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<OnDemandVideo>(),
            AddVideoToVodErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a video from an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVideoFromVodError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes a video from the specified On Demand page. The authenticated user must be the owner of the page.
    /// </remarks>
    public Task DeleteVideoFromVod(double ondemandId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/videos/{video_id}"),
            [new TemplateParam("ondemand_id", ondemandId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteVideoFromVodErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific video on an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single video on the specified On Demand page. Use this method to determine whether the video is on the page.
    /// </remarks>
    public Task<Video> GetVodVideo(double ondemandId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/videos/{video_id}"),
            [new TemplateParam("ondemand_id", ondemandId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos on an On Demand page
    /// </summary>
    /// <param name="ondemandId">The ID of the On Demand page.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>all</c> - Filter for all videos.  * <c>buy</c> - Filter for purchased videos.  * <c>expiring_soon</c> - Filter for videos that expire soon.  * <c>extra</c> - Filter for extra footage videos.  * <c>main</c> - Filter for main videos.  * <c>main.viewable</c> - Filter for videos that are both the main video and are viewable.  * <c>rent</c> - Filter for rented videos.  * <c>trailer</c> - Filter for trailer videos.  * <c>unwatched</c> - Filter for unwatched videos.  * <c>viewable</c> - Filter for videos that are viewable.  * <c>watched</c> - Filter for watched videos.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>date</c> - Sort the results by date.  * <c>default</c> - Use the default sorting method.  * <c>episode</c> - Sort the results by episode.  * <c>manual</c> - Sort the results manually.  * <c>name</c> - Sort the results by name.  * <c>purchase_time</c> - Sort the results by time of purchase.  * <c>release_date</c> - Sort the results by release date.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnDemandVideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video on the specified On Demand page.
    /// </remarks>
    public Task<OnDemandVideoConnection> GetVodVideos(double ondemandId,
        Direction? direction,
        Filter29? filter,
        double? page,
        double? perPage,
        Sort45? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ondemand/pages/{ondemand_id}/videos"),
            [new TemplateParam("ondemand_id", ondemandId)],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnDemandVideoConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
