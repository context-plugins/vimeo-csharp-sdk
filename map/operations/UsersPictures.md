<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersPictures — operations

Accessor: `client.UsersPictures` · Source: `Api/UsersPictures.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreatePicture

- **Signature**: `CreatePicture(double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |

### CreatePictureAlt1

- **Signature**: `CreatePictureAlt1(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |

### DeletePicture

- **Signature**: `DeletePicture(double portraitsetId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### DeletePictureAlt1

- **Signature**: `DeletePictureAlt1(double portraitsetId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### EditPicture

- **Signature**: `EditPicture(double portraitsetId, double userId, UsersPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersPicturesRequest` | `Models/UsersPicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |

### EditPictureAlt1

- **Signature**: `EditPictureAlt1(double portraitsetId, MePicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `MePicturesRequest` | `Models/MePicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |

### GetPicture

- **Signature**: `GetPicture(double portraitsetId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |

### GetPictureAlt1

- **Signature**: `GetPictureAlt1(double portraitsetId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |

### GetPictures

- **Signature**: `GetPictures(double userId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |

### GetPicturesAlt1

- **Signature**: `GetPicturesAlt1(double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |

