<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosUploads — operations

Accessor: `client.VideosUploads` · Source: `Api/VideosUploads.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CompleteStreamingUpload

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CompleteStreamingUpload(double uploadId, double userId, string signature, double videoFileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `signature` ← `signature`, `video_file_id` ← `videoFileId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CompleteStreamingUploadError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CompleteStreamingUploadError` | `Errors/CompleteStreamingUploadError.cs` |
| `Error` | `Models/Error.cs` |

### GetUploadAttempt

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetUploadAttempt(double uploadId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UploadAttempt`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UploadAttempt` | `Models/UploadAttempt.cs` |

### UploadVideo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `UploadVideo(double userId, UsersVideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<UploadVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersVideosRequest1` | `Models/UsersVideosRequest1.cs` |
| `Video` | `Models/Video.cs` |
| `UploadVideoError` | `Errors/UploadVideoError.cs` |
| `Error` | `Models/Error.cs` |

### UploadVideoAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `UploadVideoAlt1(MeVideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<UploadVideoAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeVideosRequest1` | `Models/MeVideosRequest1.cs` |
| `Video` | `Models/Video.cs` |
| `UploadVideoAlt1Error` | `Errors/UploadVideoAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

