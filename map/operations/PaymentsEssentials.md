<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentsEssentials — operations

Accessor: `client.PaymentsEssentials` · Source: `Api/PaymentsEssentials.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeletePaymentMethod

- **Signature**: `DeletePaymentMethod(string paymentMethodId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeletePaymentMethodError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePaymentMethodError` | `Errors/DeletePaymentMethodError.cs` |
| `Error` | `Models/Error.cs` |

### GetPaymentMethodInfo

- **Signature**: `GetPaymentMethodInfo(string paymentMethodId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentMethod`
- **Error**: `SdkException<GetPaymentMethodInfoError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PaymentMethod` | `Models/PaymentMethod.cs` |
| `GetPaymentMethodInfoError` | `Errors/GetPaymentMethodInfoError.cs` |
| `Error` | `Models/Error.cs` |

### GetSubscriptionInfo

- **Signature**: `GetSubscriptionInfo(string subscriptionId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### ListPaymentMethods

- **Signature**: `ListPaymentMethods(string? cardmemberName, double? page, double? perPage, bool? showDisabled, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`cardmemberName` … `showDisabled`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `cardmember_name` ← `cardmemberName`, `page` ← `page`, `per_page` ← `perPage`, `show_disabled` ← `showDisabled`
- **Returns**: `PaymentMethodConnection`
- **Error**: `SdkException<ListPaymentMethodsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PaymentMethodConnection` | `Models/PaymentMethodConnection.cs` |
| `ListPaymentMethodsError` | `Errors/ListPaymentMethodsError.cs` |
| `Error` | `Models/Error.cs` |

