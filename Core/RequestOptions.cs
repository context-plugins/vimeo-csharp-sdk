using Microsoft.Extensions.Logging;

namespace VimeoApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
