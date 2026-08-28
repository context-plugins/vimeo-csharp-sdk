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
using Vimeo.Models;

namespace Vimeo.Api;

/// <summary>
/// Use these methods to work with timeline events.
/// </summary>
public sealed class EmbedPresetsTimelineEvents
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal EmbedPresetsTimelineEvents(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a timeline event thumbnail to a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateVideoCustomLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a timeline event thumbnail to the specified video. The authenticated user must be the owner of the video.
    /// </remarks>
    public Task<Picture> CreateVideoCustomLogo(double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/timelinethumbnails"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            CreateVideoCustomLogoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a timeline event thumbnail
    /// </summary>
    /// <param name="thumbnailId">The ID of the timeline event thumbnail.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Picture"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVideoCustomLogoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single timeline event thumbnail that belongs to the specified video.
    /// </remarks>
    public Task<Picture> GetVideoCustomLogo(double thumbnailId,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/timelinethumbnails/{thumbnail_id}"),
            [new TemplateParam("thumbnail_id", thumbnailId), new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Picture>(),
            GetVideoCustomLogoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
