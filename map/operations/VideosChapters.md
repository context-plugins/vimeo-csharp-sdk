<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosChapters — operations

Accessor: `client.VideosChapters` · Source: `Api/VideosChapters.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateChapter

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateChapter(double videoId, VideosChaptersRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Chapter`
- **Error**: `SdkException<CreateChapterError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosChaptersRequest` | `Models/VideosChaptersRequest.cs` |
| `Chapter` | `Models/Chapter.cs` |
| `CreateChapterError` | `Errors/CreateChapterError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CreateChapterThumbnailOrUploadLink

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateChapterThumbnailOrUploadLink(double chapterId, double videoId, VideosChaptersPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<CreateChapterThumbnailOrUploadLinkError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosChaptersPicturesRequest` | `Models/VideosChaptersPicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `CreateChapterThumbnailOrUploadLinkError` | `Errors/CreateChapterThumbnailOrUploadLinkError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CreateUnsavedChapterThumbnailOrUploadLink

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateUnsavedChapterThumbnailOrUploadLink(double videoId, VideosChaptersTemporaryPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<CreateUnsavedChapterThumbnailOrUploadLinkError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosChaptersTemporaryPicturesRequest` | `Models/VideosChaptersTemporaryPicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `CreateUnsavedChapterThumbnailOrUploadLinkError` | `Errors/CreateUnsavedChapterThumbnailOrUploadLinkError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteChapter

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteChapter(double chapterId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteChapterError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteChapterError` | `Errors/DeleteChapterError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteChapterThumbnail

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteChapterThumbnail(double chapterId, string uid, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteChapterThumbnailError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteChapterThumbnailError` | `Errors/DeleteChapterThumbnailError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditChapter

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditChapter(double chapterId, double videoId, VideosChaptersRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Chapter`
- **Error**: `SdkException<EditChapterError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosChaptersRequest1` | `Models/VideosChaptersRequest1.cs` |
| `Chapter` | `Models/Chapter.cs` |
| `EditChapterError` | `Errors/EditChapterError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetChapter

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChapter(double chapterId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Chapter`
- **Error**: `SdkException<GetChapterError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Chapter` | `Models/Chapter.cs` |
| `GetChapterError` | `Errors/GetChapterError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetChapterThumbnail

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChapterThumbnail(double chapterId, double videoId, string uid, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetChapterThumbnailError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetChapterThumbnailError` | `Errors/GetChapterThumbnailError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetChapterThumbnails

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChapterThumbnails(double chapterId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetChapterThumbnailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetChapterThumbnailsError` | `Errors/GetChapterThumbnailsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetChapters

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChapters(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `ChapterConnection`
- **Error**: `SdkException<GetChaptersError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChapterConnection` | `Models/ChapterConnection.cs` |
| `GetChaptersError` | `Errors/GetChaptersError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetUnsavedChapterThumbnail

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetUnsavedChapterThumbnail(double videoId, string uid, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetUnsavedChapterThumbnailError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetUnsavedChapterThumbnailError` | `Errors/GetUnsavedChapterThumbnailError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### SetChapterThumbnailActive

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SetChapterThumbnailActive(double chapterId, double videoId, string uid, VideosChaptersPicturesUidRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<SetChapterThumbnailActiveError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosChaptersPicturesUidRequest` | `Models/VideosChaptersPicturesUidRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `SetChapterThumbnailActiveError` | `Errors/SetChapterThumbnailActiveError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

