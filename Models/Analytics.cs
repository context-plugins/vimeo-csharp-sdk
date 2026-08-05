using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Analytics
{
    /// <summary>
    /// The language of the audio track.
    /// </summary>
    [JsonPropertyName("audio_track_language")]
    public required string AudioTrackLanguage { get; init; }

    /// <summary>
    /// The provenance of the audio track.
    /// </summary>
    [JsonPropertyName("audio_track_provenance")]
    public required string AudioTrackProvenance { get; init; }

    /// <summary>
    /// The type of the audio track.
    /// </summary>
    [JsonPropertyName("audio_track_type")]
    public required string AudioTrackType { get; init; }

    /// <summary>
    /// The average percent watched in seconds of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("average_percent_watched")]
    public required double AveragePercentWatched { get; init; }

    /// <summary>
    /// The average time watched in seconds of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("average_time_watched")]
    public required double AverageTimeWatched { get; init; }

    /// <summary>
    /// The name of the browser.
    /// </summary>
    [JsonPropertyName("browser_name")]
    public required string BrowserName { get; init; }

    /// <summary>
    /// The name of the city.
    /// </summary>
    [JsonPropertyName("city_name")]
    public required string CityName { get; init; }

    /// <summary>
    /// The number of times that more than 95 percent of a video's content was played.
    /// </summary>
    [JsonPropertyName("completions")]
    public required double Completions { get; init; }

    [JsonPropertyName("country")]
    public required Country Country { get; init; }

    /// <summary>
    /// The country code in ISO-3166 format.
    /// </summary>
    [JsonPropertyName("country_code")]
    public required string CountryCode { get; init; }

    /// <summary>
    /// The name of the country.
    /// </summary>
    [JsonPropertyName("country_name")]
    public required string CountryName { get; init; }

    /// <summary>
    /// The type of device.
    /// </summary>
    [JsonPropertyName("device_type")]
    public required string DeviceType { get; init; }

    /// <summary>
    /// The number of downloads of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("downloads")]
    public required double Downloads { get; init; }

    /// <summary>
    /// The number of DRM licenses used. _This field is available only to users with the DRM feature._
    /// </summary>
    [JsonPropertyName("drm_licenses_used")]
    public required double DrmLicensesUsed { get; init; }

    /// <summary>
    /// The domain name of the website.
    /// </summary>
    [JsonPropertyName("embed_domain")]
    public required string EmbedDomain { get; init; }

    /// <summary>
    /// The path of the website URL.
    /// </summary>
    [JsonPropertyName("embed_domain_path")]
    public required string EmbedDomainPath { get; init; }

    /// <summary>
    /// The end time of the time interval in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("end_date")]
    public required string EndDate { get; init; }

    /// <summary>
    /// The number of finishes of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("finishes")]
    public required double Finishes { get; init; }

    /// <summary>
    /// The total number of five-star ranking clicks available in each video.
    /// </summary>
    [JsonPropertyName("five_star_clicks")]
    public required double FiveStarClicks { get; init; }

    /// <summary>
    /// The total number of four-star ranking clicks available in each video.
    /// </summary>
    [JsonPropertyName("four_star_clicks")]
    public required double FourStarClicks { get; init; }

    /// <summary>
    /// The number of impressions of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("impressions")]
    public required double Impressions { get; init; }

    /// <summary>
    /// The average percent watched in seconds of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("mean_percent_watched")]
    public required double MeanPercentWatched { get; init; }

    /// <summary>
    /// The average time watched in seconds of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("mean_seconds_watched")]
    public required double MeanSecondsWatched { get; init; }

    [JsonPropertyName("metadata")]
    public required Metadata12 Metadata { get; init; }

    /// <summary>
    /// The total number of one-star ranking clicks available in each video.
    /// </summary>
    [JsonPropertyName("one_star_clicks")]
    public required double OneStarClicks { get; init; }

    /// <summary>
    /// The name of the operating system.
    /// </summary>
    [JsonPropertyName("os_name")]
    public required string OsName { get; init; }

    /// <summary>
    /// The average ranking rating for ranking widget clicks in each video.
    /// </summary>
    [JsonPropertyName("ranking_widget_average_rating")]
    public required double RankingWidgetAverageRating { get; init; }

    /// <summary>
    /// The total number of ranking widget clicks available in each video.
    /// </summary>
    [JsonPropertyName("ranking_widget_clicks")]
    public required double RankingWidgetClicks { get; init; }

    /// <summary>
    /// The ISO 3166-2 region code.
    /// </summary>
    [JsonPropertyName("region_code")]
    public required string RegionCode { get; init; }

    /// <summary>
    /// The name of the region.
    /// </summary>
    [JsonPropertyName("region_name")]
    public required string RegionName { get; init; }

    /// <summary>
    /// The start time of the time interval in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("start_date")]
    public required string StartDate { get; init; }

    /// <summary>
    /// The streaming type of the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>live</c> - The video is streamed in real time.
    ///  * <c>non-live</c> - The video isn't streamed in real time.
    /// </para>
    /// </summary>
    [JsonPropertyName("streaming_type")]
    public required StreamingType StreamingType { get; init; }

    /// <summary>
    /// The language of the text track.
    /// </summary>
    [JsonPropertyName("text_track_language")]
    public required string TextTrackLanguage { get; init; }

    /// <summary>
    /// The provenance of the text track.
    /// </summary>
    [JsonPropertyName("text_track_provenance")]
    public required string TextTrackProvenance { get; init; }

    /// <summary>
    /// The type of the text track.
    /// </summary>
    [JsonPropertyName("text_track_type")]
    public required string TextTrackType { get; init; }

    /// <summary>
    /// The number of impressions from all non-Vimeo players.
    /// </summary>
    [JsonPropertyName("third_party_impressions")]
    public required double ThirdPartyImpressions { get; init; }

    /// <summary>
    /// The total number of three-star ranking clicks available in each video.
    /// </summary>
    [JsonPropertyName("three_star_clicks")]
    public required double ThreeStarClicks { get; init; }

    /// <summary>
    /// The total number of thumbs-down clicks available in each video.
    /// </summary>
    [JsonPropertyName("thumbs_down_clicks")]
    public required double ThumbsDownClicks { get; init; }

    /// <summary>
    /// The total number of thumbs-up clicks available in each video.
    /// </summary>
    [JsonPropertyName("thumbs_up_clicks")]
    public required double ThumbsUpClicks { get; init; }

    /// <summary>
    /// The average thumbs rating for thumbs widget clicks in each video.
    /// </summary>
    [JsonPropertyName("thumbs_widget_average_rating")]
    public required double ThumbsWidgetAverageRating { get; init; }

    /// <summary>
    /// The total number of thumbs widget clicks available in each video.
    /// </summary>
    [JsonPropertyName("thumbs_widget_clicks")]
    public required double ThumbsWidgetClicks { get; init; }

    /// <summary>
    /// The total time watched in seconds of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("total_seconds_watched")]
    public required double TotalSecondsWatched { get; init; }

    /// <summary>
    /// The number of seconds watched, including repeats of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("total_seconds_watched_including_repeats")]
    public required double TotalSecondsWatchedIncludingRepeats { get; init; }

    /// <summary>
    /// The total time watched in seconds of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("total_time_watched")]
    public required double TotalTimeWatched { get; init; }

    /// <summary>
    /// The total number of two-star ranking clicks available in each video.
    /// </summary>
    [JsonPropertyName("two_star_clicks")]
    public required double TwoStarClicks { get; init; }

    /// <summary>
    /// The number of unique impressions of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("unique_impressions")]
    public required double UniqueImpressions { get; init; }

    /// <summary>
    /// The number of unique viewers of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("unique_viewers")]
    public required double UniqueViewers { get; init; }

    /// <summary>
    /// The number of unique views of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("unique_views")]
    public required double UniqueViews { get; init; }

    /// <summary>
    /// The number of views of the corresponding Vimeo content.
    /// </summary>
    [JsonPropertyName("views")]
    public required double Views { get; init; }
}
