<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveGraphics — operations

Accessor: `client.LiveGraphics` · Source: `Api/LiveGraphics.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddComposerVideoGraphicItem

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddComposerVideoGraphicItem(double liveEventId, LiveEventsComposerGraphicsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ComposerGraphics`
- **Error**: `SdkException<AddComposerVideoGraphicItemError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsComposerGraphicsVideosRequest` | `Models/LiveEventsComposerGraphicsVideosRequest.cs` |
| `ComposerGraphics` | `Models/ComposerGraphics.cs` |
| `AddComposerVideoGraphicItemError` | `Errors/AddComposerVideoGraphicItemError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteComposerVideoGraphicItem

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteComposerVideoGraphicItem(double liveEventId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteComposerVideoGraphicItemError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteComposerVideoGraphicItemError` | `Errors/DeleteComposerVideoGraphicItemError.cs` |
| `Error` | `Models/Error.cs` |

### GetComposerVideoGraphicItems

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetComposerVideoGraphicItems(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ComposerGraphicsConnection`
- **Error**: `SdkException<GetComposerVideoGraphicItemsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ComposerGraphicsConnection` | `Models/ComposerGraphicsConnection.cs` |
| `GetComposerVideoGraphicItemsError` | `Errors/GetComposerVideoGraphicItemsError.cs` |
| `Error` | `Models/Error.cs` |

