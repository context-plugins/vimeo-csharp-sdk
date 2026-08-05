using System.Net.Http;

namespace VimeoApi.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}