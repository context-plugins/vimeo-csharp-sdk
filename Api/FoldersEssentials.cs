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
/// These are the most common methods for working with folders.
/// </summary>
public sealed class FoldersEssentials
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FoldersEssentials(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a folder
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Project"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateProjectError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a new folder for the authenticated user. By default, this method creates a top-level folder. To create a subfolder — that is, to place the new folder inside an existing folder — specify the parent folder by URI with the <b>parent_folder_uri</b> parameter in the body of the request.
    /// </remarks>
    public Task<Project> CreateProject(double userId,
        UsersProjectsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects"),
            [new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Project>(),
            CreateProjectErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a folder
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Project"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateProjectAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a new folder for the authenticated user. By default, this method creates a top-level folder. To create a subfolder — that is, to place the new folder inside an existing folder — specify the parent folder by URI with the <b>parent_folder_uri</b> parameter in the body of the request.
    /// </remarks>
    public Task<Project> CreateProjectAlt1(MeProjectsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Project>(),
            CreateProjectAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteProjectError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified folder and optionally also the videos that it contains. The authenticated user must be the owner of the folder.
    /// </remarks>
    public Task DeleteProject(double projectId,
        double userId,
        UsersProjectsRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects/{project_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            DeleteProjectErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteProjectAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified folder and optionally also the videos that it contains. The authenticated user must be the owner of the folder.
    /// </remarks>
    public Task DeleteProjectAlt1(double projectId,
        MeProjectsRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects/{project_id}"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            DeleteProjectAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Project"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditProjectError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the specified folder. The authenticated user must be the owner of the folder.
    /// </remarks>
    public Task<Project> EditProject(double projectId,
        double userId,
        UsersProjectsRequest2 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects/{project_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Project>(),
            EditProjectErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Edit a folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Project"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="EditProjectAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method edits the specified folder. The authenticated user must be the owner of the folder.
    /// </remarks>
    public Task<Project> EditProjectAlt1(double projectId,
        MeProjectsRequest2 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects/{project_id}"),
            [new TemplateParam("project_id", projectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Project>(),
            EditProjectAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a user's private-to-me folder
    /// </summary>
    /// <param name="ownerId">The ID of the owner.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Project"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPrivateToMeFolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the specified private-to-me folder.
    /// </remarks>
    public Task<Project> GetPrivateToMeFolder(double ownerId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{owner_id}/folders/private_to_me"),
            [new TemplateParam("owner_id", ownerId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Project>(),
            GetPrivateToMeFolderErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Project"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetProjectError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single folder belonging to the authenticated user.
    /// </remarks>
    public Task<Project> GetProject(double projectId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects/{project_id}"),
            [new TemplateParam("project_id", projectId), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Project>(),
            GetProjectErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific folder
    /// </summary>
    /// <param name="projectId">The ID of the folder.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Project"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetProjectAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single folder belonging to the authenticated user.
    /// </remarks>
    public Task<Project> GetProjectAlt1(double projectId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects/{project_id}"),
            [new TemplateParam("project_id", projectId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Project>(),
            GetProjectAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the folders that belong to the user
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>date</c> - Sort the results by date.  * <c>default</c> - Use the default sort order.  * <c>modified_time</c> - Sort the results by last modification.  * <c>name</c> - Sort the results by name.  * <c>pinned_on</c> - Sort the results by pinned timestamp.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProjectConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetProjectsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the folders belonging to the authenticated user.
    /// </remarks>
    public Task<ProjectConnection> GetProjects(double userId,
        Direction? direction,
        double? page,
        double? perPage,
        string? query,
        Sort36? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/projects"),
            [new TemplateParam("user_id", userId)],
            [new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ProjectConnection>(),
            GetProjectsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the folders that belong to the user
    /// </summary>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>date</c> - Sort the results by date.  * <c>default</c> - Use the default sort order.  * <c>modified_time</c> - Sort the results by last modification.  * <c>name</c> - Sort the results by name.  * <c>pinned_on</c> - Sort the results by pinned timestamp.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProjectConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetProjectsAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns all the folders belonging to the authenticated user.
    /// </remarks>
    public Task<ProjectConnection> GetProjectsAlt1(Direction? direction,
        double? page,
        double? perPage,
        string? query,
        Sort36? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/projects"),
            [],
            [new Param("direction", direction),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ProjectConnection>(),
            GetProjectsAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
