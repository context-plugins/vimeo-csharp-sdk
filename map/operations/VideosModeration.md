<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosModeration — operations

Accessor: `client.VideosModeration` · Source: `Api/VideosModeration.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetVideoReportingReasons

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoReportingReasons(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `VideoReportReason`
- **Error**: `SdkException<GetVideoReportingReasonsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideoReportReason` | `Models/VideoReportReason.cs` |
| `GetVideoReportingReasonsError` | `Errors/GetVideoReportingReasonsError.cs` |
| `Error` | `Models/Error.cs` |

