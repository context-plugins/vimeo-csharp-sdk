using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using VimeoApi.Core.Hooks;

namespace VimeoApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
