<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersAnalytics — operations

Accessor: `client.UsersAnalytics` · Source: `Api/UsersAnalytics.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetUserAnalytics

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetUserAnalytics(double userId, Dimension dimension, string from, string to, Direction? direction, string? filterContent, IReadOnlyList<string>? filterCountries, string? filterCustomMetadata, IReadOnlyList<string>? filterDeviceTypes, IReadOnlyList<string>? filterEmbedDomains, IReadOnlyList<string>? filterRegions, IReadOnlyList<string>? filterStreamingTypes, string? filterWorkspaces, double? page, double? perPage, Sort22? sort, TimeInterval? timeInterval, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 13 params (`direction` … `timeInterval`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `dimension` ← `dimension`, `from` ← `from`, `to` ← `to`, `direction` ← `direction`, `filter_content` ← `filterContent`, `filter_countries` ← `filterCountries`, `filter_custom_metadata` ← `filterCustomMetadata`, `filter_device_types` ← `filterDeviceTypes`, `filter_embed_domains` ← `filterEmbedDomains`, `filter_regions` ← `filterRegions`, `filter_streaming_types` ← `filterStreamingTypes`, `filter_workspaces` ← `filterWorkspaces`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`, `time_interval` ← `timeInterval`
- **Returns**: `AnalyticsConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Dimension` | `Models/Enums/Dimension.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort22` | `Models/Enums/Sort22.cs` |
| `TimeInterval` | `Models/Enums/TimeInterval.cs` |
| `AnalyticsConnection` | `Models/AnalyticsConnection.cs` |

### GetUserAnalyticsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetUserAnalyticsAlt1(Dimension dimension, string from, string to, Direction? direction, string? filterContent, IReadOnlyList<string>? filterCountries, string? filterCustomMetadata, IReadOnlyList<string>? filterDeviceTypes, IReadOnlyList<string>? filterEmbedDomains, IReadOnlyList<string>? filterRegions, IReadOnlyList<string>? filterStreamingTypes, string? filterWorkspaces, double? page, double? perPage, Sort22? sort, TimeInterval? timeInterval, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 13 params (`direction` … `timeInterval`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `dimension` ← `dimension`, `from` ← `from`, `to` ← `to`, `direction` ← `direction`, `filter_content` ← `filterContent`, `filter_countries` ← `filterCountries`, `filter_custom_metadata` ← `filterCustomMetadata`, `filter_device_types` ← `filterDeviceTypes`, `filter_embed_domains` ← `filterEmbedDomains`, `filter_regions` ← `filterRegions`, `filter_streaming_types` ← `filterStreamingTypes`, `filter_workspaces` ← `filterWorkspaces`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`, `time_interval` ← `timeInterval`
- **Returns**: `AnalyticsConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Dimension` | `Models/Enums/Dimension.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort22` | `Models/Enums/Sort22.cs` |
| `TimeInterval` | `Models/Enums/TimeInterval.cs` |
| `AnalyticsConnection` | `Models/AnalyticsConnection.cs` |

