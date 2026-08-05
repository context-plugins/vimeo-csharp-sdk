using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core;
using VimeoApi.Core.Authentication;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Exceptions;
using VimeoApi.Core.Models;
using VimeoApi.Core.Request;
using VimeoApi.Core.Response;
using VimeoApi.Errors;
using VimeoApi.Models;

namespace VimeoApi.Api;

/// <summary>
/// Use these methods to work with webhooks for API apps.
/// </summary>
public sealed class ApiAppsWebhooks
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ApiAppsWebhooks(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a webhook for an app
    /// </summary>
    /// <param name="appId">The ID of the app for which the webhook is created.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiAppWebhook"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddWebhookError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds a webhook for the specified app.
    /// </remarks>
    public Task<ApiAppWebhook> AddWebhook(double appId,
        AppsWebhooksRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps/{app_id}/webhooks"),
            [new TemplateParam("app_id", appId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ApiAppWebhook>(),
            AddWebhookErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a webhook
    /// </summary>
    /// <param name="appId">The ID of the app that the webhook is associated with.</param>
    /// <param name="webhookId">The ID of the webhook.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteWebhookError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified webhook.
    /// </remarks>
    public Task DeleteWebhook(double appId,
        double webhookId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps/{app_id}/webhooks/{webhook_id}"),
            [new TemplateParam("app_id", appId), new TemplateParam("webhook_id", webhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteWebhookErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a webhook
    /// </summary>
    /// <param name="appId">The ID of the app that the webhook is associated with.</param>
    /// <param name="webhookId">The ID of the webhook.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiAppWebhook"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetWebhookError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the specified webhook.
    /// </remarks>
    public Task<ApiAppWebhook> GetWebhook(double appId,
        double webhookId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps/{app_id}/webhooks/{webhook_id}"),
            [new TemplateParam("app_id", appId), new TemplateParam("webhook_id", webhookId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiAppWebhook>(),
            GetWebhookErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all webhooks for an app
    /// </summary>
    /// <param name="appId">The ID of the app that the webhook is associated with.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiAppWebhookConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every webhook for the specified app.
    /// </remarks>
    public Task<ApiAppWebhookConnection> GetWebhooks(double appId,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps/{app_id}/webhooks"),
            [new TemplateParam("app_id", appId)],
            [new Param("page", page), new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiAppWebhookConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Update a webhook
    /// </summary>
    /// <param name="appId">The ID of the app that the webhook is associated with.</param>
    /// <param name="webhookId">The ID of the webhook.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiAppWebhook"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateWebhookError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method updates the specified webhook.
    /// </remarks>
    public Task<ApiAppWebhook> UpdateWebhook(double appId,
        double webhookId,
        AppsWebhooksRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/apps/{app_id}/webhooks/{webhook_id}"),
            [new TemplateParam("app_id", appId), new TemplateParam("webhook_id", webhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<ApiAppWebhook>(),
            UpdateWebhookErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
