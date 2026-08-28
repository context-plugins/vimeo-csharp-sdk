<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveAnalytics — operations

Accessor: `client.LiveAnalytics` · Source: `Api/LiveAnalytics.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ExportVpaasViewerAnalytics

- **Signature**: `ExportVpaasViewerAnalytics(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<ExportVpaasViewerAnalyticsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ExportVpaasViewerAnalyticsError` | `Errors/ExportVpaasViewerAnalyticsError.cs` |
| `Error` | `Models/Error.cs` |

