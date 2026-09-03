<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosCreativeCommons — operations

Accessor: `client.VideosCreativeCommons` · Source: `Api/VideosCreativeCommons.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCcLicenses

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetCcLicenses(double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `CreativeCommonsConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreativeCommonsConnection` | `Models/CreativeCommonsConnection.cs` |

