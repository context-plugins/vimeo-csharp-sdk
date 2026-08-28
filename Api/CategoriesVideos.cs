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
/// Use these methods to work with videos in a category.
/// </summary>
public sealed class CategoriesVideos
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CategoriesVideos(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a specific video in a category
    /// </summary>
    /// <param name="category">The name of the category.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Video"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckCategoryForVideoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single video in the specified category. You can use this method to determine whether the video belongs to the category.
    /// </remarks>
    public Task<Video> CheckCategoryForVideo(string category,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/categories/{category}/videos/{video_id}"),
            [new TemplateParam("category", category), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Video>(),
            CheckCategoryForVideoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the videos in a category
    /// </summary>
    /// <param name="category">The name of the category.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>conditional_featured</c> - Return featured videos.  * <c>embeddable</c> - Return embeddable videos.</param>
    /// <param name="filterEmbeddable">Whether to filter the results by embeddable videos (<c>true</c>) or non-embeddable videos (<c>false</c>). This parameter is required only when <b>filter</b> is <c>embeddable</c>.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>comments</c> - Sort the results by number of comments.  * <c>date</c> - Sort the results by date.  * <c>duration</c> - Sort the results by duration.  * <c>featured</c> - Sort the results by featured status.  * <c>likes</c> - Sort the results by number of likes.  * <c>plays</c> - Sort the results by number of plays.  * <c>relevant</c> - Sort the results by relevance.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VideoConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCategoryVideosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every video that belongs to the specified category.
    /// </remarks>
    public Task<VideoConnection> GetCategoryVideos(string category,
        Direction? direction,
        Filter? filter,
        bool? filterEmbeddable,
        double? page,
        double? perPage,
        string? query,
        Sort6? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/categories/{category}/videos"),
            [new TemplateParam("category", category)],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("filter_embeddable", filterEmbeddable),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VideoConnection>(),
            GetCategoryVideosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the categories to which a video belongs
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CategoryConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVideoCategoriesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every category that contains the specified video.
    /// </remarks>
    public Task<CategoryConnection> GetVideoCategories(double videoId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/categories"),
            [new TemplateParam("video_id", videoId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CategoryConnection>(),
            GetVideoCategoriesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Set categories for a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Category"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SuggestVideoCategoryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method sets multiple categories and subcategories for the specified video. Include the categories as a JSON block in the body of the request using the <b>category</b> field, like this: <c>[{ "category": "Tech" }, { "category": "Music" }]</c>. The authenticated user must have edit access to the video. For more information on batch requests like this one, see <see href="https://developer.vimeo.com/api/common-formats#working-with-batch-requests">Using Common Formats and Parameters</see>.
    /// </remarks>
    public Task<Category> SuggestVideoCategory(double videoId,
        VideosCategoriesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/categories"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<Category>(),
            SuggestVideoCategoryErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
