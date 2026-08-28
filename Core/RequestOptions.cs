using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Vimeo.Core.Hooks;

namespace Vimeo.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
