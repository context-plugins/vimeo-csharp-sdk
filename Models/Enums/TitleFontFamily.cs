using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The selected video title font family.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TitleFontFamily>))]
public sealed record TitleFontFamily : StringEnum<TitleFontFamily>
{
    private TitleFontFamily(string value) : base(value)
    {
    }

    public static readonly TitleFontFamily Anton = new("anton");

    public static readonly TitleFontFamily ArchivoBlack = new("archivo_black");

    public static readonly TitleFontFamily BebasNeue = new("bebas_neue");

    public static readonly TitleFontFamily BricolageGrotesque = new("bricolage_grotesque");

    public static readonly TitleFontFamily Caveat = new("caveat");

    public static readonly TitleFontFamily DmSans = new("dm_sans");

    public static readonly TitleFontFamily DmSerifDisplay = new("dm_serif_display");

    public static readonly TitleFontFamily Fraunces = new("fraunces");

    public static readonly TitleFontFamily HankenGrotesk = new("hanken_grotesk");

    public static readonly TitleFontFamily IbmPlexSerif = new("ibm_plex_serif");

    public static readonly TitleFontFamily InstrumentSerif = new("instrument_serif");

    public static readonly TitleFontFamily Inter = new("inter");

    public static readonly TitleFontFamily JetbrainsMono = new("jetbrains_mono");

    public static readonly TitleFontFamily Lora = new("lora");

    public static readonly TitleFontFamily Montserrat = new("montserrat");

    public static readonly TitleFontFamily Outfit = new("outfit");

    public static readonly TitleFontFamily PlayfairDisplay = new("playfair_display");

    public static readonly TitleFontFamily Poppins = new("poppins");

    public static readonly TitleFontFamily Roboto = new("roboto");

    public static readonly TitleFontFamily SpaceGrotesk = new("space_grotesk");

    public static TitleFontFamily FromValue(string value) => FromValueCore(value);
}
