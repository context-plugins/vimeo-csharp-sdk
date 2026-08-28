using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The video's 360 spatial projection.
/// <para>
/// Option descriptions:
///  * <c>cubical</c> - The spatial projection is cubical.
///  * <c>cylindrical</c> - The spatial projection is cylindrical.
///  * <c>dome</c> - The spatial projection is dome-shaped.
///  * <c>equirectangular</c> - The spatial projection is equirectangular.
///  * <c>pyramid</c> - The spatial projection is pyramid-shaped.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Projection>))]
public sealed record Projection : StringEnum<Projection>
{
    private Projection(string value) : base(value)
    {
    }

    public static readonly Projection Cubical = new("cubical");

    public static readonly Projection Cylindrical = new("cylindrical");

    public static readonly Projection Dome = new("dome");

    public static readonly Projection Equirectangular = new("equirectangular");

    public static readonly Projection Pyramid = new("pyramid");

    public static Projection FromValue(string value) => FromValueCore(value);
}
