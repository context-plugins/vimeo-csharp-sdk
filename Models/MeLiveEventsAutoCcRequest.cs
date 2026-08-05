using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record MeLiveEventsAutoCcRequest
{
    /// <summary>
    /// Whether automated closed captions are enabled for the event.
    /// </summary>
    [JsonPropertyName("auto_cc_enabled")]
    public required bool AutoCcEnabled { get; init; }

    /// <summary>
    /// A comma-separated list of keywords that improve the quality of the automated closed captions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_cc_keywords")]
    public string? AutoCcKeywords { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_cc_lang")]
    public AutoCcLang1? AutoCcLang { get; init; }

    /// <summary>
    /// Whether automated caption translations are enabled for the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_cc_translation_enabled")]
    public bool? AutoCcTranslationEnabled { get; init; }

    /// <summary>
    /// The list of language codes for caption translations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_cc_translation_languages")]
    public IReadOnlyList<string>? AutoCcTranslationLanguages { get; init; }
}
