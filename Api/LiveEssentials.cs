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
using VimeoApi.Models.Enums;

namespace VimeoApi.Api;

/// <summary>
/// These are the most common methods for working with events.
/// </summary>
public sealed class LiveEssentials
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveEssentials(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an event
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEvent"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateLiveEventError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a new event for the authenticated user.
    /// </remarks>
    public Task<RecurringEvent> CreateLiveEvent(double userId,
        UsersLiveEventsRequest1 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events"),
            [new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringEvent>(),
            CreateLiveEventErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create an event
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEvent"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateLiveEventAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a new event for the authenticated user.
    /// </remarks>
    public Task<RecurringEvent> CreateLiveEventAlt1(LiveEventsRequest1 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringEvent>(),
            CreateLiveEventAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create an event
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEvent"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateLiveEventAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a new event for the authenticated user.
    /// </remarks>
    public Task<RecurringEvent> CreateLiveEventAlt2(MeLiveEventsRequest1 body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringEvent>(),
            CreateLiveEventAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a specific event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteLiveEventError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes a single event belonging to the authenticated user.
    /// </remarks>
    public Task DeleteLiveEvent(double liveEventId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteLiveEventErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a specific event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteLiveEventAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes a single event belonging to the authenticated user.
    /// </remarks>
    public Task DeleteLiveEventAlt1(double liveEventId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteLiveEventAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a specific event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteLiveEventAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes a single event belonging to the authenticated user.
    /// </remarks>
    public Task DeleteLiveEventAlt2(double liveEventId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteLiveEventAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a list of events
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteLiveEventsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes multiple events belonging to the authenticated user.
    /// </remarks>
    public Task DeleteLiveEvents(double userId,
        UsersLiveEventsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events"),
            [new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            DeleteLiveEventsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a list of events
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteLiveEventsAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes multiple events belonging to the authenticated user.
    /// </remarks>
    public Task DeleteLiveEventsAlt1(LiveEventsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            DeleteLiveEventsAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a list of events
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteLiveEventsAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes multiple events belonging to the authenticated user.
    /// </remarks>
    public Task DeleteLiveEventsAlt2(MeLiveEventsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            DeleteLiveEventsAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="password">The password of the event when the privacy is set to <c>password</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEvent"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single event belonging to the authenticated user.
    /// </remarks>
    public Task<RecurringEvent> GetLiveEvent(double liveEventId,
        double userId,
        string? password,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [new Param("password", password)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RecurringEvent>(),
            GetLiveEventErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="password">The password of the event when the privacy is set to <c>password</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEvent"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single event belonging to the authenticated user.
    /// </remarks>
    public Task<RecurringEvent> GetLiveEventAlt1(double liveEventId,
        string? password,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}"),
            [new TemplateParam("live_event_id", liveEventId)],
            [new Param("password", password)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RecurringEvent>(),
            GetLiveEventAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a specific event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="password">The password of the event when the privacy is set to <c>password</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEvent"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a single event belonging to the authenticated user.
    /// </remarks>
    public Task<RecurringEvent> GetLiveEventAlt2(double liveEventId,
        string? password,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}"),
            [new TemplateParam("live_event_id", liveEventId)],
            [new Param("password", password)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RecurringEvent>(),
            GetLiveEventAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get live event occurrences in a date range
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="startDate">The start of the date range in ISO 8601 format.</param>
    /// <param name="endDate">The end of the date range in ISO 8601 format. Defaults to 7 days after start.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LiveEventOccurrenceConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all live event occurrences for the user within the given date range.
    /// <para>
    /// For recurring events (with rrule), each occurrence within the range is returned as a separate entry.
    /// For one-time events (no rrule), the event is included if its start_time falls within the range.
    /// </para>
    /// </remarks>
    public Task<LiveEventOccurrenceConnection> GetLiveEventOccurrences(double userId,
        string startDate,
        string? endDate,
        double? page,
        double? perPage,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events_occurrences"),
            [new TemplateParam("user_id", userId)],
            [new Param("start_date", startDate),
                new Param("end_date", endDate),
                new Param("page", page),
                new Param("per_page", perPage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<LiveEventOccurrenceConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the events that belong to the user
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>not_in_folder</c> - Show only events that aren't in a folder.  * <c>not_in_showcase</c> - Show only events that aren't in a showcase.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by creation date.</param>
    /// <param name="type">The type of event to return.  Option descriptions:  * <c>all</c> - Return all events.  * <c>one_time</c> - Return one-time events only.  * <c>recurring</c> - Return recurring events only.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The method returns every event belonging to the authenticated user.
    /// </remarks>
    public Task<EventConnection> GetLiveEvents(double userId,
        Direction? direction,
        Filter8? filter,
        double? page,
        double? perPage,
        string? query,
        Sort8? sort,
        Type27? type,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events"),
            [new TemplateParam("user_id", userId)],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort),
                new Param("type", type)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EventConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the events that belong to the user
    /// </summary>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>not_in_folder</c> - Show only events that aren't in a folder.  * <c>not_in_showcase</c> - Show only events that aren't in a showcase.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by creation date.</param>
    /// <param name="type">The type of event to return.  Option descriptions:  * <c>all</c> - Return all events.  * <c>one_time</c> - Return one-time events only.  * <c>recurring</c> - Return recurring events only.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The method returns every event belonging to the authenticated user.
    /// </remarks>
    public Task<EventConnection> GetLiveEventsAlt1(Direction? direction,
        Filter8? filter,
        double? page,
        double? perPage,
        string? query,
        Sort8? sort,
        Type27? type,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events"),
            [],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort),
                new Param("type", type)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EventConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the events that belong to the user
    /// </summary>
    /// <param name="direction">The sort direction of the results.  Option descriptions:  * <c>asc</c> - Sort the results in ascending order.  * <c>desc</c> - Sort the results in descending order.</param>
    /// <param name="filter">The attribute by which to filter the results.  Option descriptions:  * <c>not_in_folder</c> - Show only events that aren't in a folder.  * <c>not_in_showcase</c> - Show only events that aren't in a showcase.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="query">The search query to use to filter the results.</param>
    /// <param name="sort">The way to sort the results.  Option descriptions:  * <c>alphabetical</c> - Sort the results alphabetically.  * <c>date</c> - Sort the results by creation date.</param>
    /// <param name="type">The type of event to return.  Option descriptions:  * <c>all</c> - Return all events.  * <c>one_time</c> - Return one-time events only.  * <c>recurring</c> - Return recurring events only.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The method returns every event belonging to the authenticated user.
    /// </remarks>
    public Task<EventConnection> GetLiveEventsAlt2(Direction? direction,
        Filter8? filter,
        double? page,
        double? perPage,
        string? query,
        Sort8? sort,
        Type27? type,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events"),
            [],
            [new Param("direction", direction),
                new Param("filter", filter),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("query", query),
                new Param("sort", sort),
                new Param("type", type)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EventConnection>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Update an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEvent"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateLiveEventError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method updates an event belonging to the authenticated user.
    /// </remarks>
    public Task<RecurringEvent> UpdateLiveEvent(double liveEventId,
        double userId,
        UsersLiveEventsRequest2? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringEvent>(),
            UpdateLiveEventErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Update an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEvent"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateLiveEventAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method updates an event belonging to the authenticated user.
    /// </remarks>
    public Task<RecurringEvent> UpdateLiveEventAlt1(double liveEventId,
        LiveEventsRequest2? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/live_events/{live_event_id}"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringEvent>(),
            UpdateLiveEventAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Update an event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringEvent"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateLiveEventAlt2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method updates an event belonging to the authenticated user.
    /// </remarks>
    public Task<RecurringEvent> UpdateLiveEventAlt2(double liveEventId,
        MeLiveEventsRequest2? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringEvent>(),
            UpdateLiveEventAlt2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
