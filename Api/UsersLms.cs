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
using Vimeo.Models.Enums;

namespace Vimeo.Api;

/// <summary>
/// Use these methods to work with learning management systems.
/// </summary>
public sealed class UsersLms
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsersLms(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create and download a proxy package for upload to a learning management system
    /// </summary>
    /// <param name="userId">The ID of the team owner.</param>
    /// <param name="videoId">The ID of the course video.</param>
    /// <param name="completionThreshold">The completion threshold for the course.</param>
    /// <param name="courseTitle">The title of the course.</param>
    /// <param name="passingScore">The passing score for the course.</param>
    /// <param name="scoringAlgorithm">The scoring algorithm for the course.  Option descriptions:  * <c>passfail</c> - The score is based on a pass or fail.  * <c>percentage</c> - The score is based on a percentage.  * <c>quiz</c> - The score is based on the course quiz.</param>
    /// <param name="standard">The learning management system standard used to create the proxy package.  Option descriptions:  * <c>aicc</c> - The standard is AICC.  * <c>cmi5</c> - The standard is cmi5.  * <c>scorm12</c> - The standard is SCORM 1.2.  * <c>scorm2004_3rd</c> - The standard is SCORM 2004 3rd Edition.  * <c>tincan</c> - The standard is Tin Can or xAPI.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DownloadLmsPackageError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This method creates and returns a zipped proxy package of the course associated with the specified video. This package is suitable for direct upload to a learning management system.
    /// </remarks>
    public Task DownloadLmsPackage(double userId,
        double videoId,
        double? completionThreshold,
        string? courseTitle,
        double? passingScore,
        ScoringAlgorithm? scoringAlgorithm,
        Standard? standard,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/users/{user_id}/lms/download/{video_id}"),
            [new TemplateParam("user_id", userId), new TemplateParam("video_id", videoId)],
            [new Param("completion_threshold", completionThreshold),
                new Param("course_title", courseTitle),
                new Param("passing_score", passingScore),
                new Param("scoring_algorithm", scoringAlgorithm),
                new Param("standard", standard)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DownloadLmsPackageErrorResponse.Instance,
            [new AuthSchemeAny(_auth.Oauth2AuthorizationCode, _auth.Oauth2ClientCredentials, _auth.Bearer)],
            requestOptions,
            ct);
}
