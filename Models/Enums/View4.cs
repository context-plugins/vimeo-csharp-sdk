using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The general privacy setting of the video.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can access the video. This privacy setting appears as <c>Public</c> on the Vimeo front end.
///  * <c>cold_storage</c> - The video is temporarily frozen because the owner exceeded their plan's storage limit. The video page renders with an in-player overlay.
///  * <c>contacts</c> - Only contacts can access the video. _This field is deprecated._
///  * <c>disable</c> - The video is hidden from Vimeo. This privacy setting appears as <c>Embed only</c> on the Vimeo front end.
///  * <c>nobody</c> - No one besides the owner can access the video. This privacy setting appears as <c>Private</c> on the Vimeo front end.
///  * <c>password</c> - Anyone with the video's password can access the video.
///  * <c>ptv</c> - The Vimeo On Demand video is accessible and searchable from Vimeo. _This field is deprecated._
///  * <c>ptvhide</c> - The Vimeo On Demand video is hidden from Vimeo. _This field is deprecated._
///  * <c>stock</c> - The stock footage is accessible and searchable from Vimeo. _This field is deprecated._
///  * <c>stock_purchased</c> - The purchased stock footage is accessible and searchable from Vimeo. _This field is deprecated._
///  * <c>team</c> - Anyone on the team can access the video. This privacy setting appears as <c>Company only</c> on the Vimeo front end.
///  * <c>unlisted</c> - The video is accessible but not searchable from Vimeo.
///  * <c>users</c> - Only Vimeo members can access the video. _This field is deprecated._
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<View4>))]
public sealed record View4 : StringEnum<View4>
{
    private View4(string value) : base(value)
    {
    }

    public static readonly View4 Anybody = new("anybody");

    public static readonly View4 ColdStorage = new("cold_storage");

    public static readonly View4 Contacts = new("contacts");

    public static readonly View4 Disable = new("disable");

    public static readonly View4 Nobody = new("nobody");

    public static readonly View4 Password = new("password");

    public static readonly View4 Ptv = new("ptv");

    public static readonly View4 Ptvhide = new("ptvhide");

    public static readonly View4 Stock = new("stock");

    public static readonly View4 StockPurchased = new("stock_purchased");

    public static readonly View4 Team = new("team");

    public static readonly View4 Unlisted = new("unlisted");

    public static readonly View4 Users = new("users");

    public static View4 FromValue(string value) => FromValueCore(value);
}
