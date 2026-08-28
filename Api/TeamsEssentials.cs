using System;
using System.Collections.Generic;
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
/// These are the most common methods for working with teams.
/// </summary>
public sealed class TeamsEssentials
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TeamsEssentials(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Backfill a custom metadata value across a team's videos
    /// </summary>
    /// <param name="userId">The ID of the team owner.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BackfillTeamCustomMetadataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method applies a custom metadata value across every existing video owned by the
    /// team. Use it to populate a newly created field, fix a typo across a library, or align
    /// a large catalog after a workflow change.
    /// <para>
    /// The backfill runs <b>asynchronously</b>. The response is returned as soon as the job is
    /// accepted, but the values themselves are propagated in the background and may take
    /// several minutes for large libraries. The <c>total_videos</c> count in the response is a
    /// snapshot of how many videos match the request at the moment it's accepted; videos
    /// uploaded after that point aren't included and need a separate backfill.
    /// </para>
    /// <para>
    /// By default, only videos that don't already have a value for the field are updated.
    /// Set <c>override_existing</c> to <c>true</c> to replace existing values as well.
    /// </para>
    /// <para>
    /// The value provided must match the field's data type. For example, a <c>date</c> field
    /// requires <c>YYYY-MM-DD</c>, a <c>select</c> field requires one of its allowed values, and a
    /// <c>multi-select</c> field requires a JSON-encoded array of allowed values.
    /// </para>
    /// </remarks>
    public Task BackfillTeamCustomMetadata(double userId,
        TeamsCustomMetadataBackfillRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/teams/{user_id}/custom_metadata/backfill"),
            [new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            BackfillTeamCustomMetadataErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// List videos missing mandatory custom metadata
    /// </summary>
    /// <param name="userId">The ID of the team owner.</param>
    /// <param name="page">The page number of the results to show. Defaults to <c>1</c>.</param>
    /// <param name="perPage">The number of items to show on each page, up to a maximum of <c>100</c>. Defaults to <c>25</c>.</param>
    /// <param name="sort">The order in which to return the results. Defaults to <c>title_asc</c>.  Option descriptions:  * <c>modified_asc</c> - Sort by last modified time, oldest first.  * <c>modified_desc</c> - Sort by last modified time, newest first.  * <c>title_asc</c> - Sort by video title, ascending.  * <c>title_desc</c> - Sort by video title, descending.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTeamCustomMetadataIncompleteVideosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the team's videos that are missing one or more values for
    /// <b>mandatory</b> custom metadata fields. Use it to power dashboards that surface incomplete
    /// videos, drive curation workflows, or generate reports of catalog completeness.
    /// <para>
    /// Each item in the response includes the video's title and identifier, a link to the
    /// video's management page, a thumbnail, the last modified timestamp, and the list of
    /// mandatory fields that still need a value (each with its <c>field_id</c> and <c>name</c>).
    /// </para>
    /// <para>
    /// Only fields marked <c>mandatory: true</c> (see <c>POST /teams/{user_id}/custom_metadata</c>) are
    /// considered. Teams with no mandatory fields receive an empty result set.
    /// </para>
    /// </remarks>
    public Task GetTeamCustomMetadataIncompleteVideos(double userId,
        double? page,
        double? perPage,
        Sort48? sort,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/teams/{user_id}/custom_metadata/incomplete_videos"),
            [new TemplateParam("user_id", userId)],
            [new Param("page", page), new Param("per_page", perPage), new Param("sort", sort)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetTeamCustomMetadataIncompleteVideosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a team's custom metadata fields
    /// </summary>
    /// <param name="userId">The ID of the team owner.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CustomMetadataSettingsConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTeamCustomMetadataSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every custom metadata field defined for the specified team.
    /// <para>
    /// Custom metadata fields let teams attach structured, queryable information to videos
    /// (for example, a department selector, a release date, or a freeform note). Once a field
    /// is defined here, you can assign per-video values via
    /// <c>PUT /videos/{video_id}/custom_metadata</c>.
    /// </para>
    /// <para>
    /// The response contains the field definitions only; per-video values are returned by
    /// the video endpoints. Use this method to populate a UI that lets users fill in metadata,
    /// or to discover the field IDs you need for backfills and value updates.
    /// </para>
    /// </remarks>
    public Task<CustomMetadataSettingsConnection> GetTeamCustomMetadataSettings(double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/teams/{user_id}/custom_metadata"),
            [new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CustomMetadataSettingsConnection>(),
            GetTeamCustomMetadataSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Add, rename, or remove a custom metadata field's allowed values
    /// </summary>
    /// <param name="userId">The ID of the team owner.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CustomMetadataSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateCustomMetadataFieldOptionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method modifies the allowed value list of a <c>select</c> or <c>multi-select</c> custom
    /// metadata field. Use it to rename an option, remove an option, or add a new option
    /// without recreating the field.
    /// <para>
    /// Each entry in the <c>options</c> array describes one atomic change, defined by combining
    /// <c>old_value</c> and <c>new_value</c>:
    /// </para>
    /// <para>
    /// | <c>old_value</c>     | <c>new_value</c>     | Operation                      |
    /// | --------------- | --------------- | ------------------------------ |
    /// | string          | string          | Rename <c>old_value</c> to <c>new_value</c> |
    /// | string          | <c>null</c> / omitted | Delete <c>old_value</c> from the field |
    /// | <c>null</c> / omitted | string          | Add <c>new_value</c> to the field   |
    /// </para>
    /// <para>
    /// Renames are propagated to every existing video that uses the option, so the change
    /// is visible across the team's library. Deletes also remove the option from every
    /// video that had it set. Propagation runs in the background; the field's option list
    /// itself is updated synchronously and returned in the response.
    /// </para>
    /// <para>
    /// A few rules to be aware of:
    /// </para>
    /// <para>
    /// - The field must be of type <c>select</c> or <c>multi-select</c>. Other types reject the request.
    /// - Cascading renames (renaming <c>A</c> to <c>B</c>, then <c>B</c> to <c>C</c> in the same call) are not
    ///   allowed; submit them as separate requests if you need that effect.
    /// - The resulting option list must not contain duplicates.
    /// </para>
    /// </remarks>
    public Task<CustomMetadataSettings> UpdateCustomMetadataFieldOptions(double userId,
        TeamsCustomMetadataOptionsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/teams/{user_id}/custom_metadata/options"),
            [new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<CustomMetadataSettings>(),
            UpdateCustomMetadataFieldOptionsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create, update, or delete a team's custom metadata fields
    /// </summary>
    /// <param name="userId">The ID of the team owner.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CustomMetadataSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpsertCustomMetadataSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates, updates, or deletes custom metadata fields for a team in a single
    /// request. Each entry in the <c>fields</c> array is treated independently:
    /// <para>
    /// - To <b>create</b> a new field, omit <c>id</c> and provide <c>name</c>, <c>type</c>, and <c>mandatory</c>.
    /// - To <b>update</b> an existing field, provide <c>id</c> along with the values you want to change.
    ///   Other values are left untouched.
    /// - To <b>delete</b> an existing field, provide <c>id</c> and set <c>delete: true</c>. Deleting a field
    ///   also removes every value assigned to it across the team's videos.
    /// </para>
    /// <para>
    /// Some constraints are worth knowing up front:
    /// </para>
    /// <para>
    /// - A team can have a maximum of 20 custom metadata fields. Requests that would exceed
    ///   that limit after deletes are applied are rejected.
    /// - The <c>type</c> of an existing field can't be changed once the field is created.
    /// - A field that was created as optional can't be made <c>mandatory</c> later.
    /// - All operations in the request are applied as a single batch; if any one fails the
    ///   whole request is rejected and no changes are saved.
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<CustomMetadataSettings>> UpsertCustomMetadataSettings(double userId,
        TeamsCustomMetadataRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/teams/{user_id}/custom_metadata"),
            [new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IReadOnlyList<CustomMetadataSettings>>(),
            UpsertCustomMetadataSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
