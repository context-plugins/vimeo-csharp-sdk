<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosFragments — operations

Accessor: `client.VideosFragments` · Source: `Api/VideosFragments.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteFragments

- **Signature**: `DeleteFragments(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### GetFragments

- **Signature**: `GetFragments(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Fragments`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Fragments` | `Models/Fragments.cs` |

### PutFragments

- **Signature**: `PutFragments(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

