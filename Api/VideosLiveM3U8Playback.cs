using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core;
using VimeoApi.Core.Authentication;
using VimeoApi.Core.Exceptions;
using VimeoApi.Core.Models;
using VimeoApi.Core.Request;
using VimeoApi.Core.Response;
using VimeoApi.Errors;

namespace VimeoApi.Api;

/// <summary>
/// Use these methods to work with M3U8 playback URLs for event streams.
/// </summary>
public sealed class VideosLiveM3U8Playback
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VideosLiveM3U8Playback(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get an M3U8 playback URL for a one-time event
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetOneTimeEventM3U8PlaybackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns an M3U8 playback URL for the specified event stream. You should use this endpoint only in conjunction with our recommended procedure for playing events via HLS. For more information, see our <see href="https://developer.vimeo.com/api/live/playback">HLS guide</see>.
    /// </remarks>
    public Task GetOneTimeEventM3U8Playback(double userId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/videos/{video_id}/m3u8_playback"),
            [new TemplateParam("user_id", userId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetOneTimeEventM3U8PlaybackErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get an M3U8 playback URL for a one-time event
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetOneTimeEventM3U8PlaybackAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns an M3U8 playback URL for the specified event stream. You should use this endpoint only in conjunction with our recommended procedure for playing events via HLS. For more information, see our <see href="https://developer.vimeo.com/api/live/playback">HLS guide</see>.
    /// </remarks>
    public Task GetOneTimeEventM3U8PlaybackAlt1(double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/videos/{video_id}/m3u8_playback"),
            [new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetOneTimeEventM3U8PlaybackAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
