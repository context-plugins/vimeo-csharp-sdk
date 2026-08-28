using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Vimeo.Core.Extensions;
using Vimeo.Core.Models;

namespace Vimeo.Models.AnyOf;

/// <summary>
/// A collection of information about the embeddable player's end screen. The API returns an empty array instead of an object when no end screen is configured for the video.
/// </summary>
[JsonConverter(typeof(EndScreen3Converter))]
public record EndScreen3
{
    private readonly Optional<EndScreen> _endScreenValue;

    private readonly Optional<IReadOnlyList<object>> _listOfAnonymousObjectValue;

    private EndScreen3(Optional<EndScreen> endScreenValue,
        Optional<IReadOnlyList<object>> listOfAnonymousObjectValue)
    {
        _endScreenValue = endScreenValue;
        _listOfAnonymousObjectValue = listOfAnonymousObjectValue;
    }

    public static EndScreen3 EndScreen(EndScreen value) => new(Optional<EndScreen>.Some(value), default);

    public static EndScreen3 ListOfAnonymousObject(IReadOnlyList<object> value) =>
        new(default, Optional<IReadOnlyList<object>>.Some(value));

    public bool TryGetEndScreen(out EndScreen value) => _endScreenValue.TryGetValue(out value);

    public bool TryGetListOfAnonymousObject(out IReadOnlyList<object> value) =>
        _listOfAnonymousObjectValue.TryGetValue(out value);

    public static implicit operator EndScreen3(EndScreen value) => EndScreen(value);
}

file sealed class EndScreen3Converter : JsonConverter<EndScreen3>
{
    public override EndScreen3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<EndScreen>(root, options, out var endScreenValue))
        {
            return EndScreen3.EndScreen(endScreenValue);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<object>>(root, options, out var listOfAnonymousObjectValue))
        {
            return EndScreen3.ListOfAnonymousObject(listOfAnonymousObjectValue);
        }
        throw new JsonException($"JSON does not match EndScreen or IReadOnlyList<object> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EndScreen3 value, JsonSerializerOptions options)
    {
        if (value.TryGetEndScreen(out var endScreenValue))
        {
            JsonSerializer.Serialize(writer, endScreenValue, options);
        }
        else if (value.TryGetListOfAnonymousObject(out var listOfAnonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, listOfAnonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EndScreen3)} contains no valid value to serialize.");
        }
    }
}
