using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type33>))]
public sealed record Type33 : StringEnum<Type33>
{
    private Type33(string value) : base(value)
    {
    }

    public static readonly Type33 Appears = new("appears");

    public static readonly Type33 CategoryFeatured = new("category_featured");

    public static readonly Type33 Channel = new("channel");

    public static readonly Type33 FacebookFeed = new("facebook_feed");

    public static readonly Type33 Following = new("following");

    public static readonly Type33 Group = new("group");

    public static readonly Type33 Likes = new("likes");

    public static readonly Type33 OndemandPublish = new("ondemand_publish");

    public static readonly Type33 Share = new("share");

    public static readonly Type33 TaggedWith = new("tagged_with");

    public static readonly Type33 TwitterTimeline = new("twitter_timeline");

    public static readonly Type33 Uploads = new("uploads");

    public static Type33 FromValue(string value) => FromValueCore(value);
}
