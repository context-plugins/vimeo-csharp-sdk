using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort22>))]
public sealed record Sort22 : StringEnum<Sort22>
{
    private Sort22(string value) : base(value)
    {
    }

    public static readonly Sort22 Comments = new("comments");

    public static readonly Sort22 Completions = new("completions");

    public static readonly Sort22 Country = new("country");

    public static readonly Sort22 Default = new("default");

    public static readonly Sort22 DeviceType = new("device_type");

    public static readonly Sort22 Downloads = new("downloads");

    public static readonly Sort22 DrmLicensesUsed = new("drm_licenses_used");

    public static readonly Sort22 EmbedDomain = new("embed_domain");

    public static readonly Sort22 Finishes = new("finishes");

    public static readonly Sort22 FiveStarClicks = new("five_star_clicks");

    public static readonly Sort22 FourStarClicks = new("four_star_clicks");

    public static readonly Sort22 Impressions = new("impressions");

    public static readonly Sort22 Like = new("like");

    public static readonly Sort22 MeanPercentWatched = new("mean_percent_watched");

    public static readonly Sort22 MeanSecondsWatched = new("mean_seconds_watched");

    public static readonly Sort22 OneStarClicks = new("one_star_clicks");

    public static readonly Sort22 RankingWidgetAverageRating = new("ranking_widget_average_rating");

    public static readonly Sort22 RankingWidgetClicks = new("ranking_widget_clicks");

    public static readonly Sort22 ThirdPartyImpressions = new("third_party_impressions");

    public static readonly Sort22 ThreeStarClicks = new("three_star_clicks");

    public static readonly Sort22 ThumbsDownClicks = new("thumbs_down_clicks");

    public static readonly Sort22 ThumbsUpClicks = new("thumbs_up_clicks");

    public static readonly Sort22 ThumbsWidgetAverageRating = new("thumbs_widget_average_rating");

    public static readonly Sort22 ThumbsWidgetClicks = new("thumbs_widget_clicks");

    public static readonly Sort22 Time = new("time");

    public static readonly Sort22 TotalSecondsWatched = new("total_seconds_watched");

    public static readonly Sort22 TwoStarClicks = new("two_star_clicks");

    public static readonly Sort22 UniqueImpressions = new("unique_impressions");

    public static readonly Sort22 UniqueViewers = new("unique_viewers");

    public static readonly Sort22 Video = new("video");

    public static readonly Sort22 Views = new("views");

    public static Sort22 FromValue(string value) => FromValueCore(value);
}
