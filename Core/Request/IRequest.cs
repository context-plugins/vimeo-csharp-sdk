using System.Net.Http;

namespace Vimeo.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}