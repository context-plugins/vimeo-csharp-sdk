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

namespace Vimeo.Api;

/// <summary>
/// These are the most common methods for making product purchases.
/// </summary>
public sealed class PaymentsEssentials
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PaymentsEssentials(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a payments service payment method
    /// </summary>
    /// <param name="paymentMethodId">The ID of the payment method.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeletePaymentMethodError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method deletes the specified Vimeo payments service payment method.
    /// </remarks>
    public Task DeletePaymentMethod(string paymentMethodId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/payment_methods/{payment_method_id}"),
            [new TemplateParam("payment_method_id", paymentMethodId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeletePaymentMethodErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get information about a payments service payment method
    /// </summary>
    /// <param name="paymentMethodId">The ID of the payment method.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentMethod"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPaymentMethodInfoError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns information about the specified Vimeo payments service payment method.
    /// </remarks>
    public Task<PaymentMethod> GetPaymentMethodInfo(string paymentMethodId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/payment_methods/{payment_method_id}"),
            [new TemplateParam("payment_method_id", paymentMethodId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentMethod>(),
            GetPaymentMethodInfoErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get information about a payments service subscription
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription.</param>
    /// <param name="userId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns information about the specified Vimeo payments service subscription.
    /// </remarks>
    public Task GetSubscriptionInfo(string subscriptionId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/subscriptions/{subscription_id}"),
            [new TemplateParam("subscription_id", subscriptionId), new TemplateParam("user_id", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of all payments service payment methods
    /// </summary>
    /// <param name="cardmemberName">The name of the card member.</param>
    /// <param name="page">The page number of the results to show.</param>
    /// <param name="perPage">The number of items to show on each page of results, up to a maximum of 100.</param>
    /// <param name="showDisabled">Whether to return disabled payment methods.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentMethodConnection"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ListPaymentMethodsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns a list of all Vimeo payments service payment methods that are available to the authenticated user.
    /// </remarks>
    public Task<PaymentMethodConnection> ListPaymentMethods(string? cardmemberName,
        double? page,
        double? perPage,
        bool? showDisabled,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/me/payment_methods"),
            [],
            [new Param("cardmember_name", cardmemberName),
                new Param("page", page),
                new Param("per_page", perPage),
                new Param("show_disabled", showDisabled)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentMethodConnection>(),
            ListPaymentMethodsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
