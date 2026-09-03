<!-- Generated file — do not edit; regenerated with the SDK. -->

# TagsEssentials — operations

Accessor: `client.TagsEssentials` · Source: `Api/TagsEssentials.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTag

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetTag(string word, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Tag`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Tag` | `Models/Tag.cs` |

