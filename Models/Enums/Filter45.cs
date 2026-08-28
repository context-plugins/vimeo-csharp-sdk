using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter45>))]
public sealed record Filter45 : StringEnum<Filter45>
{
    private Filter45(string value) : base(value)
    {
    }

    public static readonly Filter45 Cc = new("CC");

    public static readonly Filter45 CcBy = new("CC-BY");

    public static readonly Filter45 CcByNc = new("CC-BY-NC");

    public static readonly Filter45 CcByNcNd = new("CC-BY-NC-ND");

    public static readonly Filter45 CcByNcSa = new("CC-BY-NC-SA");

    public static readonly Filter45 CcByNd = new("CC-BY-ND");

    public static readonly Filter45 CcBySa = new("CC-BY-SA");

    public static readonly Filter45 Cc0 = new("CC0");

    public static readonly Filter45 Categories = new("categories");

    public static readonly Filter45 Duration = new("duration");

    public static readonly Filter45 InProgress = new("in-progress");

    public static readonly Filter45 MinimumLikes = new("minimum_likes");

    public static readonly Filter45 Trending = new("trending");

    public static readonly Filter45 UploadDate = new("upload_date");

    public static Filter45 FromValue(string value) => FromValueCore(value);
}
