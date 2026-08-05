using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;

namespace VimeoApi.Core.Response;

public sealed class RawErrorBodyResponse : IResponse<RawError>
{
    public static RawErrorBodyResponse Instance { get; } = new();

    private RawErrorBodyResponse() { }

    public ValueTask<RawError> Map(HttpResponseMessage httpResponseMessage, CancellationToken cancellationToken) =>
        new(RawError.Create(httpResponseMessage, cancellationToken));
}
