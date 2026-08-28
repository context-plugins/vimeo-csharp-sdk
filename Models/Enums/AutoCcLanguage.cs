using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The language of the automated closed captions.
/// <para>
/// Option descriptions:
///  * <c>af</c> - The language is Afrikaans.
///  * <c>am</c> - The language is Amharic.
///  * <c>ar</c> - The language is Arabic.
///  * <c>as</c> - The language is Assamese.
///  * <c>ast</c> - The language is Asturian.
///  * <c>az</c> - The language is Azerbaijani.
///  * <c>be</c> - The language is Belarusian.
///  * <c>bg</c> - The language is Bulgarian.
///  * <c>bn</c> - The language is Bengali.
///  * <c>bs</c> - The language is Bosnian.
///  * <c>ca</c> - The language is Catalan.
///  * <c>ceb</c> - The language is Cebuano.
///  * <c>cs</c> - The language is Czech.
///  * <c>cy</c> - The language is Welsh.
///  * <c>da</c> - The language is Danish.
///  * <c>de</c> - The language is German.
///  * <c>el</c> - The language is Greek.
///  * <c>en</c> - The language is English.
///  * <c>es</c> - The language is Spanish.
///  * <c>et</c> - The language is Estonian.
///  * <c>fa</c> - The language is Persian.
///  * <c>ff</c> - The language is Fulah.
///  * <c>fi</c> - The language is Finnish.
///  * <c>fil</c> - The language is Filipino.
///  * <c>fr</c> - The language is French.
///  * <c>ga</c> - The language is Irish.
///  * <c>gl</c> - The language is Galician.
///  * <c>gu</c> - The language is Gujarati.
///  * <c>ha</c> - The language is Hausa.
///  * <c>he</c> - The language is Hebrew.
///  * <c>hi</c> - The language is Hindi.
///  * <c>hr</c> - The language is Croatian.
///  * <c>hu</c> - The language is Hungarian.
///  * <c>hy</c> - The language is Armenian.
///  * <c>id</c> - The language is Indonesian.
///  * <c>ig</c> - The language is Igbo.
///  * <c>is</c> - The language is Icelandic.
///  * <c>it</c> - The language is Italian.
///  * <c>ja</c> - The language is Japanese.
///  * <c>jv</c> - The language is Javanese.
///  * <c>ka</c> - The language is Georgian.
///  * <c>kea</c> - The language is Kabuverdianu.
///  * <c>kk</c> - The language is Kazakh.
///  * <c>km</c> - The language is Khmer.
///  * <c>kn</c> - The language is Kannada.
///  * <c>ko</c> - The language is Korean.
///  * <c>ku</c> - The language is Kurdish.
///  * <c>ky</c> - The language is Kyrgyz.
///  * <c>lb</c> - The language is Luxembourgish.
///  * <c>lg</c> - The language is Ganda.
///  * <c>ln</c> - The language is Lingala.
///  * <c>lo</c> - The language is Lao.
///  * <c>lt</c> - The language is Lithuanian.
///  * <c>luo</c> - The language is Luo.
///  * <c>lv</c> - The language is Latvian.
///  * <c>mi</c> - The language is Maori.
///  * <c>mk</c> - The language is Macedonian.
///  * <c>ml</c> - The language is Malayalam.
///  * <c>mn</c> - The language is Mongolian.
///  * <c>mr</c> - The language is Marathi.
///  * <c>ms</c> - The language is Malay.
///  * <c>mt</c> - The language is Maltese.
///  * <c>my</c> - The language is Burmese.
///  * <c>ne</c> - The language is Nepali.
///  * <c>nl</c> - The language is Dutch.
///  * <c>no</c> - The language is Norwegian.
///  * <c>nso</c> - The language is Northern Sotho.
///  * <c>ny</c> - The language is Nyanja.
///  * <c>oc</c> - The language is Occitan.
///  * <c>or</c> - The language is Odia.
///  * <c>pa</c> - The language is Punjabi.
///  * <c>pl</c> - The language is Polish.
///  * <c>ps</c> - The language is Pashto.
///  * <c>pt</c> - The language is Portuguese.
///  * <c>ro</c> - The language is Romanian.
///  * <c>ru</c> - The language is Russian.
///  * <c>sd</c> - The language is Sindhi.
///  * <c>sk</c> - The language is Slovak.
///  * <c>sl</c> - The language is Slovenian.
///  * <c>sn</c> - The language is Shona.
///  * <c>so</c> - The language is Somali.
///  * <c>sr</c> - The language is Serbian.
///  * <c>sv</c> - The language is Swedish.
///  * <c>sw</c> - The language is Swahili.
///  * <c>ta</c> - The language is Tamil.
///  * <c>te</c> - The language is Telugu.
///  * <c>tg</c> - The language is Tajik.
///  * <c>th</c> - The language is Thai.
///  * <c>tr</c> - The language is Turkish.
///  * <c>uk</c> - The language is Ukrainian.
///  * <c>umb</c> - The language is Umbundu.
///  * <c>ur</c> - The language is Urdu.
///  * <c>uz</c> - The language is Uzbek.
///  * <c>vi</c> - The language is Vietnamese.
///  * <c>wo</c> - The language is Wolof.
///  * <c>xh</c> - The language is Xhosa.
///  * <c>zh</c> - The language is Chinese.
///  * <c>zh-HK</c> - The language is Cantonese (Hong Kong).
///  * <c>zu</c> - The language is Zulu.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AutoCcLanguage>))]
public sealed record AutoCcLanguage : StringEnum<AutoCcLanguage>
{
    private AutoCcLanguage(string value) : base(value)
    {
    }

    public static readonly AutoCcLanguage Af = new("af");

    public static readonly AutoCcLanguage Am = new("am");

    public static readonly AutoCcLanguage Ar = new("ar");

    public static readonly AutoCcLanguage As = new("as");

    public static readonly AutoCcLanguage Ast = new("ast");

    public static readonly AutoCcLanguage Az = new("az");

    public static readonly AutoCcLanguage Be = new("be");

    public static readonly AutoCcLanguage Bg = new("bg");

    public static readonly AutoCcLanguage Bn = new("bn");

    public static readonly AutoCcLanguage Bs = new("bs");

    public static readonly AutoCcLanguage Ca = new("ca");

    public static readonly AutoCcLanguage Ceb = new("ceb");

    public static readonly AutoCcLanguage Cs = new("cs");

    public static readonly AutoCcLanguage Cy = new("cy");

    public static readonly AutoCcLanguage Da = new("da");

    public static readonly AutoCcLanguage De = new("de");

    public static readonly AutoCcLanguage El = new("el");

    public static readonly AutoCcLanguage En = new("en");

    public static readonly AutoCcLanguage Es = new("es");

    public static readonly AutoCcLanguage Et = new("et");

    public static readonly AutoCcLanguage Fa = new("fa");

    public static readonly AutoCcLanguage Ff = new("ff");

    public static readonly AutoCcLanguage Fi = new("fi");

    public static readonly AutoCcLanguage Fil = new("fil");

    public static readonly AutoCcLanguage Fr = new("fr");

    public static readonly AutoCcLanguage Ga = new("ga");

    public static readonly AutoCcLanguage Gl = new("gl");

    public static readonly AutoCcLanguage Gu = new("gu");

    public static readonly AutoCcLanguage Ha = new("ha");

    public static readonly AutoCcLanguage He = new("he");

    public static readonly AutoCcLanguage Hi = new("hi");

    public static readonly AutoCcLanguage Hr = new("hr");

    public static readonly AutoCcLanguage Hu = new("hu");

    public static readonly AutoCcLanguage Hy = new("hy");

    public static readonly AutoCcLanguage Id = new("id");

    public static readonly AutoCcLanguage Ig = new("ig");

    public static readonly AutoCcLanguage Is = new("is");

    public static readonly AutoCcLanguage It = new("it");

    public static readonly AutoCcLanguage Ja = new("ja");

    public static readonly AutoCcLanguage Jv = new("jv");

    public static readonly AutoCcLanguage Ka = new("ka");

    public static readonly AutoCcLanguage Kea = new("kea");

    public static readonly AutoCcLanguage Kk = new("kk");

    public static readonly AutoCcLanguage Km = new("km");

    public static readonly AutoCcLanguage Kn = new("kn");

    public static readonly AutoCcLanguage Ko = new("ko");

    public static readonly AutoCcLanguage Ku = new("ku");

    public static readonly AutoCcLanguage Ky = new("ky");

    public static readonly AutoCcLanguage Lb = new("lb");

    public static readonly AutoCcLanguage Lg = new("lg");

    public static readonly AutoCcLanguage Ln = new("ln");

    public static readonly AutoCcLanguage Lo = new("lo");

    public static readonly AutoCcLanguage Lt = new("lt");

    public static readonly AutoCcLanguage Luo = new("luo");

    public static readonly AutoCcLanguage Lv = new("lv");

    public static readonly AutoCcLanguage Mi = new("mi");

    public static readonly AutoCcLanguage Mk = new("mk");

    public static readonly AutoCcLanguage Ml = new("ml");

    public static readonly AutoCcLanguage Mn = new("mn");

    public static readonly AutoCcLanguage Mr = new("mr");

    public static readonly AutoCcLanguage Ms = new("ms");

    public static readonly AutoCcLanguage Mt = new("mt");

    public static readonly AutoCcLanguage My = new("my");

    public static readonly AutoCcLanguage Ne = new("ne");

    public static readonly AutoCcLanguage Nl = new("nl");

    public static readonly AutoCcLanguage No = new("no");

    public static readonly AutoCcLanguage Nso = new("nso");

    public static readonly AutoCcLanguage Ny = new("ny");

    public static readonly AutoCcLanguage Oc = new("oc");

    public static readonly AutoCcLanguage Or = new("or");

    public static readonly AutoCcLanguage Pa = new("pa");

    public static readonly AutoCcLanguage Pl = new("pl");

    public static readonly AutoCcLanguage Ps = new("ps");

    public static readonly AutoCcLanguage Pt = new("pt");

    public static readonly AutoCcLanguage Ro = new("ro");

    public static readonly AutoCcLanguage Ru = new("ru");

    public static readonly AutoCcLanguage Sd = new("sd");

    public static readonly AutoCcLanguage Sk = new("sk");

    public static readonly AutoCcLanguage Sl = new("sl");

    public static readonly AutoCcLanguage Sn = new("sn");

    public static readonly AutoCcLanguage So = new("so");

    public static readonly AutoCcLanguage Sr = new("sr");

    public static readonly AutoCcLanguage Sv = new("sv");

    public static readonly AutoCcLanguage Sw = new("sw");

    public static readonly AutoCcLanguage Ta = new("ta");

    public static readonly AutoCcLanguage Te = new("te");

    public static readonly AutoCcLanguage Tg = new("tg");

    public static readonly AutoCcLanguage Th = new("th");

    public static readonly AutoCcLanguage Tr = new("tr");

    public static readonly AutoCcLanguage Uk = new("uk");

    public static readonly AutoCcLanguage Umb = new("umb");

    public static readonly AutoCcLanguage Ur = new("ur");

    public static readonly AutoCcLanguage Uz = new("uz");

    public static readonly AutoCcLanguage Vi = new("vi");

    public static readonly AutoCcLanguage Wo = new("wo");

    public static readonly AutoCcLanguage Xh = new("xh");

    public static readonly AutoCcLanguage Zh = new("zh");

    public static readonly AutoCcLanguage ZhHk = new("zh-HK");

    public static readonly AutoCcLanguage Zu = new("zu");

    public static AutoCcLanguage FromValue(string value) => FromValueCore(value);
}
