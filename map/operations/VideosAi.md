<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosAi — operations

Accessor: `client.VideosAi` · Source: `Api/VideosAi.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AskAiQuestion

- **Signature**: `AskAiQuestion(double videoId, VideosAiAskRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<AskAiQuestionError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 503] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosAiAskRequest` | `Models/VideosAiAskRequest.cs` |
| `AskAiQuestionError` | `Errors/AskAiQuestionError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditAiTexttrack

- **Signature**: `EditAiTexttrack(double texttrackId, double videoId, VideosAiTexttracksRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<EditAiTexttrackError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 503] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosAiTexttracksRequest` | `Models/VideosAiTexttracksRequest.cs` |
| `EditAiTexttrackError` | `Errors/EditAiTexttrackError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAiLanguages

- **Signature**: `GetAiLanguages(Type52? type, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `type` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `type` ← `type`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetAiLanguagesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Type52` | `Models/Enums/Type52.cs` |
| `GetAiLanguagesError` | `Errors/GetAiLanguagesError.cs` |
| `Error` | `Models/Error.cs` |

### GetAiMetadata

- **Signature**: `GetAiMetadata(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetAiMetadataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 503] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAiMetadataError` | `Errors/GetAiMetadataError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAiQuestions

- **Signature**: `GetAiQuestions(double videoId, string? language, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `language` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `language` ← `language`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetAiQuestionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 503] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAiQuestionsError` | `Errors/GetAiQuestionsError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAiTranscribeStatus

- **Signature**: `GetAiTranscribeStatus(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetAiTranscribeStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAiTranscribeStatusError` | `Errors/GetAiTranscribeStatusError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAiTranslateDubbingStatus

- **Signature**: `GetAiTranslateDubbingStatus(double videoId, string? language, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `language` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `language` ← `language`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetAiTranslateDubbingStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 503] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAiTranslateDubbingStatusError` | `Errors/GetAiTranslateDubbingStatusError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAiTranslateSubtitlesStatus

- **Signature**: `GetAiTranslateSubtitlesStatus(double videoId, string? language, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `language` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `language` ← `language`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetAiTranslateSubtitlesStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 503] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAiTranslateSubtitlesStatusError` | `Errors/GetAiTranslateSubtitlesStatusError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### StartAiTranscribe

- **Signature**: `StartAiTranscribe(double videoId, VideosAiTranscribeRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<StartAiTranscribeError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosAiTranscribeRequest` | `Models/VideosAiTranscribeRequest.cs` |
| `StartAiTranscribeError` | `Errors/StartAiTranscribeError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### StartAiTranslateDubbing

- **Signature**: `StartAiTranslateDubbing(double videoId, VideosAiTranslateDubbingRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<StartAiTranslateDubbingError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 503] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosAiTranslateDubbingRequest` | `Models/VideosAiTranslateDubbingRequest.cs` |
| `StartAiTranslateDubbingError` | `Errors/StartAiTranslateDubbingError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### StartAiTranslateSubtitles

- **Signature**: `StartAiTranslateSubtitles(double videoId, VideosAiTranslateSubtitlesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<StartAiTranslateSubtitlesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 503] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosAiTranslateSubtitlesRequest` | `Models/VideosAiTranslateSubtitlesRequest.cs` |
| `StartAiTranslateSubtitlesError` | `Errors/StartAiTranslateSubtitlesError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

