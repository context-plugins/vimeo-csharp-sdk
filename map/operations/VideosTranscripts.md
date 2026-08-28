<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosTranscripts — operations

Accessor: `client.VideosTranscripts` · Source: `Api/VideosTranscripts.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTranscript

- **Signature**: `GetTranscript(double texttrackId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SegmentConnection`
- **Error**: `SdkException<GetTranscriptError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SegmentConnection` | `Models/SegmentConnection.cs` |
| `GetTranscriptError` | `Errors/GetTranscriptError.cs` |
| `Error` | `Models/Error.cs` |

### GetTranscriptMetadata

- **Signature**: `GetTranscriptMetadata(string containerUuid, double texttrackId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TranscriptMetadata`
- **Error**: `SdkException<GetTranscriptMetadataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TranscriptMetadata` | `Models/TranscriptMetadata.cs` |
| `GetTranscriptMetadataError` | `Errors/GetTranscriptMetadataError.cs` |
| `Error` | `Models/Error.cs` |

