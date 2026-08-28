<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosThumbnails — operations

Accessor: `client.VideosThumbnails` · Source: `Api/VideosThumbnails.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateVideoThumbnail

- **Signature**: `CreateVideoThumbnail(double videoId, VideosPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VideosPicturesRequest` | `Models/VideosPicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |

### CreateVideoThumbnailAlt1

- **Signature**: `CreateVideoThumbnailAlt1(double channelId, double videoId, ChannelsVideosPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ChannelsVideosPicturesRequest` | `Models/ChannelsVideosPicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |

### DeleteVideoThumbnail

- **Signature**: `DeleteVideoThumbnail(double pictureId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### EditVideoThumbnail

- **Signature**: `EditVideoThumbnail(double pictureId, double videoId, VideosPicturesRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VideosPicturesRequest1` | `Models/VideosPicturesRequest1.cs` |
| `Picture` | `Models/Picture.cs` |

### GetVideoThumbnail

- **Signature**: `GetVideoThumbnail(double pictureId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |

### GetVideoThumbnails

- **Signature**: `GetVideoThumbnails(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |

### GetVideoThumbnailsAlt1

- **Signature**: `GetVideoThumbnailsAlt1(double channelId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |

