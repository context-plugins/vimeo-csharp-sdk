using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort46>))]
public sealed record Sort46 : StringEnum<Sort46>
{
    private Sort46(string value) : base(value)
    {
    }

    public static readonly Sort46 Alphabetical = new("alphabetical");

    public static readonly Sort46 Date = new("date");

    public static readonly Sort46 Default = new("default");

    public static readonly Sort46 Duration = new("duration");

    public static readonly Sort46 FolderPath = new("folder_path");

    public static readonly Sort46 LastUserActionEventDate = new("last_user_action_event_date");

    public static Sort46 FromValue(string value) => FromValueCore(value);
}
