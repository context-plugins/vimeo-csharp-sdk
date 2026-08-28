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
/// Use these methods to manage the allowlist of embeddable videos.
/// </summary>
public sealed class VideosEmbedPrivacy
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal VideosEmbedPrivacy(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a domain to a video's allowlist
    /// </summary>
    /// <param name="domain">The domain name.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddVideoPrivacyDomainError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds the specified domain to a video's allowlist.
    /// </remarks>
    public Task AddVideoPrivacyDomain(string domain,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/privacy/domains/{domain}"),
            [new TemplateParam("domain", domain), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            VoidResponse.Instance,
            AddVideoPrivacyDomainErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a domain from a video's allowlist
    /// </summary>
    /// <param name="domain">The domain name.</param>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteVideoPrivacyDomainError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method removes the specified domain from a video's allowlist.
    /// </remarks>
    public Task DeleteVideoPrivacyDomain(string domain,
        double videoId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/privacy/domains/{domain}"),
            [new TemplateParam("domain", domain), new TemplateParam("video_id", videoId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteVideoPrivacyDomainErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the domains on a video's allowlist
    /// </summary>
    /// <param name="videoId">The ID of the video.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>default</c> - Sort the results by the video's allowlist ID.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DomainConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetVideoPrivacyDomainsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every domain on the specified video's allowlist.
    /// </remarks>
    public Task<DomainConnection> GetVideoPrivacyDomains(double videoId,
        Direction? direction,
        double? page,
        double? perPage,
        Sort78? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/videos/{video_id}/privacy/domains"),
            [new TemplateParam("video_id", videoId)],
            [new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DomainConnection>(),
            GetVideoPrivacyDomainsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
