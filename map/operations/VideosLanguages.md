<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosLanguages — operations

Accessor: `client.VideosLanguages` · Source: `Api/VideosLanguages.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetLanguages

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLanguages(Filter7? filter, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `LanguageConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Filter7` | `Models/Enums/Filter7.cs` |
| `LanguageConnection` | `Models/LanguageConnection.cs` |

