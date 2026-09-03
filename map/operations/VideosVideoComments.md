<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosVideoComments — operations

Accessor: `client.VideosVideoComments` · Source: `Api/VideosVideoComments.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateComment

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateComment(double videoId, VideosCommentsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Comment`
- **Error**: `SdkException<CreateCommentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosCommentsRequest` | `Models/VideosCommentsRequest.cs` |
| `Comment` | `Models/Comment.cs` |
| `CreateCommentError` | `Errors/CreateCommentError.cs` |
| `Error` | `Models/Error.cs` |

### CreateCommentAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateCommentAlt1(double channelId, double videoId, ChannelsVideosCommentsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Comment`
- **Error**: `SdkException<CreateCommentAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsVideosCommentsRequest` | `Models/ChannelsVideosCommentsRequest.cs` |
| `Comment` | `Models/Comment.cs` |
| `CreateCommentAlt1Error` | `Errors/CreateCommentAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### CreateCommentReply

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateCommentReply(double commentId, double videoId, VideosCommentsRepliesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Comment`
- **Error**: `SdkException<CreateCommentReplyError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosCommentsRepliesRequest` | `Models/VideosCommentsRepliesRequest.cs` |
| `Comment` | `Models/Comment.cs` |
| `CreateCommentReplyError` | `Errors/CreateCommentReplyError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteComment

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteComment(double commentId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteCommentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCommentError` | `Errors/DeleteCommentError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditComment

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditComment(double commentId, double videoId, VideosCommentsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Comment`
- **Error**: `SdkException<EditCommentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosCommentsRequest` | `Models/VideosCommentsRequest.cs` |
| `Comment` | `Models/Comment.cs` |
| `EditCommentError` | `Errors/EditCommentError.cs` |
| `Error` | `Models/Error.cs` |

### GetComment

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetComment(double commentId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Comment`
- **Error**: `SdkException<GetCommentError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Comment` | `Models/Comment.cs` |
| `GetCommentError` | `Errors/GetCommentError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetCommentReplies

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetCommentReplies(double commentId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `CommentConnection`
- **Error**: `SdkException<GetCommentRepliesError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CommentConnection` | `Models/CommentConnection.cs` |
| `GetCommentRepliesError` | `Errors/GetCommentRepliesError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetComments

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetComments(double videoId, Direction? direction, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `direction` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `CommentConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `CommentConnection` | `Models/CommentConnection.cs` |

### GetCommentsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetCommentsAlt1(double channelId, double videoId, Direction? direction, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `direction` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `CommentConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `CommentConnection` | `Models/CommentConnection.cs` |

