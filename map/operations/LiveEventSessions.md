<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveEventSessions — operations

Accessor: `client.LiveEventSessions` · Source: `Api/LiveEventSessions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetLiveClipIngestStatus

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveClipIngestStatus(string liveEventId, double? clipId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `clipId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `clip_id` ← `clipId`
- **Returns**: `EventSessionStatus`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EventSessionStatus` | `Models/EventSessionStatus.cs` |

### GetLiveIngestStatus

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveIngestStatus(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EventSessionStatus`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EventSessionStatus` | `Models/EventSessionStatus.cs` |

