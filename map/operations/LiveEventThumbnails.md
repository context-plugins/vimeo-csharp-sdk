<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveEventThumbnails — operations

Accessor: `client.LiveEventThumbnails` · Source: `Api/LiveEventThumbnails.cs` · 15 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateLiveEventThumbnail

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateLiveEventThumbnail(double liveEventId, double userId, UsersLiveEventsPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<CreateLiveEventThumbnailError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsPicturesRequest` | `Models/UsersLiveEventsPicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `CreateLiveEventThumbnailError` | `Errors/CreateLiveEventThumbnailError.cs` |
| `Error` | `Models/Error.cs` |

### CreateLiveEventThumbnailAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateLiveEventThumbnailAlt1(double liveEventId, LiveEventsPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<CreateLiveEventThumbnailAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsPicturesRequest` | `Models/LiveEventsPicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `CreateLiveEventThumbnailAlt1Error` | `Errors/CreateLiveEventThumbnailAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### CreateLiveEventThumbnailAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateLiveEventThumbnailAlt2(double liveEventId, MeLiveEventsPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<CreateLiveEventThumbnailAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsPicturesRequest` | `Models/MeLiveEventsPicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `CreateLiveEventThumbnailAlt2Error` | `Errors/CreateLiveEventThumbnailAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### DeleteLiveEventThumbnail

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteLiveEventThumbnail(double liveEventId, double thumbnailId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteLiveEventThumbnailError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteLiveEventThumbnailError` | `Errors/DeleteLiveEventThumbnailError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteLiveEventThumbnailAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteLiveEventThumbnailAlt1(double liveEventId, double thumbnailId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteLiveEventThumbnailAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteLiveEventThumbnailAlt1Error` | `Errors/DeleteLiveEventThumbnailAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### DeleteLiveEventThumbnailAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteLiveEventThumbnailAlt2(double liveEventId, double thumbnailId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteLiveEventThumbnailAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteLiveEventThumbnailAlt2Error` | `Errors/DeleteLiveEventThumbnailAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### EditLiveEventThumbnail

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditLiveEventThumbnail(double liveEventId, double thumbnailId, double userId, UsersLiveEventsPicturesThumbnailIdRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<EditLiveEventThumbnailError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsPicturesThumbnailIdRequest` | `Models/UsersLiveEventsPicturesThumbnailIdRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `EditLiveEventThumbnailError` | `Errors/EditLiveEventThumbnailError.cs` |
| `Error` | `Models/Error.cs` |

### EditLiveEventThumbnailAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditLiveEventThumbnailAlt1(double liveEventId, double thumbnailId, LiveEventsPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<EditLiveEventThumbnailAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsPicturesRequest` | `Models/LiveEventsPicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `EditLiveEventThumbnailAlt1Error` | `Errors/EditLiveEventThumbnailAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### EditLiveEventThumbnailAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditLiveEventThumbnailAlt2(double liveEventId, double thumbnailId, MeLiveEventsPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<EditLiveEventThumbnailAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsPicturesRequest` | `Models/MeLiveEventsPicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `EditLiveEventThumbnailAlt2Error` | `Errors/EditLiveEventThumbnailAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventThumbnail

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventThumbnail(double liveEventId, double thumbnailId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetLiveEventThumbnailError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetLiveEventThumbnailError` | `Errors/GetLiveEventThumbnailError.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventThumbnailAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventThumbnailAlt1(double liveEventId, double thumbnailId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetLiveEventThumbnailAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetLiveEventThumbnailAlt1Error` | `Errors/GetLiveEventThumbnailAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventThumbnailAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventThumbnailAlt2(double liveEventId, double thumbnailId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetLiveEventThumbnailAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetLiveEventThumbnailAlt2Error` | `Errors/GetLiveEventThumbnailAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventThumbnails

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventThumbnails(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<GetLiveEventThumbnailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |
| `GetLiveEventThumbnailsError` | `Errors/GetLiveEventThumbnailsError.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventThumbnailsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventThumbnailsAlt1(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<GetLiveEventThumbnailsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |
| `GetLiveEventThumbnailsAlt1Error` | `Errors/GetLiveEventThumbnailsAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventThumbnailsAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventThumbnailsAlt2(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<GetLiveEventThumbnailsAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |
| `GetLiveEventThumbnailsAlt2Error` | `Errors/GetLiveEventThumbnailsAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

