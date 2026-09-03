using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type29>))]
public sealed record Type29 : StringEnum<Type29>
{
    private Type29(string value) : base(value)
    {
    }

    public static readonly Type29 Appears = new("appears");

    public static readonly Type29 CategoryFeatured = new("category_featured");

    public static readonly Type29 Channel = new("channel");

    public static readonly Type29 FacebookFeed = new("facebook_feed");

    public static readonly Type29 Following = new("following");

    public static readonly Type29 Group = new("group");

    public static readonly Type29 Likes = new("likes");

    public static readonly Type29 OndemandPublish = new("ondemand_publish");

    public static readonly Type29 Share = new("share");

    public static readonly Type29 TaggedWith = new("tagged_with");

    public static readonly Type29 TwitterTimeline = new("twitter_timeline");

    public static readonly Type29 Uploads = new("uploads");

    public static Type29 FromValue(string value) => FromValueCore(value);
}
