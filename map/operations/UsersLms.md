<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersLms — operations

Accessor: `client.UsersLms` · Source: `Api/UsersLms.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DownloadLmsPackage

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DownloadLmsPackage(double userId, double videoId, double? completionThreshold, string? courseTitle, double? passingScore, ScoringAlgorithm? scoringAlgorithm, Standard? standard, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`completionThreshold` … `standard`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `completion_threshold` ← `completionThreshold`, `course_title` ← `courseTitle`, `passing_score` ← `passingScore`, `scoring_algorithm` ← `scoringAlgorithm`, `standard` ← `standard`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DownloadLmsPackageError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ScoringAlgorithm` | `Models/Enums/ScoringAlgorithm.cs` |
| `Standard` | `Models/Enums/Standard.cs` |
| `DownloadLmsPackageError` | `Errors/DownloadLmsPackageError.cs` |

