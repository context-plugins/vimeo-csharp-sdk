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
using Vimeo.Models.Enums;

namespace Vimeo.Api;

/// <summary>
/// Use these methods to access Vimeo's AI-powered video intelligence features, including automatic transcription, subtitle translation, audio dubbing, and video Q&amp;A. All endpoints require the <c>ai</c> OAuth scope and are available exclusively to Enterprise accounts. POST requests are subject to per-endpoint rate limits — contact your account team or Vimeo Sales to increase your allotment. Vimeo AI feature use is subject to <see href="https://vimeo.com/legal/service-terms/ai">Vimeo's AI Addendum</see>.
/// </summary>
public sealed class VideosAi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VideosAi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Ask a question about a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AskAiQuestionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method asks a question about a video and returns an AI-generated answer with relevant
    /// quotes and timecodes. Answering questions requires generating artifacts from the video, so
    /// the first request for a new video may return a <c>202</c> response — simply retry until a <c>200</c>
    /// is returned with the answer.
    /// </remarks>
    public Task AskAiQuestion(double videoId,
        VideosAiAskRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/ai/ask"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            AskAiQuestionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit text track segments
    /// </summary>
    /// <param name="texttrackId">The ID of the text track.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditAiTexttrackError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits transcript segments on the specified text track and automatically
    /// triggers the appropriate downstream actions based on the track type:
    /// <para>
    /// - <b>Source transcript</b>: saves edits, then re-translates all subtitle children
    ///   for the edited text segments. Timestamp and speaker changes are synced to children
    ///   directly (no re-translation for speaker-only edits).
    /// - <b>Dubbed track</b>: saves edits and triggers audio re-synthesis for the edited segments.
    ///   Re-synthesis fires on text edits and on speaker reassignment (the dub is regenerated
    ///   under the new speaker's voice).
    /// - <b>Subtitle child</b>: saves text edits to this track only. Timestamp and speaker changes
    ///   are synced to the parent track and all sibling subtitle tracks.
    /// </para>
    /// <para>
    /// To retrieve the <c>texttrack_id</c>, use the GET endpoints for
    /// <see href="#get_ai_transcribe_status">transcription</see>,
    /// <see href="#get_ai_translate_subtitles_status">subtitle translation</see>, or
    /// <see href="#get_ai_translate_dubbing_status">dubbing</see>.
    /// To retrieve segment UUIDs and their current text and timecodes, use
    /// <c>GET /videos/{video_id}/transcripts/{texttrack_id}</c>.
    /// </para>
    /// </remarks>
    public Task EditAiTexttrack(double texttrackId,
        double videoId,
        VideosAiTexttracksRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/ai/texttracks/{texttrack_id}"),
            [new TemplateParam("texttrack_id", texttrackId), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            VoidResponse.Instance,
            EditAiTexttrackErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get supported languages for AI features
    /// </summary>
    /// <param name="type">The AI feature type to list languages for.  Option descriptions:  * <c>dubbing</c> - Languages supported for AI audio dubbing. Includes available accents per language.  * <c>subtitling</c> - Languages supported for AI subtitle translation.  * <c>transcription</c> - Languages supported for AI transcription (speech-to-text).</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAiLanguagesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the list of supported languages for AI features. Use the <c>type</c> query parameter to
    /// filter by feature: <c>transcription</c> for speech-to-text languages, <c>subtitling</c> for subtitle translation
    /// languages, or <c>dubbing</c> for audio dubbing languages (includes available accents per language).
    /// </remarks>
    public Task GetAiLanguages(Type52? type, RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/ai/languages"),
            [],
            [new Param("type", type)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetAiLanguagesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get AI-generated video metadata
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAiMetadataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns AI-generated metadata for the specified video, including a suggested
    /// title, description, and tags based on the video's content. The first request for a new
    /// video may return a <c>202</c> response while the video is being processed — retry until ready.
    /// </remarks>
    public Task GetAiMetadata(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/ai/metadata"),
            [new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetAiMetadataErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get suggested questions for a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="language">The language for suggested questions. Defaults to <c>en</c>. Available: <c>en</c>, <c>fr</c>, <c>es</c>, <c>de</c>, <c>it</c>, <c>pt</c>, <c>ja</c>, <c>ko</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAiQuestionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns pre-generated questions and answers about a video. These are
    /// automatically created when the video is processed and provide a starting point for
    /// exploring the video's content. The first request for a new video may return a <c>202</c>
    /// response while artifacts are being generated — retry until ready.
    /// <para>
    /// Questions are available in <c>en</c>, <c>fr</c>, <c>es</c>, <c>de</c>, <c>it</c>, <c>pt</c>, <c>ja</c>, and <c>ko</c>.
    /// English is returned by default.
    /// </para>
    /// </remarks>
    public Task GetAiQuestions(double videoId,
        string? language,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/ai/ask"),
            [new TemplateParam("video_id", videoId)],
            [new Param("language", language)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetAiQuestionsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get AI transcription status for a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAiTranscribeStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the current transcription status for a video. The response includes the <c>video_id</c>,
    /// <c>status</c>, and <c>language</c>. When the status is <c>completed</c>, the response also includes the <c>texttrack_id</c>
    /// which can be used to read the transcript via <c>GET /videos/{video_id}/transcripts/{texttrack_id}</c>.
    /// <para>
    /// Possible status values: <c>none</c> (no transcription requested), <c>not_started</c> (queued, awaiting processing),
    /// <c>in_progress</c>, <c>completed</c>, <c>failed</c>, <c>language_not_supported</c>, <c>no_speech</c>, <c>exceeds_maximum_duration</c>,
    /// <c>blocked</c>, <c>unknown</c>.
    /// </para>
    /// </remarks>
    public Task GetAiTranscribeStatus(double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/ai/transcribe"),
            [new TemplateParam("video_id", videoId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetAiTranscribeStatusErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get AI dubbing status for a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="language">Filter results to a specific target language code. When omitted, all dubbing jobs are returned.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAiTranslateDubbingStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the audio dubbing jobs for a video. Each entry includes the language, current status,
    /// and — when completed — the <c>texttrack_id</c> of the dubbed subtitles and the <c>audiotrack_uri</c> of the dubbed
    /// audio. Only completed jobs whose text track still exists are included; deleted tracks are omitted.
    /// <para>
    /// Possible status values: <c>processing</c>, <c>completed</c>, <c>completed_with_deleted_texttrack</c>, <c>completed_with_deleted_audiotrack</c>, <c>failed</c>, <c>invalid_input</c> (the source content was not suitable for dubbing), <c>not_found</c>, <c>unknown</c>. Jobs where both the text track and audio track have been deleted are omitted entirely.
    /// </para>
    /// </remarks>
    public Task GetAiTranslateDubbingStatus(double videoId,
        string? language,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/ai/translate/dubbing"),
            [new TemplateParam("video_id", videoId)],
            [new Param("language", language)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetAiTranslateDubbingStatusErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get AI subtitle translation status for a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="language">Filter results to a specific target language code. When omitted, all subtitle translation jobs are returned.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAiTranslateSubtitlesStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the subtitle translation jobs for a video. Each entry includes the language,
    /// current status, and — when completed — the <c>texttrack_id</c> of the resulting text track. Only completed
    /// translations whose text track still exists are included; deleted tracks are omitted.
    /// <para>
    /// Possible status values: <c>processing</c>, <c>completed</c>, <c>failed</c>, <c>invalid_input</c> (the source content was not suitable for translation), <c>not_found</c>, <c>unknown</c>.
    /// </para>
    /// </remarks>
    public Task GetAiTranslateSubtitlesStatus(double videoId,
        string? language,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/ai/translate/subtitles"),
            [new TemplateParam("video_id", videoId)],
            [new Param("language", language)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetAiTranslateSubtitlesStatusErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Start AI transcription for a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="StartAiTranscribeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method generates a transcript from the video's audio using AI speech-to-text. The video must not already
    /// have a transcript — delete the existing one first if you need to regenerate. Transcription is asynchronous;
    /// use <c>GET /videos/{video_id}/ai/transcribe</c> to poll for completion. Once complete, read the transcript via
    /// <c>GET /videos/{video_id}/transcripts/{texttrack_id}</c>.
    /// <para>
    /// When no language is provided, the system attempts to auto-detect the spoken language from the video's audio.
    /// If detection fails or confidence is too low, it falls back to the video's locale, then the user's locale
    /// preference, then English (<c>en</c>).
    /// </para>
    /// </remarks>
    public Task StartAiTranscribe(double videoId,
        VideosAiTranscribeRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/ai/transcribe"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            StartAiTranscribeErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Start AI audio dubbing for a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="StartAiTranslateDubbingError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method starts an audio dubbing job for a video. By calling this endpoint, you confirm that you, and
    /// your end users, have met all legal requirements to use the voices of the people in the source video to
    /// create synthetic audio. This may include obtaining written consent.
    /// <para>
    /// The video must have finished transcoding, have a completed transcript, and be under 150 minutes in
    /// duration. Dubbing is asynchronous; use <c>GET /videos/{video_id}/ai/translate/dubbing</c> to poll for
    /// completion. Once complete, the dubbed audio appears as an alternate audio track and translated subtitles
    /// appear as a new text track.
    /// </para>
    /// <para>
    /// AI credits are deducted from the enterprise account's balance. Dubbing costs more credits than subtitling.
    /// </para>
    /// </remarks>
    public Task StartAiTranslateDubbing(double videoId,
        VideosAiTranslateDubbingRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/ai/translate/dubbing"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            StartAiTranslateDubbingErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Start AI subtitle translation for a video
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="StartAiTranslateSubtitlesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method starts a subtitle translation job for a video. The video must have finished transcoding and have
    /// a completed transcript. Translation is asynchronous; use <c>GET /videos/{video_id}/ai/translate/subtitles</c> to
    /// poll for completion. Once complete, the translated subtitles appear as a new text track accessible via
    /// <c>GET /videos/{video_id}/texttracks</c>.
    /// <para>
    /// AI credits are deducted from the enterprise account's balance.
    /// </para>
    /// </remarks>
    public Task StartAiTranslateSubtitles(double videoId,
        VideosAiTranslateSubtitlesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/ai/translate/subtitles"),
            [new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            StartAiTranslateSubtitlesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
