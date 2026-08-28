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
/// Use these methods to work with folders that have embed presets.
/// </summary>
public sealed class EmbedPresetsFolders
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal EmbedPresetsFolders(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Remove an embed preset from a folder
    /// </summary>
    /// <param name="presetId">The ID of the embed preset.</param>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteFolderEmbedPresetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes the specified embed preset from a folder. The authenticated user must be either the owner of the folder or a team user with the contributor or admin role.
    /// </remarks>
    public Task DeleteFolderEmbedPreset(double presetId,
        double projectId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects/{project_id}/presets/{preset_id}"),
            [new TemplateParam("preset_id", presetId),
                new TemplateParam("project_id", projectId),
                new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteFolderEmbedPresetErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
