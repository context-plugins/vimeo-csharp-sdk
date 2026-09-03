<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChannelsTags — operations

Accessor: `client.ChannelsTags` · Source: `Api/ChannelsTags.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddChannelTag

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddChannelTag(double channelId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddChannelTagError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetError(out Error)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddChannelTagError` | `Errors/AddChannelTagError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |
| `Error` | `Models/Error.cs` |

### AddTagsToChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddTagsToChannel(double channelId, IReadOnlyList<ChannelsTagsRequest> body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<Tag>`
- **Error**: `SdkException<AddTagsToChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetError(out Error)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsTagsRequest` | `Models/ChannelsTagsRequest.cs` |
| `Tag` | `Models/Tag.cs` |
| `AddTagsToChannelError` | `Errors/AddTagsToChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |
| `Error` | `Models/Error.cs` |

### CheckIfChannelHasTag

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CheckIfChannelHasTag(double channelId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CheckIfChannelHasTagError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckIfChannelHasTagError` | `Errors/CheckIfChannelHasTagError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteTagFromChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteTagFromChannel(double channelId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteTagFromChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetError(out Error)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTagFromChannelError` | `Errors/DeleteTagFromChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |
| `Error` | `Models/Error.cs` |

### GetChannelTags

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChannelTags(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TagConnection`
- **Error**: `SdkException<GetChannelTagsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TagConnection` | `Models/TagConnection.cs` |
| `GetChannelTagsError` | `Errors/GetChannelTagsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

