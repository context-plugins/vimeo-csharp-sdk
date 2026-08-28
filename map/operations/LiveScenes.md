<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveScenes — operations

Accessor: `client.LiveScenes` · Source: `Api/LiveScenes.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AttachGraphicItemToScene

- **Signature**: `AttachGraphicItemToScene(double liveEventId, string sceneId, LiveEventsComposerScenesGraphicsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ComposerScenes`
- **Error**: `SdkException<AttachGraphicItemToSceneError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsComposerScenesGraphicsRequest` | `Models/LiveEventsComposerScenesGraphicsRequest.cs` |
| `ComposerScenes` | `Models/ComposerScenes.cs` |
| `AttachGraphicItemToSceneError` | `Errors/AttachGraphicItemToSceneError.cs` |
| `Error` | `Models/Error.cs` |

### CreateComposerScene

- **Signature**: `CreateComposerScene(double liveEventId, LiveEventsComposerScenesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ComposerScenes`
- **Error**: `SdkException<CreateComposerSceneError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsComposerScenesRequest` | `Models/LiveEventsComposerScenesRequest.cs` |
| `ComposerScenes` | `Models/ComposerScenes.cs` |
| `CreateComposerSceneError` | `Errors/CreateComposerSceneError.cs` |
| `Error` | `Models/Error.cs` |

### GetComposerScenes

- **Signature**: `GetComposerScenes(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ComposerScenesConnection`
- **Error**: `SdkException<GetComposerScenesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ComposerScenesConnection` | `Models/ComposerScenesConnection.cs` |
| `GetComposerScenesError` | `Errors/GetComposerScenesError.cs` |
| `Error` | `Models/Error.cs` |

### ResetComposerScenes

- **Signature**: `ResetComposerScenes(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<ComposerScenes>`
- **Error**: `SdkException<ResetComposerScenesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ComposerScenes` | `Models/ComposerScenes.cs` |
| `ResetComposerScenesError` | `Errors/ResetComposerScenesError.cs` |
| `Error` | `Models/Error.cs` |

### UpdateComposerScene

- **Signature**: `UpdateComposerScene(double liveEventId, string sceneId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ComposerScenes`
- **Error**: `SdkException<UpdateComposerSceneError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ComposerScenes` | `Models/ComposerScenes.cs` |
| `UpdateComposerSceneError` | `Errors/UpdateComposerSceneError.cs` |
| `Error` | `Models/Error.cs` |

