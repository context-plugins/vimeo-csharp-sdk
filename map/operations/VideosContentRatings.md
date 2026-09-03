<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosContentRatings — operations

Accessor: `client.VideosContentRatings` · Source: `Api/VideosContentRatings.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetContentRatings

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetContentRatings(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ContentRatingConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContentRatingConnection` | `Models/ContentRatingConnection.cs` |

