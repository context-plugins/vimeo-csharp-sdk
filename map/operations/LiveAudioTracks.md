<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveAudioTracks — operations

Accessor: `client.LiveAudioTracks` · Source: `Api/LiveAudioTracks.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetEventAudioTracks

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetEventAudioTracks(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EventAudioTracks`
- **Error**: `SdkException<GetEventAudioTracksError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EventAudioTracks` | `Models/EventAudioTracks.cs` |
| `GetEventAudioTracksError` | `Errors/GetEventAudioTracksError.cs` |
| `Error` | `Models/Error.cs` |

### UpdateEventAudioTracks

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `UpdateEventAudioTracks(double liveEventId, LiveEventsAudioTracksRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `EventAudioTracks`
- **Error**: `SdkException<UpdateEventAudioTracksError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsAudioTracksRequest` | `Models/LiveEventsAudioTracksRequest.cs` |
| `EventAudioTracks` | `Models/EventAudioTracks.cs` |
| `UpdateEventAudioTracksError` | `Errors/UpdateEventAudioTracksError.cs` |
| `Error` | `Models/Error.cs` |

