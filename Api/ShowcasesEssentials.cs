using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core;
using Vimeo.Core.Authentication;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Exceptions;
using Vimeo.Core.Models;
using Vimeo.Core.Request;
using Vimeo.Core.Response;
using Vimeo.Errors;
using Vimeo.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Api;

/// <summary>
/// These are the most common methods for working with showcases.
/// </summary>
public sealed class ShowcasesEssentials
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ShowcasesEssentials(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add folder contents to showcases
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="albumUris">A comma-separated list of showcase URIs.</param>
    /// <param name="folderId">The ID of the folder containing videos and events to add.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AddFolderToShowcasesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds all videos and events from a specified folder to showcases.
    /// <para>
    /// The authenticated user must either be the owner of the showcase or have team permissions.
    /// </para>
    /// </remarks>
    public Task AddFolderToShowcases(double userId,
        string albumUris,
        double folderId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/from_folder"),
            [new TemplateParam("user_id", userId)],
            [new Param("album_uris", albumUris), new Param("folder_id", folderId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            VoidResponse.Instance,
            AddFolderToShowcasesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Copy a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CopyShowcaseError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a copy of the specified showcase.
    /// </remarks>
    public Task<Album> CopyShowcase(double albumId,
        double userId,
        UsersAlbumsCopyRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}/copy"),
            [new TemplateParam("album_id", albumId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Album>(),
            CopyShowcaseErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Copy a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CopyShowcaseAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a copy of the specified showcase.
    /// </remarks>
    public Task<Album> CopyShowcaseAlt2(double albumId,
        MeAlbumsCopyRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums/{album_id}/copy"),
            [new TemplateParam("album_id", albumId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Album>(),
            CopyShowcaseAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a showcase
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateShowcaseError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a new showcase for the specified user.
    /// </remarks>
    public Task<Album> CreateShowcase(double userId,
        UsersAlbumsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums"),
            [new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Album>(),
            CreateShowcaseErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a showcase
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateShowcaseAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a new showcase for the specified user.
    /// </remarks>
    public Task<Album> CreateShowcaseAlt1(MeAlbumsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Album>(),
            CreateShowcaseAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteShowcaseError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task DeleteShowcase(double albumId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}"),
            [new TemplateParam("album_id", albumId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteShowcaseErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteShowcaseAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task DeleteShowcaseAlt2(double albumId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums/{album_id}"),
            [new TemplateParam("album_id", albumId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteShowcaseAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditShowcaseError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<Album> EditShowcase(double albumId,
        double userId,
        UsersAlbumsRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}"),
            [new TemplateParam("album_id", albumId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Album>(),
            EditShowcaseErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit a showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditShowcaseAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<Album> EditShowcaseAlt2(double albumId,
        MeAlbumsRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums/{album_id}"),
            [new TemplateParam("album_id", albumId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Album>(),
            EditShowcaseAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcaseError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<Album> GetShowcase(double albumId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums/{album_id}"),
            [new TemplateParam("album_id", albumId), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Album>(),
            GetShowcaseErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific showcase
    /// </summary>
    /// <param name="albumId">The ID of the showcase.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Album"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcaseAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the specified showcase. The authenticated user must be the owner of the showcase.
    /// </remarks>
    public Task<Album> GetShowcaseAlt2(double albumId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums/{album_id}"),
            [new TemplateParam("album_id", albumId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Album>(),
            GetShowcaseAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the showcases that belong to the user
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filterPrivacy">A comma-separated list of showcase privacies to include. Valid options are <c>anybody</c> for universal access, <c>password</c> for password-restricted access, <c>embed_only</c> for restricted access on Vimeo but available as an embedded showcase elsewhere, <c>team</c> for team-only access, <c>nobody</c> for owner-only access, and <c>unlisted</c> for restricted access except for those with a direct link. By default, all privacies are returned.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date of creation.  * <c>duration</c> - Sort the results by duration.  * <c>last_modified</c> - Sort the results by last modified date.  * <c>videos</c> - Sort the results by the number of videos.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlbumConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcasesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every showcase belonging to the authenticated user.
    /// </remarks>
    public Task<AlbumConnection> GetShowcases(double userId,
        Direction? direction,
        string? filterPrivacy,
        double? page,
        double? perPage,
        string? query,
        Sort18? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums"),
            [new TemplateParam("user_id", userId)],
            [new Param("direction", direction),
                new Param("filter_privacy", filterPrivacy),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AlbumConnection>(),
            GetShowcasesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the showcases that belong to the user
    /// </summary>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filterPrivacy">A comma-separated list of showcase privacies to include. Valid options are <c>anybody</c> for universal access, <c>password</c> for password-restricted access, <c>embed_only</c> for restricted access on Vimeo but available as an embedded showcase elsewhere, <c>team</c> for team-only access, <c>nobody</c> for owner-only access, and <c>unlisted</c> for restricted access except for those with a direct link. By default, all privacies are returned.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by date of creation.  * <c>duration</c> - Sort the results by duration.  * <c>last_modified</c> - Sort the results by last modified date.  * <c>videos</c> - Sort the results by the number of videos.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AlbumConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetShowcasesAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every showcase belonging to the authenticated user.
    /// </remarks>
    public Task<AlbumConnection> GetShowcasesAlt1(Direction? direction,
        string? filterPrivacy,
        double? page,
        double? perPage,
        string? query,
        Sort18? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/albums"),
            [],
            [new Param("direction", direction),
                new Param("filter_privacy", filterPrivacy),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AlbumConnection>(),
            GetShowcasesAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add videos and events to showcases
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="albumItemUris">A comma-separated list of video or event URIs.</param>
    /// <param name="albumUris">A comma-separated list of showcase URIs.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method adds videos and events to the specified showcases. The authenticated user must either be the owner of the showcase or have team permissions.
    /// <para>
    /// The present setup permits only one event per showcase.
    /// </para>
    /// </remarks>
    public Task UpdateShowcases(double userId,
        string albumItemUris,
        string albumUris,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/albums"),
            [new TemplateParam("user_id", userId)],
            [new Param("album_item_uris", albumItemUris), new Param("album_uris", albumUris)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
