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
using VimeoApi.Models;

namespace VimeoApi.Api;

/// <summary>
/// Use these methods to work with video transcripts.
/// </summary>
public sealed class VideosTranscripts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VideosTranscripts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get transcript segments
    /// </summary>
    /// <param name="texttrackId">The ID of the text track.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SegmentConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTranscriptError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the transcript segments of the specified text track.
    /// </remarks>
    public Task<SegmentConnection> GetTranscript(double texttrackId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/transcripts/{texttrack_id}"),
            [new TemplateParam("texttrack_id", texttrackId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SegmentConnection>(),
            GetTranscriptErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the transcript metadata of a text track
    /// </summary>
    /// <param name="containerUuid">The UUID of the video container.</param>
    /// <param name="texttrackId">The ID of the text track.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TranscriptMetadata"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTranscriptMetadataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the transcript metadata of the specified text track.
    /// </remarks>
    public Task<TranscriptMetadata> GetTranscriptMetadata(string containerUuid,
        double texttrackId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{container_uuid}/transcript/{texttrack_id}/metadata"),
            [new TemplateParam("container_uuid", containerUuid), new TemplateParam("texttrack_id", texttrackId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TranscriptMetadata>(),
            GetTranscriptMetadataErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
