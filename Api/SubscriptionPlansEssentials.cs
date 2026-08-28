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
using Vimeo.Models.Enums;

namespace Vimeo.Api;

/// <summary>
/// These are the most common methods for working with subscription plans.
/// </summary>
public sealed class SubscriptionPlansEssentials
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SubscriptionPlansEssentials(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a single subscription plan
    /// </summary>
    /// <param name="tier">The type of subscription plan.  Option descriptions:  * <c>advanced</c> - The plan type is Vimeo Advanced.  * <c>business</c> - The plan type is Vimeo Business.  * <c>free</c> - The plan type is Vimeo Free.  * <c>live_premium</c> - The plan type is Vimeo Premium.  * <c>plus</c> - The plan type is Vimeo Plus.  * <c>pro</c> - The plan type is Vimeo Pro.  * <c>pro_unlimited</c> - The plan type is Vimeo Pro Unlimited.  * <c>standard</c> - The plan type is Vimeo Standard.  * <c>starter</c> - The plan type is Vimeo Starter.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method returns the specified subscription plan.
    /// </remarks>
    public Task GetPlan(Tier1 tier, RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/subscription_plans/{tier}"),
            [new TemplateParam("tier", tier)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
