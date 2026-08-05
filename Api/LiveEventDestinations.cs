using System;
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
/// Use these methods to work with event destinations.
/// </summary>
public sealed class LiveEventDestinations
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal LiveEventDestinations(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an event destination
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventDestination"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateLiveEventDestinationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a destination for the specified event. The authenticated user must be the owner of the event.
    /// </remarks>
    public Task<EventDestination> CreateLiveEventDestination(double liveEventId,
        MeLiveEventsDestinationsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/destinations"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<EventDestination>(),
            CreateLiveEventDestinationErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create an event destination
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventDestination"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateLiveEventDestinationAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates a destination for the specified event. The authenticated user must be the owner of the event.
    /// </remarks>
    public Task<EventDestination> CreateLiveEventDestinationAlt1(double liveEventId,
        double userId,
        UsersLiveEventsDestinationsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/destinations"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<EventDestination>(),
            CreateLiveEventDestinationAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Create an event OTT destination
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OttDestination"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateOttDestinationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates an OTT channel as the destination of the specified event. The authenticated user must be the owner of the event.
    /// </remarks>
    public Task<OttDestination> CreateOttDestination(double liveEventId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/ott_destinations"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<OttDestination>(),
            CreateOttDestinationErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete an event destination
    /// </summary>
    /// <param name="destinationId">The ID of the event destination.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteLiveEventDestinationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified event destination belonging to the authenticated user.
    /// </remarks>
    public Task DeleteLiveEventDestination(double destinationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/destination/{destination_id}"),
            [new TemplateParam("destination_id", destinationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteLiveEventDestinationErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete an event OTT destination
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="destinationId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteOttDestinationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes an OTT channel as the destination of the specified event. The authenticated user must be the owner of the event.
    /// </remarks>
    public Task DeleteOttDestination(double liveEventId,
        double userId,
        string destinationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/ott_destination/{destination_id}"),
            [new TemplateParam("live_event_id", liveEventId),
                new TemplateParam("user_id", userId),
                new TemplateParam("destination_id", destinationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteOttDestinationErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all available event destinations for the user to stream to
    /// </summary>
    /// <param name="userId">The user ID of the team owner.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAvailableDestinationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every available event destination for the authenticated user to stream to.
    /// </remarks>
    public Task GetAvailableDestinations(double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/destinations"),
            [new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetAvailableDestinationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all available event destinations for the user to stream to
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAvailableDestinationsAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every available event destination for the authenticated user to stream to.
    /// </remarks>
    public Task GetAvailableDestinationsAlt1(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/destinations"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetAvailableDestinationsAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get an event destination
    /// </summary>
    /// <param name="destinationId">The ID of the event destination.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventDestination"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventDestinationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the specified event destination belonging to the authenticated user.
    /// </remarks>
    public Task<EventDestination> GetLiveEventDestination(double destinationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/destination/{destination_id}"),
            [new TemplateParam("destination_id", destinationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EventDestination>(),
            GetLiveEventDestinationErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the destinations of a recurring event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventDestinationConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventDestinationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every destination of the specified event. The authenticated user must be the owner of the event.
    /// </remarks>
    public Task<EventDestinationConnection> GetLiveEventDestinations(double liveEventId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/live_events/{live_event_id}/destinations"),
            [new TemplateParam("live_event_id", liveEventId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EventDestinationConnection>(),
            GetLiveEventDestinationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the destinations of a recurring event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventDestinationConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLiveEventDestinationsAlt1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every destination of the specified event. The authenticated user must be the owner of the event.
    /// </remarks>
    public Task<EventDestinationConnection> GetLiveEventDestinationsAlt1(double liveEventId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/destinations"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EventDestinationConnection>(),
            GetLiveEventDestinationsAlt1ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the OTT destinations of a recurring event
    /// </summary>
    /// <param name="liveEventId">The ID of the event.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OttDestinationConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetOttDestinationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns every OTT destination of the specified event. The authenticated user must be the owner of the event.
    /// </remarks>
    public Task<OttDestinationConnection> GetOttDestinations(double liveEventId,
        double userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/live_events/{live_event_id}/ott_destinations"),
            [new TemplateParam("live_event_id", liveEventId), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OttDestinationConnection>(),
            GetOttDestinationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Update an event destination
    /// </summary>
    /// <param name="destinationId">The ID of the event destination.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EventDestination"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateLiveEventDestinationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method updates the specified event destination belonging to the authenticated user.
    /// </remarks>
    public Task<EventDestination> UpdateLiveEventDestination(double destinationId,
        DestinationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/destination/{destination_id}"),
            [new TemplateParam("destination_id", destinationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<EventDestination>(),
            UpdateLiveEventDestinationErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
