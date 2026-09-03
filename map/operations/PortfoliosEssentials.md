<!-- Generated file — do not edit; regenerated with the SDK. -->

# PortfoliosEssentials — operations

Accessor: `client.PortfoliosEssentials` · Source: `Api/PortfoliosEssentials.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPortfolio

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetPortfolio(double portfolioId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Portfolio`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Portfolio` | `Models/Portfolio.cs` |

### GetPortfolioAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetPortfolioAlt1(double portfolioId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Portfolio`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Portfolio` | `Models/Portfolio.cs` |

### GetPortfolios

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetPortfolios(double userId, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `PortfolioConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `PortfolioConnection` | `Models/PortfolioConnection.cs` |

### GetPortfoliosAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetPortfoliosAlt1(Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `PortfolioConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `PortfolioConnection` | `Models/PortfolioConnection.cs` |

