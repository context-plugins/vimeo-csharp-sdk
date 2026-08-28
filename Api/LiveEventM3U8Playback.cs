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
/// Use these methods to work with M3U8 playback URLs for event streams.
/// </summary>
public sealed class LiveEventM3U8Playback
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveEventM3U8Playback(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get an M3U8 playback URL for an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="dvr">When set to <c>1</c>, returns an fMP4 stream URL if DVR is enabled on the event. If DVR is not enabled, the standard stream URL is returned.</param>
    /// <param name="maxFpsFhd">The requested maximum frames per second.</param>
    /// <param name="ttl">The time to live of the playlist link in seconds. This value must be between <c>10</c> and <c>60</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventM3U8PlaybackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns an M3U8 playback URL for the specified event stream. You should use this endpoint only in conjunction with our recommended procedure for playing events via HLS. For more information, see our <see href="https://developer.vimeo.com/api/live/playback">HLS guide</see>.
    /// </remarks>
    public Task GetLiveEventM3U8Playback(double liveEventId,
        double userId,
        double? dvr,
        double? maxFpsFhd,
        double? ttl,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/m3u8_playback"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [new Param("dvr", dvr), new Param("max_fps_fhd", maxFpsFhd), new Param("ttl", ttl)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetLiveEventM3U8PlaybackErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get an M3U8 playback URL for an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="dvr">When set to <c>1</c>, returns an fMP4 stream URL if DVR is enabled on the event. If DVR is not enabled, the standard stream URL is returned.</param>
    /// <param name="maxFpsFhd">The requested maximum frames per second.</param>
    /// <param name="ttl">The time to live of the playlist link in seconds. This value must be between <c>10</c> and <c>60</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventM3U8PlaybackAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns an M3U8 playback URL for the specified event stream. You should use this endpoint only in conjunction with our recommended procedure for playing events via HLS. For more information, see our <see href="https://developer.vimeo.com/api/live/playback">HLS guide</see>.
    /// </remarks>
    public Task GetLiveEventM3U8PlaybackAlt1(double liveEventId,
        double? dvr,
        double? maxFpsFhd,
        double? ttl,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/m3u8_playback"),
            [new TemplateParam("live_event_id", liveEventId)],
            [new Param("dvr", dvr), new Param("max_fps_fhd", maxFpsFhd), new Param("ttl", ttl)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetLiveEventM3U8PlaybackAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
