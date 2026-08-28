using System.Collections.Generic;
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
using Vimeo.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Api;

/// <summary>
/// Use these methods to work with the authenticated user's video analytics.
/// </summary>
public sealed class UsersAnalytics
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsersAnalytics(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get video analytics for the authenticated user
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="dimension">The data dimension by which to group the results.  Option descriptions:  * <c>browser</c> - Group the results by browser.  * <c>city</c> - Group the results by city.  * <c>country</c> - Group the results by country.  * <c>device_type</c> - Group the results by device type.  * <c>embed_domain</c> - Group the results by embed domain.  * <c>embed_domain_path</c> - Group the results by embed domain path.  * <c>os</c> - Group the results by operating system.  * <c>region</c> - Group the results by region.  * <c>streaming_type</c> - Group the results by streaming type.  * <c>total</c> - Group the results by the time range provided.  * <c>video</c> - Group the results by video.</param>
    /// <param name="from">The start date of the range of results in ISO 8601 format.</param>
    /// <param name="to">The end date of the range of results in ISO 8601 format.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filterContent">A comma-separated list of video, folder, or event URIs to filter.</param>
    /// <param name="filterCountries">A comma-separated list of country codes in ISO-3166 format to filter on.</param>
    /// <param name="filterCustomMetadata">A JSON-encoded custom-metadata filter. Accepts either a bare list of clauses (combined with <c>and</c>) or an envelope <c>{"logic":"and"|"or","clauses":[...]}</c>. Each clause is an object with <c>field_id</c> (integer; matches one of the owning team's <c>CustomMetadataSettings</c> fields), <c>operator</c> (one of <c>eq</c>, <c>ne</c>, <c>gt</c>, <c>lt</c>, <c>contains</c>, <c>not_contains</c>, <c>empty</c>, <c>not_empty</c>; the allowed operators depend on the field type), and optional <c>value</c> (string; required for every operator except <c>empty</c>/<c>not_empty</c>). The matching videos are resolved via the search index and intersected with <c>filter_content</c> before being passed to the analytics service.</param>
    /// <param name="filterDeviceTypes">A comma-separated list of device types to filter on.</param>
    /// <param name="filterEmbedDomains">A comma-separated list of domain names to filter on.</param>
    /// <param name="filterRegions">A comma-separated list of combined country and region codes in ISO-3166 format to filter on.</param>
    /// <param name="filterStreamingTypes">A comma-separated list of streaming types to filter on.</param>
    /// <param name="filterWorkspaces">A comma-separated list of workspace IDs to filter for.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The maximum number of items returned from the request, up to a limit of 1000 items. The default value is <c>50</c>.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>comments</c> - Sort the results by the number of comments.  * <c>completions</c> - Sort the results by number of completions.  * <c>country</c> - Sort the results by country.  * <c>default</c> - Sort the results by the values of both the <b>dimension</b> and <b>time_interval</b> fields.  * <c>device_type</c> - Sort the results by device type.  * <c>downloads</c> - Sort the results by the number of downloads.  * <c>drm_licenses_used</c> - Sort the results by the number of DRM licenses used. _This option is available only to users with the DRM feature._  * <c>embed_domain</c> - Sort the results by embed domain.  * <c>finishes</c> - Sort the results by the number of complete plays.  * <c>five_star_clicks</c> - Sort the results by the number of five-star ranking clicks.  * <c>four_star_clicks</c> - Sort the results by the number of four-star ranking clicks.  * <c>impressions</c> - Sort the results by the number of impressions.  * <c>like</c> - Sort the results by the number of likes.  * <c>mean_percent_watched</c> - Sort the results by mean percentage played.  * <c>mean_seconds_watched</c> - Sort the results by mean seconds played.  * <c>one_star_clicks</c> - Sort the results by the number of one-star ranking clicks.  * <c>ranking_widget_average_rating</c> - Sort the results by the average ranking widget rating.  * <c>ranking_widget_clicks</c> - Sort the results by the number of ranking widget clicks.  * <c>third_party_impressions</c> - Sort the results by the number of impressions from all non-Vimeo players.  * <c>three_star_clicks</c> - Sort the results by the number of three-star ranking clicks.  * <c>thumbs_down_clicks</c> - Sort the results by the number of thumbs-down clicks.  * <c>thumbs_up_clicks</c> - Sort the results by the number of thumbs-up clicks.  * <c>thumbs_widget_average_rating</c> - Sort the results by the average thumbs widget rating.  * <c>thumbs_widget_clicks</c> - Sort the results by the number of thumbs widget clicks.  * <c>time</c> - Sort the results by the value of the <b>start_date</b> field. This option is available only when the value of <b>time_interval</b> isn't <c>none</c>.  * <c>total_seconds_watched</c> - Sort the results by total seconds played.  * <c>two_star_clicks</c> - Sort the results by the number of two-star ranking clicks.  * <c>unique_impressions</c> - Sort the results by unique impressions.  * <c>unique_viewers</c> - Sort the results by unique viewers.  * <c>video</c> - Sort the results by video ID.  * <c>views</c> - Sort the results by the number of views.</param>
    /// <param name="timeInterval">The interval by which to aggregate the data according to the specified data dimension. The default value is <c>none</c>. This parameter works only when the value of <b>dimension</b> is <c>video</c>, <c>country</c>, <c>embed_domain</c>, <c>device_type</c>, or <c>streaming_type</c>.  Option descriptions:  * <c>day</c> - Aggregate the results by day according to the specified data dimension.  * <c>month</c> - Aggregate the results by month according to the specified data dimension.  * <c>none</c> - The results are not aggregated by time interval.  * <c>week</c> - Aggregate the results by week according to the specified data dimension.  * <c>year</c> - Aggregate the results by year according to the specified data dimension.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AnalyticsConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns video analytics for the authenticated user's Vimeo account.
    /// </remarks>
    public Task<AnalyticsConnection> GetUserAnalytics(double userId,
        Dimension dimension,
        string from,
        string to,
        Direction? direction,
        string? filterContent,
        IReadOnlyList<string>? filterCountries,
        string? filterCustomMetadata,
        IReadOnlyList<string>? filterDeviceTypes,
        IReadOnlyList<string>? filterEmbedDomains,
        IReadOnlyList<string>? filterRegions,
        IReadOnlyList<string>? filterStreamingTypes,
        string? filterWorkspaces,
        double? page,
        double? perPage,
        Sort22? sort,
        TimeInterval? timeInterval,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/analytics"),
            [new TemplateParam("user_id", userId)],
            [new Param("dimension", dimension),
                new Param("from", from),
                new Param("to", to),
                new Param("direction", direction),
                new Param("filter_content", filterContent),
                new Param("filter_countries", filterCountries),
                new Param("filter_custom_metadata", filterCustomMetadata),
                new Param("filter_device_types", filterDeviceTypes),
                new Param("filter_embed_domains", filterEmbedDomains),
                new Param("filter_regions", filterRegions),
                new Param("filter_streaming_types", filterStreamingTypes),
                new Param("filter_workspaces", filterWorkspaces),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort),
                new Param("time_interval", timeInterval)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AnalyticsConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get video analytics for the authenticated user
    /// </summary>
    /// <param name="dimension">The data dimension by which to group the results.  Option descriptions:  * <c>browser</c> - Group the results by browser.  * <c>city</c> - Group the results by city.  * <c>country</c> - Group the results by country.  * <c>device_type</c> - Group the results by device type.  * <c>embed_domain</c> - Group the results by embed domain.  * <c>embed_domain_path</c> - Group the results by embed domain path.  * <c>os</c> - Group the results by operating system.  * <c>region</c> - Group the results by region.  * <c>streaming_type</c> - Group the results by streaming type.  * <c>total</c> - Group the results by the time range provided.  * <c>video</c> - Group the results by video.</param>
    /// <param name="from">The start date of the range of results in ISO 8601 format.</param>
    /// <param name="to">The end date of the range of results in ISO 8601 format.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filterContent">A comma-separated list of video, folder, or event URIs to filter.</param>
    /// <param name="filterCountries">A comma-separated list of country codes in ISO-3166 format to filter on.</param>
    /// <param name="filterCustomMetadata">A JSON-encoded custom-metadata filter. Accepts either a bare list of clauses (combined with <c>and</c>) or an envelope <c>{"logic":"and"|"or","clauses":[...]}</c>. Each clause is an object with <c>field_id</c> (integer; matches one of the owning team's <c>CustomMetadataSettings</c> fields), <c>operator</c> (one of <c>eq</c>, <c>ne</c>, <c>gt</c>, <c>lt</c>, <c>contains</c>, <c>not_contains</c>, <c>empty</c>, <c>not_empty</c>; the allowed operators depend on the field type), and optional <c>value</c> (string; required for every operator except <c>empty</c>/<c>not_empty</c>). The matching videos are resolved via the search index and intersected with <c>filter_content</c> before being passed to the analytics service.</param>
    /// <param name="filterDeviceTypes">A comma-separated list of device types to filter on.</param>
    /// <param name="filterEmbedDomains">A comma-separated list of domain names to filter on.</param>
    /// <param name="filterRegions">A comma-separated list of combined country and region codes in ISO-3166 format to filter on.</param>
    /// <param name="filterStreamingTypes">A comma-separated list of streaming types to filter on.</param>
    /// <param name="filterWorkspaces">A comma-separated list of workspace IDs to filter for.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The maximum number of items returned from the request, up to a limit of 1000 items. The default value is <c>50</c>.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>comments</c> - Sort the results by the number of comments.  * <c>completions</c> - Sort the results by number of completions.  * <c>country</c> - Sort the results by country.  * <c>default</c> - Sort the results by the values of both the <b>dimension</b> and <b>time_interval</b> fields.  * <c>device_type</c> - Sort the results by device type.  * <c>downloads</c> - Sort the results by the number of downloads.  * <c>drm_licenses_used</c> - Sort the results by the number of DRM licenses used. _This option is available only to users with the DRM feature._  * <c>embed_domain</c> - Sort the results by embed domain.  * <c>finishes</c> - Sort the results by the number of complete plays.  * <c>five_star_clicks</c> - Sort the results by the number of five-star ranking clicks.  * <c>four_star_clicks</c> - Sort the results by the number of four-star ranking clicks.  * <c>impressions</c> - Sort the results by the number of impressions.  * <c>like</c> - Sort the results by the number of likes.  * <c>mean_percent_watched</c> - Sort the results by mean percentage played.  * <c>mean_seconds_watched</c> - Sort the results by mean seconds played.  * <c>one_star_clicks</c> - Sort the results by the number of one-star ranking clicks.  * <c>ranking_widget_average_rating</c> - Sort the results by the average ranking widget rating.  * <c>ranking_widget_clicks</c> - Sort the results by the number of ranking widget clicks.  * <c>third_party_impressions</c> - Sort the results by the number of impressions from all non-Vimeo players.  * <c>three_star_clicks</c> - Sort the results by the number of three-star ranking clicks.  * <c>thumbs_down_clicks</c> - Sort the results by the number of thumbs-down clicks.  * <c>thumbs_up_clicks</c> - Sort the results by the number of thumbs-up clicks.  * <c>thumbs_widget_average_rating</c> - Sort the results by the average thumbs widget rating.  * <c>thumbs_widget_clicks</c> - Sort the results by the number of thumbs widget clicks.  * <c>time</c> - Sort the results by the value of the <b>start_date</b> field. This option is available only when the value of <b>time_interval</b> isn't <c>none</c>.  * <c>total_seconds_watched</c> - Sort the results by total seconds played.  * <c>two_star_clicks</c> - Sort the results by the number of two-star ranking clicks.  * <c>unique_impressions</c> - Sort the results by unique impressions.  * <c>unique_viewers</c> - Sort the results by unique viewers.  * <c>video</c> - Sort the results by video ID.  * <c>views</c> - Sort the results by the number of views.</param>
    /// <param name="timeInterval">The interval by which to aggregate the data according to the specified data dimension. The default value is <c>none</c>. This parameter works only when the value of <b>dimension</b> is <c>video</c>, <c>country</c>, <c>embed_domain</c>, <c>device_type</c>, or <c>streaming_type</c>.  Option descriptions:  * <c>day</c> - Aggregate the results by day according to the specified data dimension.  * <c>month</c> - Aggregate the results by month according to the specified data dimension.  * <c>none</c> - The results are not aggregated by time interval.  * <c>week</c> - Aggregate the results by week according to the specified data dimension.  * <c>year</c> - Aggregate the results by year according to the specified data dimension.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AnalyticsConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns video analytics for the authenticated user's Vimeo account.
    /// </remarks>
    public Task<AnalyticsConnection> GetUserAnalyticsAlt1(Dimension dimension,
        string from,
        string to,
        Direction? direction,
        string? filterContent,
        IReadOnlyList<string>? filterCountries,
        string? filterCustomMetadata,
        IReadOnlyList<string>? filterDeviceTypes,
        IReadOnlyList<string>? filterEmbedDomains,
        IReadOnlyList<string>? filterRegions,
        IReadOnlyList<string>? filterStreamingTypes,
        string? filterWorkspaces,
        double? page,
        double? perPage,
        Sort22? sort,
        TimeInterval? timeInterval,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/analytics"),
            [],
            [new Param("dimension", dimension),
                new Param("from", from),
                new Param("to", to),
                new Param("direction", direction),
                new Param("filter_content", filterContent),
                new Param("filter_countries", filterCountries),
                new Param("filter_custom_metadata", filterCustomMetadata),
                new Param("filter_device_types", filterDeviceTypes),
                new Param("filter_embed_domains", filterEmbedDomains),
                new Param("filter_regions", filterRegions),
                new Param("filter_streaming_types", filterStreamingTypes),
                new Param("filter_workspaces", filterWorkspaces),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort),
                new Param("time_interval", timeInterval)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AnalyticsConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
