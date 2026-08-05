using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The upload source of the text track.
/// <para>
/// Option descriptions:
///  * <c>autogen_alternate_audio</c> - The text track is automatically generated from alternate audio.
///  * <c>autogen_dubbed</c> - The text track is automatically generated from AI dubbing.
///  * <c>autogen_live_audio</c> - The text track is automatically generated from live audio.
///  * <c>autogen_source_audio</c> - The text track is automatically generated from source audio.
///  * <c>autogen_translated</c> - The text track is automatically generated from AI translation.
///  * <c>user_uploaded</c> - The text track is uploaded by a user.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Provenance1>))]
public sealed record Provenance1 : StringEnum<Provenance1>
{
    private Provenance1(string value) : base(value)
    {
    }

    public static readonly Provenance1 AutogenAlternateAudio = new("autogen_alternate_audio");

    public static readonly Provenance1 AutogenDubbed = new("autogen_dubbed");

    public static readonly Provenance1 AutogenLiveAudio = new("autogen_live_audio");

    public static readonly Provenance1 AutogenSourceAudio = new("autogen_source_audio");

    public static readonly Provenance1 AutogenTranslated = new("autogen_translated");

    public static readonly Provenance1 UserUploaded = new("user_uploaded");

    public static Provenance1 FromValue(string value) => FromValueCore(value);
}
