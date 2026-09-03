using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The language in which the automated closed captions appear.
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
[JsonConverter(typeof(StringEnumConverter<AutoCcLang1>))]
public sealed record AutoCcLang1 : StringEnum<AutoCcLang1>
{
    private AutoCcLang1(string value) : base(value)
    {
    }

    public static readonly AutoCcLang1 Af = new("af");

    public static readonly AutoCcLang1 Am = new("am");

    public static readonly AutoCcLang1 Ar = new("ar");

    public static readonly AutoCcLang1 As = new("as");

    public static readonly AutoCcLang1 Ast = new("ast");

    public static readonly AutoCcLang1 Az = new("az");

    public static readonly AutoCcLang1 Be = new("be");

    public static readonly AutoCcLang1 Bg = new("bg");

    public static readonly AutoCcLang1 Bn = new("bn");

    public static readonly AutoCcLang1 Bs = new("bs");

    public static readonly AutoCcLang1 Ca = new("ca");

    public static readonly AutoCcLang1 Ceb = new("ceb");

    public static readonly AutoCcLang1 Cs = new("cs");

    public static readonly AutoCcLang1 Cy = new("cy");

    public static readonly AutoCcLang1 Da = new("da");

    public static readonly AutoCcLang1 De = new("de");

    public static readonly AutoCcLang1 El = new("el");

    public static readonly AutoCcLang1 En = new("en");

    public static readonly AutoCcLang1 Es = new("es");

    public static readonly AutoCcLang1 Et = new("et");

    public static readonly AutoCcLang1 Fa = new("fa");

    public static readonly AutoCcLang1 Ff = new("ff");

    public static readonly AutoCcLang1 Fi = new("fi");

    public static readonly AutoCcLang1 Fil = new("fil");

    public static readonly AutoCcLang1 Fr = new("fr");

    public static readonly AutoCcLang1 Ga = new("ga");

    public static readonly AutoCcLang1 Gl = new("gl");

    public static readonly AutoCcLang1 Gu = new("gu");

    public static readonly AutoCcLang1 Ha = new("ha");

    public static readonly AutoCcLang1 He = new("he");

    public static readonly AutoCcLang1 Hi = new("hi");

    public static readonly AutoCcLang1 Hr = new("hr");

    public static readonly AutoCcLang1 Hu = new("hu");

    public static readonly AutoCcLang1 Hy = new("hy");

    public static readonly AutoCcLang1 Id = new("id");

    public static readonly AutoCcLang1 Ig = new("ig");

    public static readonly AutoCcLang1 Is = new("is");

    public static readonly AutoCcLang1 It = new("it");

    public static readonly AutoCcLang1 Ja = new("ja");

    public static readonly AutoCcLang1 Jv = new("jv");

    public static readonly AutoCcLang1 Ka = new("ka");

    public static readonly AutoCcLang1 Kea = new("kea");

    public static readonly AutoCcLang1 Kk = new("kk");

    public static readonly AutoCcLang1 Km = new("km");

    public static readonly AutoCcLang1 Kn = new("kn");

    public static readonly AutoCcLang1 Ko = new("ko");

    public static readonly AutoCcLang1 Ku = new("ku");

    public static readonly AutoCcLang1 Ky = new("ky");

    public static readonly AutoCcLang1 Lb = new("lb");

    public static readonly AutoCcLang1 Lg = new("lg");

    public static readonly AutoCcLang1 Ln = new("ln");

    public static readonly AutoCcLang1 Lo = new("lo");

    public static readonly AutoCcLang1 Lt = new("lt");

    public static readonly AutoCcLang1 Luo = new("luo");

    public static readonly AutoCcLang1 Lv = new("lv");

    public static readonly AutoCcLang1 Mi = new("mi");

    public static readonly AutoCcLang1 Mk = new("mk");

    public static readonly AutoCcLang1 Ml = new("ml");

    public static readonly AutoCcLang1 Mn = new("mn");

    public static readonly AutoCcLang1 Mr = new("mr");

    public static readonly AutoCcLang1 Ms = new("ms");

    public static readonly AutoCcLang1 Mt = new("mt");

    public static readonly AutoCcLang1 My = new("my");

    public static readonly AutoCcLang1 Ne = new("ne");

    public static readonly AutoCcLang1 Nl = new("nl");

    public static readonly AutoCcLang1 No = new("no");

    public static readonly AutoCcLang1 Nso = new("nso");

    public static readonly AutoCcLang1 Ny = new("ny");

    public static readonly AutoCcLang1 Oc = new("oc");

    public static readonly AutoCcLang1 Or = new("or");

    public static readonly AutoCcLang1 Pa = new("pa");

    public static readonly AutoCcLang1 Pl = new("pl");

    public static readonly AutoCcLang1 Ps = new("ps");

    public static readonly AutoCcLang1 Pt = new("pt");

    public static readonly AutoCcLang1 Ro = new("ro");

    public static readonly AutoCcLang1 Ru = new("ru");

    public static readonly AutoCcLang1 Sd = new("sd");

    public static readonly AutoCcLang1 Sk = new("sk");

    public static readonly AutoCcLang1 Sl = new("sl");

    public static readonly AutoCcLang1 Sn = new("sn");

    public static readonly AutoCcLang1 So = new("so");

    public static readonly AutoCcLang1 Sr = new("sr");

    public static readonly AutoCcLang1 Sv = new("sv");

    public static readonly AutoCcLang1 Sw = new("sw");

    public static readonly AutoCcLang1 Ta = new("ta");

    public static readonly AutoCcLang1 Te = new("te");

    public static readonly AutoCcLang1 Tg = new("tg");

    public static readonly AutoCcLang1 Th = new("th");

    public static readonly AutoCcLang1 Tr = new("tr");

    public static readonly AutoCcLang1 Uk = new("uk");

    public static readonly AutoCcLang1 Umb = new("umb");

    public static readonly AutoCcLang1 Ur = new("ur");

    public static readonly AutoCcLang1 Uz = new("uz");

    public static readonly AutoCcLang1 Vi = new("vi");

    public static readonly AutoCcLang1 Wo = new("wo");

    public static readonly AutoCcLang1 Xh = new("xh");

    public static readonly AutoCcLang1 Zh = new("zh");

    public static readonly AutoCcLang1 ZhHk = new("zh-HK");

    public static readonly AutoCcLang1 Zu = new("zu");

    public static AutoCcLang1 FromValue(string value) => FromValueCore(value);
}
