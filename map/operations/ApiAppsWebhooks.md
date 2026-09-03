<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiAppsWebhooks — operations

Accessor: `client.ApiAppsWebhooks` · Source: `Api/ApiAppsWebhooks.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddWebhook

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddWebhook(double appId, AppsWebhooksRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ApiAppWebhook`
- **Error**: `SdkException<AddWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AppsWebhooksRequest` | `Models/AppsWebhooksRequest.cs` |
| `ApiAppWebhook` | `Models/ApiAppWebhook.cs` |
| `AddWebhookError` | `Errors/AddWebhookError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteWebhook

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteWebhook(double appId, double webhookId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteWebhookError` | `Errors/DeleteWebhookError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetWebhook

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetWebhook(double appId, double webhookId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ApiAppWebhook`
- **Error**: `SdkException<GetWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiAppWebhook` | `Models/ApiAppWebhook.cs` |
| `GetWebhookError` | `Errors/GetWebhookError.cs` |
| `Error` | `Models/Error.cs` |

### GetWebhooks

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetWebhooks(double appId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `ApiAppWebhookConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ApiAppWebhookConnection` | `Models/ApiAppWebhookConnection.cs` |

### UpdateWebhook

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `UpdateWebhook(double appId, double webhookId, AppsWebhooksRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `ApiAppWebhook`
- **Error**: `SdkException<UpdateWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AppsWebhooksRequest1` | `Models/AppsWebhooksRequest1.cs` |
| `ApiAppWebhook` | `Models/ApiAppWebhook.cs` |
| `UpdateWebhookError` | `Errors/UpdateWebhookError.cs` |
| `Error` | `Models/Error.cs` |

