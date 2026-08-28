using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The 360 spatial projection.
/// <para>
/// Option descriptions:
///  * <c>cubical</c> - Use cubical projection.
///  * <c>cylindrical</c> - Use cylindrical projection.
///  * <c>dome</c> - Use dome projection.
///  * <c>equirectangular</c> - Use equirectangular projection.
///  * <c>pyramid</c> - Use pyramid projection.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Projection1>))]
public sealed record Projection1 : StringEnum<Projection1>
{
    private Projection1(string value) : base(value)
    {
    }

    public static readonly Projection1 Cubical = new("cubical");

    public static readonly Projection1 Cylindrical = new("cylindrical");

    public static readonly Projection1 Dome = new("dome");

    public static readonly Projection1 Equirectangular = new("equirectangular");

    public static readonly Projection1 Pyramid = new("pyramid");

    public static Projection1 FromValue(string value) => FromValueCore(value);
}
