using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core;
using Vimeo.Core.Authentication;
using Vimeo.Core.Exceptions;
using Vimeo.Core.Models;
using Vimeo.Core.Request;
using Vimeo.Core.Response;
using Vimeo.Errors;

namespace Vimeo.Api;

/// <summary>
/// Use these methods to work with analytics for events.
/// </summary>
public sealed class LiveAnalytics
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveAnalytics(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Export VPaaS viewer analytics
    /// </summary>
    /// <param name="liveEventId">The ID of the live event.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ExportVpaasViewerAnalyticsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method queues an export of VPaaS viewer analytics for the specified live event.
    /// <para>
    /// The authenticated user must be the owner of the event or have edit permissions.
    /// The webhook is delivered to the managing vendor app's registered webhook URL.
    /// </para>
    /// </remarks>
    public Task ExportVpaasViewerAnalytics(double liveEventId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}/export_vpaas_analytics"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            VoidResponse.Instance,
            ExportVpaasViewerAnalyticsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
