using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The activity type.
/// <para>
/// Option descriptions:
///  * <c>appearance</c> - The activity is an appearance action.
///  * <c>category</c> - The activity is a category action.
///  * <c>channel</c> - The activity is a channel action.
///  * <c>facebook_feed</c> - The activity is a Facebook feed action.
///  * <c>group</c> - The activity is a group action.
///  * <c>like</c> - The activity is a like action.
///  * <c>ondemand</c> - The activity is a Vimeo On Demand action.
///  * <c>share</c> - The activity is a share action.
///  * <c>tag</c> - The activity is a tag action.
///  * <c>twitter_timeline</c> - The activity is a Twitter timeline action.
///  * <c>upload</c> - The activity is an upload action.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type10>))]
public sealed record Type10 : StringEnum<Type10>
{
    private Type10(string value) : base(value)
    {
    }

    public static readonly Type10 Appearance = new("appearance");

    public static readonly Type10 Category = new("category");

    public static readonly Type10 Channel = new("channel");

    public static readonly Type10 FacebookFeed = new("facebook_feed");

    public static readonly Type10 Group = new("group");

    public static readonly Type10 Like = new("like");

    public static readonly Type10 Ondemand = new("ondemand");

    public static readonly Type10 Share = new("share");

    public static readonly Type10 Tag = new("tag");

    public static readonly Type10 TwitterTimeline = new("twitter_timeline");

    public static readonly Type10 Upload = new("upload");

    public static Type10 FromValue(string value) => FromValueCore(value);
}
