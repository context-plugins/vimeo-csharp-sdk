<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChannelsCategories — operations

Accessor: `client.ChannelsCategories` · Source: `Api/ChannelsCategories.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddChannelCategories

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddChannelCategories(double channelId, ChannelsCategoriesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddChannelCategoriesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsCategoriesRequest` | `Models/ChannelsCategoriesRequest.cs` |
| `AddChannelCategoriesError` | `Errors/AddChannelCategoriesError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CategorizeChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CategorizeChannel(string category, double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CategorizeChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CategorizeChannelError` | `Errors/CategorizeChannelError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteChannelCategory

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteChannelCategory(string category, double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteChannelCategoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteChannelCategoryError` | `Errors/DeleteChannelCategoryError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetChannelCategories

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChannelCategories(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CategoryConnection`
- **Error**: `SdkException<GetChannelCategoriesError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CategoryConnection` | `Models/CategoryConnection.cs` |
| `GetChannelCategoriesError` | `Errors/GetChannelCategoriesError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

