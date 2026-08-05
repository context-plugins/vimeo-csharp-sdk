# Reference

> Source: [VimeoApiClient](VimeoApiClient.cs)

## ApiAppsWebhooks

> Source: [ApiAppsWebhooks](Api/ApiAppsWebhooks.cs)

<details>
<summary><code>Task&lt;ApiAppWebhook&gt; AddWebhook(double appId, AppsWebhooksRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a webhook for the specified app.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiAppsWebhooks.AddWebhook(appId, body);
    // TODO: Handle 'response' of type ApiAppWebhook
}
catch (SdkException<AddWebhookError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddWebhookError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>appId</code> | <code>double</code> | The ID of the app for which the webhook is created. |
| <code>body</code> | <code>[AppsWebhooksRequest?](Models/AppsWebhooksRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiAppWebhook](Models/ApiAppWebhook.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddWebhookError](Errors/AddWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteWebhook(double appId, double webhookId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified webhook.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ApiAppsWebhooks.DeleteWebhook(appId, webhookId);
}
catch (SdkException<DeleteWebhookError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteWebhookError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>appId</code> | <code>double</code> | The ID of the app that the webhook is associated with. |
| <code>webhookId</code> | <code>double</code> | The ID of the webhook. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteWebhookError](Errors/DeleteWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiAppWebhook&gt; GetWebhook(double appId, double webhookId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified webhook.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiAppsWebhooks.GetWebhook(appId, webhookId);
    // TODO: Handle 'response' of type ApiAppWebhook
}
catch (SdkException<GetWebhookError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetWebhookError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>appId</code> | <code>double</code> | The ID of the app that the webhook is associated with. |
| <code>webhookId</code> | <code>double</code> | The ID of the webhook. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiAppWebhook](Models/ApiAppWebhook.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetWebhookError](Errors/GetWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiAppWebhookConnection&gt; GetWebhooks(double appId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every webhook for the specified app.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiAppsWebhooks.GetWebhooks(appId, page, perPage);
    // TODO: Handle 'response' of type ApiAppWebhookConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>appId</code> | <code>double</code> | The ID of the app that the webhook is associated with. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiAppWebhookConnection](Models/ApiAppWebhookConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApiAppWebhook&gt; UpdateWebhook(double appId, double webhookId, AppsWebhooksRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method updates the specified webhook.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiAppsWebhooks.UpdateWebhook(appId, webhookId, body);
    // TODO: Handle 'response' of type ApiAppWebhook
}
catch (SdkException<UpdateWebhookError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UpdateWebhookError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>appId</code> | <code>double</code> | The ID of the app that the webhook is associated with. |
| <code>webhookId</code> | <code>double</code> | The ID of the webhook. |
| <code>body</code> | <code>[AppsWebhooksRequest1?](Models/AppsWebhooksRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApiAppWebhook](Models/ApiAppWebhook.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateWebhookError](Errors/UpdateWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ApiInformationEssentials

> Source: [ApiInformationEssentials](Api/ApiInformationEssentials.cs)

<details>
<summary><code>Task GetEndpoints(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the full OpenAPI specification for the Vimeo API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ApiInformationEssentials.GetEndpoints();
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AuthenticationExtrasAuthenticate

> Source: [AuthenticationExtrasAuthenticate](Api/AuthenticationExtrasAuthenticate.cs)

<details>
<summary><code>Task&lt;Auth&gt; ClientAuth(OauthAuthorizeClientRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method uses the OAuth protocol to authorize a client. For details on OAuth client authorization, see our [Working with Authentication](/api/authentication) guide or the [OAuth spec](https://tools.ietf.org/html/draft-ietf-oauth-v2-31#section-4.4).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthenticationExtrasAuthenticate.ClientAuth(body);
    // TODO: Handle 'response' of type Auth
}
catch (SdkException<ClientAuthError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ClientAuthError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[OauthAuthorizeClientRequest](Models/OauthAuthorizeClientRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Auth](Models/Auth.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClientAuthError](Errors/ClientAuthError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AuthenticationExtrasConvert

> Source: [AuthenticationExtrasConvert](Api/AuthenticationExtrasConvert.cs)

<details>
<summary><code>Task&lt;Auth&gt; ConvertAccessToken(OauthAuthorizeVimeoOauth1Request body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method exchanges a legacy Advanced API OAuth 1 token for an API v3 OAuth 2 token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthenticationExtrasConvert.ConvertAccessToken(body);
    // TODO: Handle 'response' of type Auth
}
catch (SdkException<ConvertAccessTokenError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ConvertAccessTokenError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[OauthAuthorizeVimeoOauth1Request](Models/OauthAuthorizeVimeoOauth1Request.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Auth](Models/Auth.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ConvertAccessTokenError](Errors/ConvertAccessTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AuthenticationExtrasEssentials

> Source: [AuthenticationExtrasEssentials](Api/AuthenticationExtrasEssentials.cs)

<details>
<summary><code>Task DeleteToken(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method revokes the access token that the requesting app is currently using. The token must be of the OAuth 2 type.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AuthenticationExtrasEssentials.DeleteToken();
}
catch (SdkException<DeleteTokenError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteTokenError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteTokenError](Errors/DeleteTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Auth&gt; VerifyToken(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method verifies that an OAuth 2 access token exists.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthenticationExtrasEssentials.VerifyToken();
    // TODO: Handle 'response' of type Auth
}
catch (SdkException<VerifyTokenError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type VerifyTokenError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Auth](Models/Auth.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[VerifyTokenError](Errors/VerifyTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AuthenticationExtrasExchange

> Source: [AuthenticationExtrasExchange](Api/AuthenticationExtrasExchange.cs)

<details>
<summary><code>Task&lt;Auth&gt; ExchangeAuthCode(OauthAccessTokenRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method exchanges an OAuth authorization code for an OAuth access token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthenticationExtrasExchange.ExchangeAuthCode(body);
    // TODO: Handle 'response' of type Auth
}
catch (SdkException<ExchangeAuthCodeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ExchangeAuthCodeError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[OauthAccessTokenRequest](Models/OauthAccessTokenRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Auth](Models/Auth.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ExchangeAuthCodeError](Errors/ExchangeAuthCodeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CategoriesChannels

> Source: [CategoriesChannels](Api/CategoriesChannels.cs)

<details>
<summary><code>Task&lt;ChannelConnection&gt; GetCategoryChannels(string category, Direction? direction, double? page, double? perPage, string? query, Sort4? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every channel that belongs to the specified category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CategoriesChannels.GetCategoryChannels(category, direction, page, perPage, query, sort);
    // TODO: Handle 'response' of type ChannelConnection
}
catch (SdkException<GetCategoryChannelsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCategoryChannelsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort4?](Models/Enums/Sort4.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `followers` - Sort the results by number of followers.<br> * `videos` - Sort the results by number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChannelConnection](Models/ChannelConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCategoryChannelsError](Errors/GetCategoryChannelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CategoriesEssentials

> Source: [CategoriesEssentials](Api/CategoriesEssentials.cs)

<details>
<summary><code>Task&lt;CategoryConnection&gt; GetCategories(Direction? direction, double? page, double? perPage, Sort3? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every available category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CategoriesEssentials.GetCategories(direction, page, perPage, sort);
    // TODO: Handle 'response' of type CategoryConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort3?](Models/Enums/Sort3.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `last_video_featured_time` - Sort the results by most recently featured.<br> * `name` - Sort the results by name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoryConnection](Models/CategoryConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Category&gt; GetCategory(string category, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CategoriesEssentials.GetCategory(category);
    // TODO: Handle 'response' of type Category
}
catch (SdkException<GetCategoryError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCategoryError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Category](Models/Category.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCategoryError](Errors/GetCategoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CategoriesGroups

> Source: [CategoriesGroups](Api/CategoriesGroups.cs)

<details>
<summary><code>Task&lt;GroupConnection&gt; GetCategoryGroups(string category, Direction? direction, double? page, double? perPage, string? query, Sort5? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every group that belongs to the specified category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CategoriesGroups.GetCategoryGroups(category, direction, page, perPage, query, sort);
    // TODO: Handle 'response' of type GroupConnection
}
catch (SdkException<GetCategoryGroupsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCategoryGroupsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort5?](Models/Enums/Sort5.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `members` - Sort the results by number of members.<br> * `videos` - Sort the results by number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupConnection](Models/GroupConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCategoryGroupsError](Errors/GetCategoryGroupsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CategoriesUsers

> Source: [CategoriesUsers](Api/CategoriesUsers.cs)

<details>
<summary><code>Task CheckIfUserSubscribedToCategory(string category, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the authenticated user follows the specified category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CategoriesUsers.CheckIfUserSubscribedToCategory(category, userId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CheckIfUserSubscribedToCategoryAlt1(string category, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the authenticated user follows the specified category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CategoriesUsers.CheckIfUserSubscribedToCategoryAlt1(category);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CategoryConnection&gt; GetCategorySubscriptions(double userId, Direction? direction, double? page, double? perPage, Sort24? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every category that the authenticated user follows.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CategoriesUsers.GetCategorySubscriptions(userId, direction, page, perPage, sort);
    // TODO: Handle 'response' of type CategoryConnection
}
catch (SdkException<GetCategorySubscriptionsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCategorySubscriptionsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort24?](Models/Enums/Sort24.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `name` - Sort the results by name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoryConnection](Models/CategoryConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCategorySubscriptionsError](Errors/GetCategorySubscriptionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CategoryConnection&gt; GetCategorySubscriptionsAlt1(Direction? direction, double? page, double? perPage, Sort24? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every category that the authenticated user follows.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CategoriesUsers.GetCategorySubscriptionsAlt1(direction, page, perPage, sort);
    // TODO: Handle 'response' of type CategoryConnection
}
catch (SdkException<GetCategorySubscriptionsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCategorySubscriptionsAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort24?](Models/Enums/Sort24.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `name` - Sort the results by name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoryConnection](Models/CategoryConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCategorySubscriptionsAlt1Error](Errors/GetCategorySubscriptionsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SubscribeToCategory(string category, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to follow the specified category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CategoriesUsers.SubscribeToCategory(category, userId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SubscribeToCategoryAlt1(string category, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to follow the specified category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CategoriesUsers.SubscribeToCategoryAlt1(category);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UnsubscribeFromCategory(string category, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to stop following the specified category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CategoriesUsers.UnsubscribeFromCategory(category, userId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UnsubscribeFromCategoryAlt1(string category, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to stop following the specified category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CategoriesUsers.UnsubscribeFromCategoryAlt1(category);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CategoriesVideos

> Source: [CategoriesVideos](Api/CategoriesVideos.cs)

<details>
<summary><code>Task&lt;Video&gt; CheckCategoryForVideo(string category, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video in the specified category. You can use this method to determine whether the video belongs to the category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CategoriesVideos.CheckCategoryForVideo(category, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<CheckCategoryForVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckCategoryForVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckCategoryForVideoError](Errors/CheckCategoryForVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetCategoryVideos(string category, Direction? direction, Filter? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort6? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video that belongs to the specified category.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CategoriesVideos.GetCategoryVideos(category,
        direction,
        filter,
        filterEmbeddable,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetCategoryVideosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCategoryVideosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter?](Models/Enums/Filter.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `conditional_featured` - Return featured videos.<br> * `embeddable` - Return embeddable videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort6?](Models/Enums/Sort6.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by date.<br> * `duration` - Sort the results by duration.<br> * `featured` - Sort the results by featured status.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays.<br> * `relevant` - Sort the results by relevance. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCategoryVideosError](Errors/GetCategoryVideosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CategoryConnection&gt; GetVideoCategories(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every category that contains the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CategoriesVideos.GetVideoCategories(videoId, page, perPage);
    // TODO: Handle 'response' of type CategoryConnection
}
catch (SdkException<GetVideoCategoriesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoCategoriesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoryConnection](Models/CategoryConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoCategoriesError](Errors/GetVideoCategoriesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Category&gt; SuggestVideoCategory(double videoId, VideosCategoriesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method sets multiple categories and subcategories for the specified video. Include the categories as a JSON block in the body of the request using the **category** field, like this: `[{ "category": "Tech" }, { "category": "Music" }]`. The authenticated user must have edit access to the video. For more information on batch requests like this one, see [Using Common Formats and Parameters](https://developer.vimeo.com/api/common-formats#working-with-batch-requests).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CategoriesVideos.SuggestVideoCategory(videoId, body);
    // TODO: Handle 'response' of type Category
}
catch (SdkException<SuggestVideoCategoryError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SuggestVideoCategoryError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosCategoriesRequest](Models/VideosCategoriesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Category](Models/Category.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SuggestVideoCategoryError](Errors/SuggestVideoCategoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChannelsCategories

> Source: [ChannelsCategories](Api/ChannelsCategories.cs)

<details>
<summary><code>Task AddChannelCategories(double channelId, ChannelsCategoriesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds the specified channel to multiple categories.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsCategories.AddChannelCategories(channelId, body);
}
catch (SdkException<AddChannelCategoriesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddChannelCategoriesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>body</code> | <code>[ChannelsCategoriesRequest](Models/ChannelsCategoriesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddChannelCategoriesError](Errors/AddChannelCategoriesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CategorizeChannel(string category, double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds the specified channel to a single category. The authenticated user must be the owner of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsCategories.CategorizeChannel(category, channelId);
}
catch (SdkException<CategorizeChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CategorizeChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CategorizeChannelError](Errors/CategorizeChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteChannelCategory(string category, double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a channel from the specified category. The authenticated user must be the owner of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsCategories.DeleteChannelCategory(category, channelId);
}
catch (SdkException<DeleteChannelCategoryError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteChannelCategoryError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>category</code> | <code>string</code> | The name of the category. |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteChannelCategoryError](Errors/DeleteChannelCategoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CategoryConnection&gt; GetChannelCategories(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every category to which the specified channel belongs.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsCategories.GetChannelCategories(channelId);
    // TODO: Handle 'response' of type CategoryConnection
}
catch (SdkException<GetChannelCategoriesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChannelCategoriesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoryConnection](Models/CategoryConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChannelCategoriesError](Errors/GetChannelCategoriesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChannelsEssentials

> Source: [ChannelsEssentials](Api/ChannelsEssentials.cs)

<details>
<summary><code>Task&lt;Channel&gt; CreateChannel(ChannelsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsEssentials.CreateChannel(body);
    // TODO: Handle 'response' of type Channel
}
catch (SdkException<CreateChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[ChannelsRequest](Models/ChannelsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Channel](Models/Channel.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateChannelError](Errors/CreateChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteChannel(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified channel. The authenticated user must own the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsEssentials.DeleteChannel(channelId);
}
catch (SdkException<DeleteChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteChannelError](Errors/DeleteChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Channel&gt; EditChannel(double channelId, ChannelsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsEssentials.EditChannel(channelId, body);
    // TODO: Handle 'response' of type Channel
}
catch (SdkException<EditChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>body</code> | <code>[ChannelsRequest1?](Models/ChannelsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Channel](Models/Channel.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditChannelError](Errors/EditChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Channel&gt; GetChannel(double channelId, string? sizes, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsEssentials.GetChannel(channelId, sizes);
    // TODO: Handle 'response' of type Channel
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>sizes</code> | <code>string?</code> | The pixel dimensions of the image in `{width}x{height}` format. For more information, see our [Using Common Formats and Parameters](https://developer.vimeo.com/api/common-formats#using-the-sizes-parameter) guide. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Channel](Models/Channel.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChannelConnection&gt; GetChannelSubscriptions(double userId, Direction? direction, Filter12? filter, double? page, double? perPage, string? query, Sort4? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the channels to which the specified user subscribes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsEssentials.GetChannelSubscriptions(userId,
        direction,
        filter,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type ChannelConnection
}
catch (SdkException<GetChannelSubscriptionsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChannelSubscriptionsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter12?](Models/Enums/Filter12.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `moderated` - Return moderated channels. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort4?](Models/Enums/Sort4.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date.<br> * `followers` - Sort the results by number of followers.<br> * `videos` - Sort the results by number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChannelConnection](Models/ChannelConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChannelSubscriptionsError](Errors/GetChannelSubscriptionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChannelConnection&gt; GetChannelSubscriptionsAlt1(Direction? direction, Filter12? filter, double? page, double? perPage, string? query, Sort4? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the channels to which the specified user subscribes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsEssentials.GetChannelSubscriptionsAlt1(direction,
        filter,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type ChannelConnection
}
catch (SdkException<GetChannelSubscriptionsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChannelSubscriptionsAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter12?](Models/Enums/Filter12.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `moderated` - Return moderated channels. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort4?](Models/Enums/Sort4.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date.<br> * `followers` - Sort the results by number of followers.<br> * `videos` - Sort the results by number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChannelConnection](Models/ChannelConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChannelSubscriptionsAlt1Error](Errors/GetChannelSubscriptionsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChannelConnection&gt; GetChannels(Direction? direction, Filter1? filter, double? page, double? perPage, string? query, Sort7? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all available channels.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsEssentials.GetChannels(direction, filter, page, perPage, query, sort);
    // TODO: Handle 'response' of type ChannelConnection
}
catch (SdkException<GetChannelsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChannelsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter1?](Models/Enums/Filter1.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `featured` - Return featured channels. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort7?](Models/Enums/Sort7.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date.<br> * `default` - Sort the results by creation date.<br> * `followers` - Sort the results by number of followers.<br> * `relevant` - Sort the results by relevance. This option is available for search queries only.<br> * `videos` - Sort the results by number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChannelConnection](Models/ChannelConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChannelsError](Errors/GetChannelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChannelsModerators

> Source: [ChannelsModerators](Api/ChannelsModerators.cs)

<details>
<summary><code>Task AddChannelModerator(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a single user as a moderator to the specified channel. The authenticated user must be a follower of the requested user to add them as a channel moderator.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsModerators.AddChannelModerator(channelId, userId);
}
catch (SdkException<AddChannelModeratorError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddChannelModeratorError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddChannelModeratorError](Errors/AddChannelModeratorError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AddChannelModerators(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds multiple users as moderators to the specified channel. Include the users by their URI as a JSON array in the body of the request using the **user_uri** field, like this: `[{ "user_uri": "/users/1234" }, { "user_uri": "/users/1235" }]`. The authenticated user must be a follower of a requested user to add this person as a moderator. For more information on batch requests like this one, see [Using Common Formats and Parameters](https://developer.vimeo.com/api/common-formats#working-with-batch-requests).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsModerators.AddChannelModerators(channelId);
}
catch (SdkException<AddChannelModeratorsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddChannelModeratorsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddChannelModeratorsError](Errors/AddChannelModeratorsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; GetChannelModerator(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single moderator of the specified channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsModerators.GetChannelModerator(channelId, userId);
    // TODO: Handle 'response' of type User
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](Models/User.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetChannelModerators(double channelId, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every moderator of the specified channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsModerators.GetChannelModerators(channelId,
        direction,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date added. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveChannelModerator(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a single moderator from the specified channel. The authenticated user must be the owner of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsModerators.RemoveChannelModerator(channelId, userId);
}
catch (SdkException<RemoveChannelModeratorError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveChannelModeratorError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveChannelModeratorError](Errors/RemoveChannelModeratorError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveChannelModerators(double channelId, ChannelsModeratorsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes multiple moderators from the specified channel. The authenticated user must be the owner of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsModerators.RemoveChannelModerators(channelId, body);
}
catch (SdkException<RemoveChannelModeratorsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveChannelModeratorsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>body</code> | <code>[ChannelsModeratorsRequest](Models/ChannelsModeratorsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveChannelModeratorsError](Errors/RemoveChannelModeratorsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;User&gt;&gt; ReplaceChannelModerators(double channelId, ChannelsModeratorsRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method replaces the current list of channel moderators with a new list. The authenticated user must be the owner of the channel and a follower of each requested user to add them as a channel moderator.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsModerators.ReplaceChannelModerators(channelId, body);
    // TODO: Handle 'response' of type IReadOnlyList<User>
}
catch (SdkException<ReplaceChannelModeratorsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ReplaceChannelModeratorsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>body</code> | <code>[ChannelsModeratorsRequest1](Models/ChannelsModeratorsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[User](Models/User.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ReplaceChannelModeratorsError](Errors/ReplaceChannelModeratorsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChannelsPrivateChannelMembers

> Source: [ChannelsPrivateChannelMembers](Api/ChannelsPrivateChannelMembers.cs)

<details>
<summary><code>Task DeleteChannelPrivacyUser(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method prevents a single user from being able to access the specified private channel. The authenticated user must be the owner of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsPrivateChannelMembers.DeleteChannelPrivacyUser(channelId, userId);
}
catch (SdkException<DeleteChannelPrivacyUserError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteChannelPrivacyUserError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteChannelPrivacyUserError](Errors/DeleteChannelPrivacyUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetChannelPrivacyUsers(double channelId, Direction? direction, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the users who have access to the specified private channel. The authenticated user must be the owner of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsPrivateChannelMembers.GetChannelPrivacyUsers(channelId,
        direction,
        page,
        perPage);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<GetChannelPrivacyUsersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChannelPrivacyUsersError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChannelPrivacyUsersError](Errors/GetChannelPrivacyUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SetChannelPrivacyUser(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method gives a single user access to the specified private channel. The authenticated user must be the owner of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsPrivateChannelMembers.SetChannelPrivacyUser(channelId, userId);
}
catch (SdkException<SetChannelPrivacyUserError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SetChannelPrivacyUserError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetChannelPrivacyUserError](Errors/SetChannelPrivacyUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;User&gt;&gt; SetChannelPrivacyUsers(double channelId, ChannelsPrivacyUsersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method gives multiple users access to the specified private channel. The authenticated user must be the owner of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsPrivateChannelMembers.SetChannelPrivacyUsers(channelId, body);
    // TODO: Handle 'response' of type IReadOnlyList<User>
}
catch (SdkException<SetChannelPrivacyUsersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SetChannelPrivacyUsersError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>body</code> | <code>[ChannelsPrivacyUsersRequest](Models/ChannelsPrivacyUsersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[User](Models/User.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetChannelPrivacyUsersError](Errors/SetChannelPrivacyUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChannelsSubscriptionsAndSubscribers

> Source: [ChannelsSubscriptionsAndSubscribers](Api/ChannelsSubscriptionsAndSubscribers.cs)

<details>
<summary><code>Task CheckIfUserSubscribedToChannel(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the specified user is a follower of a particular channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsSubscriptionsAndSubscribers.CheckIfUserSubscribedToChannel(channelId, userId);
}
catch (SdkException<CheckIfUserSubscribedToChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfUserSubscribedToChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfUserSubscribedToChannelError](Errors/CheckIfUserSubscribedToChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CheckIfUserSubscribedToChannelAlt1(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the specified user is a follower of a particular channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsSubscriptionsAndSubscribers.CheckIfUserSubscribedToChannelAlt1(channelId);
}
catch (SdkException<CheckIfUserSubscribedToChannelAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfUserSubscribedToChannelAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfUserSubscribedToChannelAlt1Error](Errors/CheckIfUserSubscribedToChannelAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetChannelSubscribers(double channelId, Filter2 filter, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every follower of the specified channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsSubscriptionsAndSubscribers.GetChannelSubscribers(channelId,
        filter,
        direction,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<GetChannelSubscribersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChannelSubscribersError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>filter</code> | <code>[Filter2](Models/Enums/Filter2.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `moderators` - Return moderators. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by follow date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChannelSubscribersError](Errors/GetChannelSubscribersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SubscribeToChannel(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method subscribes the authenticated user to the specified channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsSubscriptionsAndSubscribers.SubscribeToChannel(channelId, userId);
}
catch (SdkException<SubscribeToChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SubscribeToChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubscribeToChannelError](Errors/SubscribeToChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SubscribeToChannelAlt1(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method subscribes the authenticated user to the specified channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsSubscriptionsAndSubscribers.SubscribeToChannelAlt1(channelId);
}
catch (SdkException<SubscribeToChannelAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SubscribeToChannelAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubscribeToChannelAlt1Error](Errors/SubscribeToChannelAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UnsubscribeFromChannel(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method unsubscribes the authenticated user from the specified channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsSubscriptionsAndSubscribers.UnsubscribeFromChannel(channelId, userId);
}
catch (SdkException<UnsubscribeFromChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UnsubscribeFromChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UnsubscribeFromChannelError](Errors/UnsubscribeFromChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UnsubscribeFromChannelAlt1(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method unsubscribes the authenticated user from the specified channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsSubscriptionsAndSubscribers.UnsubscribeFromChannelAlt1(channelId);
}
catch (SdkException<UnsubscribeFromChannelAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UnsubscribeFromChannelAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UnsubscribeFromChannelAlt1Error](Errors/UnsubscribeFromChannelAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChannelsTags

> Source: [ChannelsTags](Api/ChannelsTags.cs)

<details>
<summary><code>Task AddChannelTag(double channelId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a single tag to the specified channel. The authenticated user must be the owner of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsTags.AddChannelTag(channelId, word);
}
catch (SdkException<AddChannelTagError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddChannelTagError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>word</code> | <code>string</code> | The word to use as the tag. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddChannelTagError](Errors/AddChannelTagError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Tag&gt;&gt; AddTagsToChannel(double channelId, IReadOnlyList&lt;ChannelsTagsRequest&gt; body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds multiple tags to the specified channel. Include the tags as a JSON array in the body of the request using the **tag** field, like this: `[{ "tag": "funny" }, { "tag": "concert" }]`. The authenticated user must be the owner of the channel. For more information on batch requests like this one, see [Using Common Formats and Parameters](https://developer.vimeo.com/api/common-formats#working-with-batch-requests).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsTags.AddTagsToChannel(channelId, body);
    // TODO: Handle 'response' of type IReadOnlyList<Tag>
}
catch (SdkException<AddTagsToChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddTagsToChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>body</code> | <code>IReadOnlyList&lt;[ChannelsTagsRequest](Models/ChannelsTagsRequest.cs)&gt;</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Tag](Models/Tag.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddTagsToChannelError](Errors/AddTagsToChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CheckIfChannelHasTag(double channelId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether a tag has been added to the specified channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsTags.CheckIfChannelHasTag(channelId, word);
}
catch (SdkException<CheckIfChannelHasTagError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfChannelHasTagError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>word</code> | <code>string</code> | The word to use as the tag. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfChannelHasTagError](Errors/CheckIfChannelHasTagError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteTagFromChannel(double channelId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a single tag from the specified channel. The authenticated user must be the owner of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsTags.DeleteTagFromChannel(channelId, word);
}
catch (SdkException<DeleteTagFromChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteTagFromChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>word</code> | <code>string</code> | The word to use as the tag. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteTagFromChannelError](Errors/DeleteTagFromChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagConnection&gt; GetChannelTags(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every tag that has been added to the specified channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsTags.GetChannelTags(channelId);
    // TODO: Handle 'response' of type TagConnection
}
catch (SdkException<GetChannelTagsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChannelTagsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagConnection](Models/TagConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChannelTagsError](Errors/GetChannelTagsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChannelsVideos

> Source: [ChannelsVideos](Api/ChannelsVideos.cs)

<details>
<summary><code>Task AddVideoToChannel(double channelId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a single video to the specified channel. The authenticated user must be a moderator of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsVideos.AddVideoToChannel(channelId, videoId);
}
catch (SdkException<AddVideoToChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoToChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoToChannelError](Errors/AddVideoToChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AddVideosToChannel(double channelId, ChannelsVideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds multiple videos to the specified channel. The authenticated user must be a moderator of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsVideos.AddVideosToChannel(channelId, body);
}
catch (SdkException<AddVideosToChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideosToChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>body</code> | <code>[ChannelsVideosRequest1](Models/ChannelsVideosRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideosToChannelError](Errors/AddVideosToChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoFromChannel(double channelId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a single video from the specified channel. The authenticated user must be a moderator of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsVideos.DeleteVideoFromChannel(channelId, videoId);
}
catch (SdkException<DeleteVideoFromChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoFromChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoFromChannelError](Errors/DeleteVideoFromChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChannelConnection&gt; GetAvailableVideoChannels(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every channel to which the authenticated user can add or remove the specified video. The authenticated user must be a moderator of the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsVideos.GetAvailableVideoChannels(videoId);
    // TODO: Handle 'response' of type ChannelConnection
}
catch (SdkException<GetAvailableVideoChannelsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAvailableVideoChannelsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChannelConnection](Models/ChannelConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAvailableVideoChannelsError](Errors/GetAvailableVideoChannelsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; GetChannelVideo(double channelId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video in the specified channel. You can use it to determine whether the video is in the channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsVideos.GetChannelVideo(channelId, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<GetChannelVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChannelVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChannelVideoError](Errors/GetChannelVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetChannelVideos(double channelId, string? containingUri, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, string? sizes, Sort10? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video in the specified channel.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ChannelsVideos.GetChannelVideos(channelId,
        containingUri,
        direction,
        filter,
        filterEmbeddable,
        page,
        perPage,
        query,
        sizes,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetChannelVideosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChannelVideosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>containingUri</code> | <code>string?</code> | The page that contains the video URI. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sizes</code> | <code>string?</code> | The pixel dimensions of the image in `{width}x{height}` format. For more information, see our [Using Common Formats and Parameters](https://developer.vimeo.com/api/common-formats#using-the-sizes-parameter) guide. |
| <code>sort</code> | <code>[Sort10?](Models/Enums/Sort10.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `added` - Sort the results by date added.<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by creation date.<br> * `default` - Use the default sorting method.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `manual` - Sort the results as the user has arranged them.<br> * `modified_time` - Sort the results by last modification.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChannelVideosError](Errors/GetChannelVideosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveVideosFromChannel(double channelId, ChannelsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes multiple videos from the specified channel. Include the videos by their URI as a JSON block in the body of the request using the **video_uri** field, like this: `[{ "video_uri": "/videos/1234" }, { "video_uri": "/videos/1235" }]`. The authenticated user must be a moderator of the channel. For more information on batch requests like this one, see [Using Common Formats and Parameters](https://developer.vimeo.com/api/common-formats#working-with-batch-requests).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChannelsVideos.RemoveVideosFromChannel(channelId, body);
}
catch (SdkException<RemoveVideosFromChannelError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveVideosFromChannelError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>body</code> | <code>[ChannelsVideosRequest](Models/ChannelsVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveVideosFromChannelError](Errors/RemoveVideosFromChannelError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EmbedPresetsCustomLogos

> Source: [EmbedPresetsCustomLogos](Api/EmbedPresetsCustomLogos.cs)

<details>
<summary><code>Task&lt;Picture&gt; CreateCustomLogo(double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a custom logo representing the authenticated user for display in the embedded player. Be sure to use this method in the context of the multi-step upload procedure described in our [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails#uploading-a-thumbnail) guide. This method represents Step 2 of the procedure.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsCustomLogos.CreateCustomLogo(userId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<CreateCustomLogoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateCustomLogoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateCustomLogoError](Errors/CreateCustomLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; CreateCustomLogoAlt1(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a custom logo representing the authenticated user for display in the embedded player. Be sure to use this method in the context of the multi-step upload procedure described in our [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails#uploading-a-thumbnail) guide. This method represents Step 2 of the procedure.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsCustomLogos.CreateCustomLogoAlt1();
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<CreateCustomLogoAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateCustomLogoAlt1Error
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateCustomLogoAlt1Error](Errors/CreateCustomLogoAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteCustomLogo(double logoId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified custom logo belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EmbedPresetsCustomLogos.DeleteCustomLogo(logoId, userId);
}
catch (SdkException<DeleteCustomLogoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteCustomLogoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>logoId</code> | <code>double</code> | The ID of the custom logo. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteCustomLogoError](Errors/DeleteCustomLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteCustomLogoAlt1(double logoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified custom logo belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EmbedPresetsCustomLogos.DeleteCustomLogoAlt1(logoId);
}
catch (SdkException<DeleteCustomLogoAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteCustomLogoAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>logoId</code> | <code>double</code> | The ID of the custom logo. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteCustomLogoAlt1Error](Errors/DeleteCustomLogoAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetCustomLogo(double logoId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single custom logo belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsCustomLogos.GetCustomLogo(logoId, userId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetCustomLogoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCustomLogoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>logoId</code> | <code>double</code> | The ID of the custom logo. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCustomLogoError](Errors/GetCustomLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetCustomLogoAlt1(double logoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single custom logo belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsCustomLogos.GetCustomLogoAlt1(logoId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetCustomLogoAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCustomLogoAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>logoId</code> | <code>double</code> | The ID of the custom logo. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCustomLogoAlt1Error](Errors/GetCustomLogoAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetCustomLogos(double userId, double? page, double? perPage, string? sizes, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every custom logo that belongs to the authenticated user or team owner.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsCustomLogos.GetCustomLogos(userId, page, perPage, sizes);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<GetCustomLogosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCustomLogosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sizes</code> | <code>string?</code> | The pixel dimensions of the image in `{width}x{height}` format. For more information, see our [Using Common Formats and Parameters](https://developer.vimeo.com/api/common-formats#using-the-sizes-parameter) guide. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCustomLogosError](Errors/GetCustomLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetCustomLogosAlt1(double? page, double? perPage, string? sizes, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every custom logo that belongs to the authenticated user or team owner.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsCustomLogos.GetCustomLogosAlt1(page, perPage, sizes);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<GetCustomLogosAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCustomLogosAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sizes</code> | <code>string?</code> | The pixel dimensions of the image in `{width}x{height}` format. For more information, see our [Using Common Formats and Parameters](https://developer.vimeo.com/api/common-formats#using-the-sizes-parameter) guide. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCustomLogosAlt1Error](Errors/GetCustomLogosAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EmbedPresetsEssentials

> Source: [EmbedPresetsEssentials](Api/EmbedPresetsEssentials.cs)

<details>
<summary><code>Task&lt;Preset&gt; CreateEmbedPresets(double userId, UsersPresetsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates an embed preset.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsEssentials.CreateEmbedPresets(userId, body);
    // TODO: Handle 'response' of type Preset
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersPresetsRequest?](Models/UsersPresetsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Preset](Models/Preset.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Preset&gt; CreateEmbedPresetsAlt1(MePresetsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates an embed preset.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsEssentials.CreateEmbedPresetsAlt1(body);
    // TODO: Handle 'response' of type Preset
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[MePresetsRequest?](Models/MePresetsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Preset](Models/Preset.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteEmbedPreset(double presetId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified embed preset. The authenticated user must be the owner of the preset.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EmbedPresetsEssentials.DeleteEmbedPreset(presetId, userId);
}
catch (SdkException<DeleteEmbedPresetError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteEmbedPresetError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the embed preset. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteEmbedPresetError](Errors/DeleteEmbedPresetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteEmbedPresetAlt1(double presetId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified embed preset. The authenticated user must be the owner of the preset.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EmbedPresetsEssentials.DeleteEmbedPresetAlt1(presetId);
}
catch (SdkException<DeleteEmbedPresetAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteEmbedPresetAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the embed preset. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteEmbedPresetAlt1Error](Errors/DeleteEmbedPresetAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Preset&gt; EditEmbedPreset(double presetId, double userId, UsersPresetsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified embed preset. The authenticated user must be the owner of the preset.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsEssentials.EditEmbedPreset(presetId, userId, body);
    // TODO: Handle 'response' of type Preset
}
catch (SdkException<EditEmbedPresetError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditEmbedPresetError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the preset. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersPresetsRequest1?](Models/UsersPresetsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Preset](Models/Preset.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditEmbedPresetError](Errors/EditEmbedPresetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Preset&gt; EditEmbedPresetAlt1(double presetId, MePresetsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified embed preset. The authenticated user must be the owner of the preset.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsEssentials.EditEmbedPresetAlt1(presetId, body);
    // TODO: Handle 'response' of type Preset
}
catch (SdkException<EditEmbedPresetAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditEmbedPresetAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the preset. |
| <code>body</code> | <code>[MePresetsRequest1?](Models/MePresetsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Preset](Models/Preset.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditEmbedPresetAlt1Error](Errors/EditEmbedPresetAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Preset&gt; GetEmbedPreset(double presetId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single embed preset. The authenticated user must be the owner of the preset.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsEssentials.GetEmbedPreset(presetId, userId);
    // TODO: Handle 'response' of type Preset
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the preset. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Preset](Models/Preset.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Preset&gt; GetEmbedPresetAlt1(double presetId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single embed preset. The authenticated user must be the owner of the preset.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsEssentials.GetEmbedPresetAlt1(presetId);
    // TODO: Handle 'response' of type Preset
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the preset. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Preset](Models/Preset.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PresetConnection&gt; GetEmbedPresets(double userId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every embed preset that belongs to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsEssentials.GetEmbedPresets(userId, page, perPage);
    // TODO: Handle 'response' of type PresetConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PresetConnection](Models/PresetConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PresetConnection&gt; GetEmbedPresetsAlt1(double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every embed preset that belongs to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsEssentials.GetEmbedPresetsAlt1(page, perPage);
    // TODO: Handle 'response' of type PresetConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PresetConnection](Models/PresetConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EmbedPresetsFolders

> Source: [EmbedPresetsFolders](Api/EmbedPresetsFolders.cs)

<details>
<summary><code>Task DeleteFolderEmbedPreset(double presetId, double projectId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the specified embed preset from a folder. The authenticated user must be either the owner of the folder or a team user with the contributor or admin role.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EmbedPresetsFolders.DeleteFolderEmbedPreset(presetId, projectId, userId);
}
catch (SdkException<DeleteFolderEmbedPresetError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteFolderEmbedPresetError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the embed preset. |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteFolderEmbedPresetError](Errors/DeleteFolderEmbedPresetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EmbedPresetsTimelineEvents

> Source: [EmbedPresetsTimelineEvents](Api/EmbedPresetsTimelineEvents.cs)

<details>
<summary><code>Task&lt;Picture&gt; CreateVideoCustomLogo(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a timeline event thumbnail to the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsTimelineEvents.CreateVideoCustomLogo(videoId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<CreateVideoCustomLogoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateVideoCustomLogoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateVideoCustomLogoError](Errors/CreateVideoCustomLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetVideoCustomLogo(double thumbnailId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single timeline event thumbnail that belongs to the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsTimelineEvents.GetVideoCustomLogo(thumbnailId, videoId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetVideoCustomLogoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoCustomLogoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>thumbnailId</code> | <code>double</code> | The ID of the timeline event thumbnail. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoCustomLogoError](Errors/GetVideoCustomLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## EmbedPresetsVideos

> Source: [EmbedPresetsVideos](Api/EmbedPresetsVideos.cs)

<details>
<summary><code>Task AddVideoEmbedPreset(double presetId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds an embed preset to the specified video. The authenticated user must either be the owner of the video or a team user with the contributor or admin role.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EmbedPresetsVideos.AddVideoEmbedPreset(presetId, videoId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the embed preset. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoEmbedPreset(double presetId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the specified embed preset from a video. The authenticated user must either be the owner of the video or a team user with the contributor or admin role.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EmbedPresetsVideos.DeleteVideoEmbedPreset(presetId, videoId);
}
catch (SdkException<DeleteVideoEmbedPresetError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoEmbedPresetError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the embed preset. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoEmbedPresetError](Errors/DeleteVideoEmbedPresetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetEmbedPresetVideos(double presetId, double userId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video to which the specified embed preset has been added. The authenticated user must be the owner of the videos.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsVideos.GetEmbedPresetVideos(presetId, userId, page, perPage);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the embed preset. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetEmbedPresetVideosAlt1(double presetId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video to which the specified embed preset has been added. The authenticated user must be the owner of the videos.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmbedPresetsVideos.GetEmbedPresetVideosAlt1(presetId, page, perPage);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the embed preset. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetVideoEmbedPreset(double presetId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether a video has the specified embed preset.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.EmbedPresetsVideos.GetVideoEmbedPreset(presetId, videoId);
}
catch (SdkException<GetVideoEmbedPresetError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoEmbedPresetError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>presetId</code> | <code>double</code> | The ID of the embed preset. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoEmbedPresetError](Errors/GetVideoEmbedPresetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FoldersEssentials

> Source: [FoldersEssentials](Api/FoldersEssentials.cs)

<details>
<summary><code>Task&lt;Project&gt; CreateProject(double userId, UsersProjectsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new folder for the authenticated user. By default, this method creates a top-level folder. To create a subfolder — that is, to place the new folder inside an existing folder — specify the parent folder by URI with the **parent_folder_uri** parameter in the body of the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FoldersEssentials.CreateProject(userId, body);
    // TODO: Handle 'response' of type Project
}
catch (SdkException<CreateProjectError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateProjectError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersProjectsRequest](Models/UsersProjectsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Project](Models/Project.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateProjectError](Errors/CreateProjectError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Project&gt; CreateProjectAlt1(MeProjectsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new folder for the authenticated user. By default, this method creates a top-level folder. To create a subfolder — that is, to place the new folder inside an existing folder — specify the parent folder by URI with the **parent_folder_uri** parameter in the body of the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FoldersEssentials.CreateProjectAlt1(body);
    // TODO: Handle 'response' of type Project
}
catch (SdkException<CreateProjectAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateProjectAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[MeProjectsRequest](Models/MeProjectsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Project](Models/Project.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateProjectAlt1Error](Errors/CreateProjectAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteProject(double projectId, double userId, UsersProjectsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified folder and optionally also the videos that it contains. The authenticated user must be the owner of the folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersEssentials.DeleteProject(projectId, userId, body);
}
catch (SdkException<DeleteProjectError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteProjectError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersProjectsRequest1?](Models/UsersProjectsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteProjectError](Errors/DeleteProjectError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteProjectAlt1(double projectId, MeProjectsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified folder and optionally also the videos that it contains. The authenticated user must be the owner of the folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersEssentials.DeleteProjectAlt1(projectId, body);
}
catch (SdkException<DeleteProjectAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteProjectAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>body</code> | <code>[MeProjectsRequest1?](Models/MeProjectsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteProjectAlt1Error](Errors/DeleteProjectAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Project&gt; EditProject(double projectId, double userId, UsersProjectsRequest2 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified folder. The authenticated user must be the owner of the folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FoldersEssentials.EditProject(projectId, userId, body);
    // TODO: Handle 'response' of type Project
}
catch (SdkException<EditProjectError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditProjectError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersProjectsRequest2](Models/UsersProjectsRequest2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Project](Models/Project.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditProjectError](Errors/EditProjectError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Project&gt; EditProjectAlt1(double projectId, MeProjectsRequest2 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified folder. The authenticated user must be the owner of the folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FoldersEssentials.EditProjectAlt1(projectId, body);
    // TODO: Handle 'response' of type Project
}
catch (SdkException<EditProjectAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditProjectAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>body</code> | <code>[MeProjectsRequest2](Models/MeProjectsRequest2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Project](Models/Project.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditProjectAlt1Error](Errors/EditProjectAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Project&gt; GetPrivateToMeFolder(double ownerId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified private-to-me folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FoldersEssentials.GetPrivateToMeFolder(ownerId);
    // TODO: Handle 'response' of type Project
}
catch (SdkException<GetPrivateToMeFolderError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetPrivateToMeFolderError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ownerId</code> | <code>double</code> | The ID of the owner. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Project](Models/Project.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPrivateToMeFolderError](Errors/GetPrivateToMeFolderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Project&gt; GetProject(double projectId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single folder belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FoldersEssentials.GetProject(projectId, userId);
    // TODO: Handle 'response' of type Project
}
catch (SdkException<GetProjectError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetProjectError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Project](Models/Project.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetProjectError](Errors/GetProjectError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Project&gt; GetProjectAlt1(double projectId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single folder belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FoldersEssentials.GetProjectAlt1(projectId);
    // TODO: Handle 'response' of type Project
}
catch (SdkException<GetProjectAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetProjectAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Project](Models/Project.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetProjectAlt1Error](Errors/GetProjectAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProjectConnection&gt; GetProjects(double userId, Direction? direction, double? page, double? perPage, string? query, Sort36? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the folders belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FoldersEssentials.GetProjects(userId, direction, page, perPage, query, sort);
    // TODO: Handle 'response' of type ProjectConnection
}
catch (SdkException<GetProjectsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetProjectsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort36?](Models/Enums/Sort36.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `date` - Sort the results by date.<br> * `default` - Use the default sort order.<br> * `modified_time` - Sort the results by last modification.<br> * `name` - Sort the results by name.<br> * `pinned_on` - Sort the results by pinned timestamp. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProjectConnection](Models/ProjectConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetProjectsError](Errors/GetProjectsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProjectConnection&gt; GetProjectsAlt1(Direction? direction, double? page, double? perPage, string? query, Sort36? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the folders belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FoldersEssentials.GetProjectsAlt1(direction, page, perPage, query, sort);
    // TODO: Handle 'response' of type ProjectConnection
}
catch (SdkException<GetProjectsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetProjectsAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort36?](Models/Enums/Sort36.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `date` - Sort the results by date.<br> * `default` - Use the default sort order.<br> * `modified_time` - Sort the results by last modification.<br> * `name` - Sort the results by name.<br> * `pinned_on` - Sort the results by pinned timestamp. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProjectConnection](Models/ProjectConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetProjectsAlt1Error](Errors/GetProjectsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FoldersItems

> Source: [FoldersItems](Api/FoldersItems.cs)

<details>
<summary><code>Task DeleteFolderItemsAlt1(double projectId, string uris, bool? sendToRecentlyDeleted, bool? shouldDeleteItems, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes all items from the specified folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersItems.DeleteFolderItemsAlt1(projectId, uris, sendToRecentlyDeleted, shouldDeleteItems);
}
catch (SdkException<DeleteFolderItemsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteFolderItemsAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>uris</code> | <code>string</code> | A comma-separated list of video, event, or folder URIs to remove. Folder URIs are moved to the library root (with their contents). |
| <code>sendToRecentlyDeleted</code> | <code>bool?</code> | When `should_delete_items` is true, send deleted clips to Recently Deleted purgatory (`TYPE_RECENTLY_DELETED`) instead of legacy user delete purgatory. |
| <code>shouldDeleteItems</code> | <code>bool?</code> | Whether to delete the items when removing them from the folder. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteFolderItemsAlt1Error](Errors/DeleteFolderItemsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetFolderItems(double projectId, string? clipPrivacyFilters, Direction? direction, Filter21? filter, double? page, double? perPage, Sort37? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every item that belongs to the specified folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersItems.GetFolderItems(projectId, clipPrivacyFilters, direction, filter, page, perPage, sort);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>clipPrivacyFilters</code> | <code>string?</code> | A comma-separated list of video privacy types to filter on. The accepted values are `private` for when only the creator and users with access grants can play the video; `public` for when anyone can play the video; `password` for when only users with the correct password can play the video; `hide_from_vimeo` for when the video is private but embeddable anywhere; and `unlisted` for when only users with the link can play the video. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter21?](Models/Enums/Filter21.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `folder` - Filter the results by folder.<br> * `live_event` - Filter the results by event.<br> * `video` - Filter the results by video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort37?](Models/Enums/Sort37.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `default` - Use the default sort order.<br> * `duration` - Sort the results by duration. Items without a duration, namely events and folders, are grouped by type in ascending alphabetical order, with events first.<br> * `last_user_action_event_date` - Sort the results by the date of the last user action. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetFolderItems2(double projectId, double userId, string? clipPrivacyFilters, Direction? direction, Filter21? filter, double? page, double? perPage, Sort37? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every item that belongs to the specified folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersItems.GetFolderItems2(projectId,
        userId,
        clipPrivacyFilters,
        direction,
        filter,
        page,
        perPage,
        sort);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>clipPrivacyFilters</code> | <code>string?</code> | A comma-separated list of video privacy types to filter on. The accepted values are `private` for when only the creator and users with access grants can play the video; `public` for when anyone can play the video; `password` for when only users with the correct password can play the video; `hide_from_vimeo` for when the video is private but embeddable anywhere; and `unlisted` for when only users with the link can play the video. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter21?](Models/Enums/Filter21.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `folder` - Filter the results by folder.<br> * `live_event` - Filter the results by event.<br> * `video` - Filter the results by video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort37?](Models/Enums/Sort37.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `default` - Use the default sort order.<br> * `duration` - Sort the results by duration. Items without a duration, namely events and folders, are grouped by type in ascending alphabetical order, with events first.<br> * `last_user_action_event_date` - Sort the results by the date of the last user action. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## FoldersVideos

> Source: [FoldersVideos](Api/FoldersVideos.cs)

<details>
<summary><code>Task AddVideoToProject(double projectId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a single video to the specified folder. The authenticated user must be the owner of the folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersVideos.AddVideoToProject(projectId, userId, videoId);
}
catch (SdkException<AddVideoToProjectError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoToProjectError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoToProjectError](Errors/AddVideoToProjectError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AddVideoToProjectAlt1(double projectId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a single video to the specified folder. The authenticated user must be the owner of the folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersVideos.AddVideoToProjectAlt1(projectId, videoId);
}
catch (SdkException<AddVideoToProjectAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoToProjectAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoToProjectAlt1Error](Errors/AddVideoToProjectAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AddVideosToProject(double projectId, double userId, UsersProjectsVideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds multiple videos to the specified folder. The authenticated user must be the owner of the folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersVideos.AddVideosToProject(projectId, userId, body);
}
catch (SdkException<AddVideosToProjectError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideosToProjectError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersProjectsVideosRequest1](Models/UsersProjectsVideosRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideosToProjectError](Errors/AddVideosToProjectError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AddVideosToProjectAlt1(double projectId, MeProjectsVideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds multiple videos to the specified folder. The authenticated user must be the owner of the folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersVideos.AddVideosToProjectAlt1(projectId, body);
}
catch (SdkException<AddVideosToProjectAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideosToProjectAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>body</code> | <code>[MeProjectsVideosRequest1](Models/MeProjectsVideosRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideosToProjectAlt1Error](Errors/AddVideosToProjectAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetProjectVideos(double projectId, double userId, Direction? direction, string? filterTag, string? filterTagAllOf, string? filterTagExclude, bool? includeSubfolders, double? page, double? perPage, string? query, string? queryFields, Sort37? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the videos that belong to the specified folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FoldersVideos.GetProjectVideos(projectId,
        userId,
        direction,
        filterTag,
        filterTagAllOf,
        filterTagExclude,
        includeSubfolders,
        page,
        perPage,
        query,
        queryFields,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetProjectVideosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetProjectVideosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filterTag</code> | <code>string?</code> | A comma-separated list of tags to filter on. All results must include at least one of these tags. The use of this parameter triggers a search. |
| <code>filterTagAllOf</code> | <code>string?</code> | A comma-separated list of tags to filter on. All results must include all of these tags. The use of this parameter triggers a search. |
| <code>filterTagExclude</code> | <code>string?</code> | A comma-separated list of tags to exclude. The use of this parameter triggers a search. |
| <code>includeSubfolders</code> | <code>bool?</code> | Whether to include subfolders. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>queryFields</code> | <code>string?</code> | A comma-separated list of fields to query over. The default value is `title,description,chapters,tags`. |
| <code>sort</code> | <code>[Sort37?](Models/Enums/Sort37.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `default` - Use the default sort order.<br> * `duration` - Sort the results by duration.<br> * `last_user_action_event_date` - Sort the results by the date of the last user action. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetProjectVideosError](Errors/GetProjectVideosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetProjectVideosAlt1(double projectId, Direction? direction, string? filterTag, string? filterTagAllOf, string? filterTagExclude, bool? includeSubfolders, double? page, double? perPage, string? query, string? queryFields, Sort37? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the videos that belong to the specified folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FoldersVideos.GetProjectVideosAlt1(projectId,
        direction,
        filterTag,
        filterTagAllOf,
        filterTagExclude,
        includeSubfolders,
        page,
        perPage,
        query,
        queryFields,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetProjectVideosAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetProjectVideosAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filterTag</code> | <code>string?</code> | A comma-separated list of tags to filter on. All results must include at least one of these tags. The use of this parameter triggers a search. |
| <code>filterTagAllOf</code> | <code>string?</code> | A comma-separated list of tags to filter on. All results must include all of these tags. The use of this parameter triggers a search. |
| <code>filterTagExclude</code> | <code>string?</code> | A comma-separated list of tags to exclude. The use of this parameter triggers a search. |
| <code>includeSubfolders</code> | <code>bool?</code> | Whether to include subfolders. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>queryFields</code> | <code>string?</code> | A comma-separated list of fields to query over. The default value is `title,description,chapters,tags`. |
| <code>sort</code> | <code>[Sort37?](Models/Enums/Sort37.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `default` - Use the default sort order.<br> * `duration` - Sort the results by duration.<br> * `last_user_action_event_date` - Sort the results by the date of the last user action. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetProjectVideosAlt1Error](Errors/GetProjectVideosAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveVideoFromProject(double projectId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a single video from the specified folder. Please note that this doesn't delete the video itself.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersVideos.RemoveVideoFromProject(projectId, userId, videoId);
}
catch (SdkException<RemoveVideoFromProjectError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveVideoFromProjectError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveVideoFromProjectError](Errors/RemoveVideoFromProjectError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveVideoFromProjectAlt1(double projectId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a single video from the specified folder. Please note that this doesn't delete the video itself.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersVideos.RemoveVideoFromProjectAlt1(projectId, videoId);
}
catch (SdkException<RemoveVideoFromProjectAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveVideoFromProjectAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveVideoFromProjectAlt1Error](Errors/RemoveVideoFromProjectAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveVideosFromProject(double projectId, double userId, UsersProjectsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes multiple videos from the specified folder. The authenticated user must be the owner of the folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersVideos.RemoveVideosFromProject(projectId, userId, body);
}
catch (SdkException<RemoveVideosFromProjectError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveVideosFromProjectError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersProjectsVideosRequest](Models/UsersProjectsVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveVideosFromProjectError](Errors/RemoveVideosFromProjectError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveVideosFromProjectAlt1(double projectId, MeProjectsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes multiple videos from the specified folder. The authenticated user must be the owner of the folder.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FoldersVideos.RemoveVideosFromProjectAlt1(projectId, body);
}
catch (SdkException<RemoveVideosFromProjectAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveVideosFromProjectAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>projectId</code> | <code>double</code> | The ID of the folder. |
| <code>body</code> | <code>[MeProjectsVideosRequest](Models/MeProjectsVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveVideosFromProjectAlt1Error](Errors/RemoveVideosFromProjectAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GroupsEssentials

> Source: [GroupsEssentials](Api/GroupsEssentials.cs)

<details>
<summary><code>Task&lt;Group&gt; CreateGroup(GroupsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GroupsEssentials.CreateGroup(body);
    // TODO: Handle 'response' of type Group
}
catch (SdkException<CreateGroupError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateGroupError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[GroupsRequest](Models/GroupsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Group](Models/Group.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateGroupError](Errors/CreateGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteGroup(double groupId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified group. The authenticated user must be the owner of the group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.GroupsEssentials.DeleteGroup(groupId);
}
catch (SdkException<DeleteGroupError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteGroupError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteGroupError](Errors/DeleteGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Group&gt; GetGroup(double groupId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GroupsEssentials.GetGroup(groupId);
    // TODO: Handle 'response' of type Group
}
catch (SdkException<GetGroupError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetGroupError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Group](Models/Group.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGroupError](Errors/GetGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupConnection&gt; GetGroups(Direction? direction, Filter1? filter, double? page, double? perPage, string? query, Sort13? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every available group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GroupsEssentials.GetGroups(direction, filter, page, perPage, query, sort);
    // TODO: Handle 'response' of type GroupConnection
}
catch (SdkException<GetGroupsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetGroupsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter1?](Models/Enums/Filter1.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `featured` - Return featured groups. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort13?](Models/Enums/Sort13.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date.<br> * `followers` - Sort the results by number of followers.<br> * `relevant` - Sort the results by relevance. This option is available for search queries only.<br> * `videos` - Sort the results by number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupConnection](Models/GroupConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGroupsError](Errors/GetGroupsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GroupsSubscriptions

> Source: [GroupsSubscriptions](Api/GroupsSubscriptions.cs)

<details>
<summary><code>Task JoinGroup(double groupId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds the authenticated user to the specified group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.GroupsSubscriptions.JoinGroup(groupId, userId);
}
catch (SdkException<JoinGroupError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type JoinGroupError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[JoinGroupError](Errors/JoinGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task JoinGroupAlt1(double groupId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds the authenticated user to the specified group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.GroupsSubscriptions.JoinGroupAlt1(groupId);
}
catch (SdkException<JoinGroupAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type JoinGroupAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[JoinGroupAlt1Error](Errors/JoinGroupAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task LeaveGroup(double groupId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the authenticated user from the specified group. The authenticated user can't be the owner of the group; assign a new owner through a PATCH request first.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.GroupsSubscriptions.LeaveGroup(groupId, userId);
}
catch (SdkException<LeaveGroupError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type LeaveGroupError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[LeaveGroupError](Errors/LeaveGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task LeaveGroupAlt1(double groupId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the authenticated user from the specified group. The authenticated user can't be the owner of the group; assign a new owner through a PATCH request first.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.GroupsSubscriptions.LeaveGroupAlt1(groupId);
}
catch (SdkException<LeaveGroupAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type LeaveGroupAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[LeaveGroupAlt1Error](Errors/LeaveGroupAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GroupsUsers

> Source: [GroupsUsers](Api/GroupsUsers.cs)

<details>
<summary><code>Task CheckIfUserJoinedGroup(double groupId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the authenticated user belongs to the specified group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.GroupsUsers.CheckIfUserJoinedGroup(groupId, userId);
}
catch (SdkException<CheckIfUserJoinedGroupError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfUserJoinedGroupError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfUserJoinedGroupError](Errors/CheckIfUserJoinedGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CheckIfUserJoinedGroupAlt1(double groupId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the authenticated user belongs to the specified group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.GroupsUsers.CheckIfUserJoinedGroupAlt1(groupId);
}
catch (SdkException<CheckIfUserJoinedGroupAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfUserJoinedGroupAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfUserJoinedGroupAlt1Error](Errors/CheckIfUserJoinedGroupAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetGroupMembers(double groupId, Direction? direction, Filter2? filter, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every user who belongs to the specified group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GroupsUsers.GetGroupMembers(groupId, direction, filter, page, perPage, query, sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<GetGroupMembersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetGroupMembersError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter2?](Models/Enums/Filter2.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `moderators` - Return group moderators. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGroupMembersError](Errors/GetGroupMembersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupConnection&gt; GetUserGroups(double userId, Direction? direction, Filter12? filter, double? page, double? perPage, string? query, Sort5? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every group to which the authenticated user belongs.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GroupsUsers.GetUserGroups(userId, direction, filter, page, perPage, query, sort);
    // TODO: Handle 'response' of type GroupConnection
}
catch (SdkException<GetUserGroupsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetUserGroupsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter12?](Models/Enums/Filter12.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `moderated` - Return moderated groups. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort5?](Models/Enums/Sort5.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date.<br> * `members` - Sort the results by number of members.<br> * `videos` - Sort the results by number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupConnection](Models/GroupConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetUserGroupsError](Errors/GetUserGroupsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupConnection&gt; GetUserGroupsAlt1(Direction? direction, Filter12? filter, double? page, double? perPage, string? query, Sort5? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every group to which the authenticated user belongs.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GroupsUsers.GetUserGroupsAlt1(direction, filter, page, perPage, query, sort);
    // TODO: Handle 'response' of type GroupConnection
}
catch (SdkException<GetUserGroupsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetUserGroupsAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter12?](Models/Enums/Filter12.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `moderated` - Return moderated groups. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort5?](Models/Enums/Sort5.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date.<br> * `members` - Sort the results by number of members.<br> * `videos` - Sort the results by number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupConnection](Models/GroupConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetUserGroupsAlt1Error](Errors/GetUserGroupsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GroupsVideos

> Source: [GroupsVideos](Api/GroupsVideos.cs)

<details>
<summary><code>Task&lt;Video&gt; AddVideoToGroup(double groupId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a video to the specified group. The authenticated user must be the owner of the group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GroupsVideos.AddVideoToGroup(groupId, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<AddVideoToGroupError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoToGroupError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoToGroupError](Errors/AddVideoToGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoFromGroup(double groupId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a video from the specified group. The authenticated user must be the owner of the group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.GroupsVideos.DeleteVideoFromGroup(groupId, videoId);
}
catch (SdkException<DeleteVideoFromGroupError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoFromGroupError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoFromGroupError](Errors/DeleteVideoFromGroupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GroupConnection&gt; GetAvailableVideoGroups(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every group to which the authenticated user can add or remove the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GroupsVideos.GetAvailableVideoGroups(videoId);
    // TODO: Handle 'response' of type GroupConnection
}
catch (SdkException<GetAvailableVideoGroupsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAvailableVideoGroupsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GroupConnection](Models/GroupConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAvailableVideoGroupsError](Errors/GetAvailableVideoGroupsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; GetGroupVideo(double groupId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video from the specified group. You can use this method to determine whether the video belongs to the group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GroupsVideos.GetGroupVideo(groupId, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<GetGroupVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetGroupVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGroupVideoError](Errors/GetGroupVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetGroupVideos(double groupId, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video from the specified group.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GroupsVideos.GetGroupVideos(groupId,
        direction,
        filter,
        filterEmbeddable,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetGroupVideosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetGroupVideosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>groupId</code> | <code>double</code> | The ID of the group. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort15?](Models/Enums/Sort15.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by creation date.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGroupVideosError](Errors/GetGroupVideosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LikesEssentials

> Source: [LikesEssentials](Api/LikesEssentials.cs)

<details>
<summary><code>Task CheckIfUserLikedVideo(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method checks if the authenticated user has liked the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LikesEssentials.CheckIfUserLikedVideo(userId, videoId);
}
catch (SdkException<CheckIfUserLikedVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfUserLikedVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfUserLikedVideoError](Errors/CheckIfUserLikedVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CheckIfUserLikedVideoAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method checks if the authenticated user has liked the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LikesEssentials.CheckIfUserLikedVideoAlt1(videoId);
}
catch (SdkException<CheckIfUserLikedVideoAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfUserLikedVideoAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfUserLikedVideoAlt1Error](Errors/CheckIfUserLikedVideoAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetLikes(double userId, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video that the authenticated user has liked.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LikesEssentials.GetLikes(userId, filter, filterEmbeddable, page, perPage, query, sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetLikesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLikesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort15?](Models/Enums/Sort15.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by creation date.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLikesError](Errors/GetLikesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetLikesAlt1(Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video that the authenticated user has liked.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LikesEssentials.GetLikesAlt1(filter, filterEmbeddable, page, perPage, query, sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetLikesAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLikesAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort15?](Models/Enums/Sort15.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by creation date.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLikesAlt1Error](Errors/GetLikesAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetVideoLikes(double videoId, Direction? direction, double? page, double? perPage, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every user who has liked the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LikesEssentials.GetVideoLikes(videoId, direction, page, perPage, sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by join date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetVideoLikesAlt1(double channelId, double videoId, Direction? direction, double? page, double? perPage, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every user who has liked the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LikesEssentials.GetVideoLikesAlt1(channelId, videoId, direction, page, perPage, sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by join date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetVodLikes(double ondemandId, Direction? direction, Filter25? filter, double? page, double? perPage, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every user who has liked the specified video on an On Demand page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LikesEssentials.GetVodLikes(ondemandId, direction, filter, page, perPage, sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<GetVodLikesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodLikesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter25?](Models/Enums/Filter25.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `extra` - Consider extra content only.<br> * `main` - Consider main content only.<br> * `trailer` - Consider trailer content only. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by join date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodLikesError](Errors/GetVodLikesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task LikeVideo(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to like the specified video. The user can't like their own video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LikesEssentials.LikeVideo(userId, videoId);
}
catch (SdkException<LikeVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type LikeVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[LikeVideoError](Errors/LikeVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task LikeVideoAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to like the specified video. The user can't like their own video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LikesEssentials.LikeVideoAlt1(videoId);
}
catch (SdkException<LikeVideoAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type LikeVideoAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[LikeVideoAlt1Error](Errors/LikeVideoAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UnlikeVideo(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to unlike the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LikesEssentials.UnlikeVideo(userId, videoId);
}
catch (SdkException<UnlikeVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UnlikeVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UnlikeVideoError](Errors/UnlikeVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UnlikeVideoAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to unlike the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LikesEssentials.UnlikeVideoAlt1(videoId);
}
catch (SdkException<UnlikeVideoAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UnlikeVideoAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UnlikeVideoAlt1Error](Errors/UnlikeVideoAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveAnalytics

> Source: [LiveAnalytics](Api/LiveAnalytics.cs)

<details>
<summary><code>Task ExportVpaasViewerAnalytics(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method queues an export of VPaaS viewer analytics for the specified live event.

The authenticated user must be the owner of the event or have edit permissions.
The webhook is delivered to the managing vendor app's registered webhook URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveAnalytics.ExportVpaasViewerAnalytics(liveEventId);
}
catch (SdkException<ExportVpaasViewerAnalyticsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ExportVpaasViewerAnalyticsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the live event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ExportVpaasViewerAnalyticsError](Errors/ExportVpaasViewerAnalyticsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveAudioTracks

> Source: [LiveAudioTracks](Api/LiveAudioTracks.cs)

<details>
<summary><code>Task&lt;EventAudioTracks&gt; GetEventAudioTracks(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns audio tracks settings for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveAudioTracks.GetEventAudioTracks(liveEventId);
    // TODO: Handle 'response' of type EventAudioTracks
}
catch (SdkException<GetEventAudioTracksError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetEventAudioTracksError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventAudioTracks](Models/EventAudioTracks.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetEventAudioTracksError](Errors/GetEventAudioTracksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventAudioTracks&gt; UpdateEventAudioTracks(double liveEventId, LiveEventsAudioTracksRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method updates audio tracks settings on the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveAudioTracks.UpdateEventAudioTracks(liveEventId, body);
    // TODO: Handle 'response' of type EventAudioTracks
}
catch (SdkException<UpdateEventAudioTracksError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UpdateEventAudioTracksError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[LiveEventsAudioTracksRequest?](Models/LiveEventsAudioTracksRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventAudioTracks](Models/EventAudioTracks.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateEventAudioTracksError](Errors/UpdateEventAudioTracksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveEmbedPrivacy

> Source: [LiveEmbedPrivacy](Api/LiveEmbedPrivacy.cs)

<details>
<summary><code>Task&lt;DomainConnection&gt; GetLiveEventWhitelist(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every permitted domain for an event. The embed privacy setting must be `whitelist`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEmbedPrivacy.GetLiveEventWhitelist(liveEventId, userId);
    // TODO: Handle 'response' of type DomainConnection
}
catch (SdkException<GetLiveEventWhitelistError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventWhitelistError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DomainConnection](Models/DomainConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventWhitelistError](Errors/GetLiveEventWhitelistError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DomainConnection&gt; GetLiveEventWhitelistAlt1(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every permitted domain for an event. The embed privacy setting must be `whitelist`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEmbedPrivacy.GetLiveEventWhitelistAlt1(liveEventId);
    // TODO: Handle 'response' of type DomainConnection
}
catch (SdkException<GetLiveEventWhitelistAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventWhitelistAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DomainConnection](Models/DomainConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventWhitelistAlt1Error](Errors/GetLiveEventWhitelistAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DomainConnection&gt; GetLiveEventWhitelistAlt2(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every permitted domain for an event. The embed privacy setting must be `whitelist`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEmbedPrivacy.GetLiveEventWhitelistAlt2(liveEventId);
    // TODO: Handle 'response' of type DomainConnection
}
catch (SdkException<GetLiveEventWhitelistAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventWhitelistAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DomainConnection](Models/DomainConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventWhitelistAlt2Error](Errors/GetLiveEventWhitelistAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SetLiveEventWhitelist(double liveEventId, double userId, UsersLiveEventsPrivacyDomainsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method embeds an event on the specified domains. The embed privacy setting must be `whitelist`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEmbedPrivacy.SetLiveEventWhitelist(liveEventId, userId, body);
}
catch (SdkException<SetLiveEventWhitelistError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SetLiveEventWhitelistError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsPrivacyDomainsRequest?](Models/UsersLiveEventsPrivacyDomainsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetLiveEventWhitelistError](Errors/SetLiveEventWhitelistError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SetLiveEventWhitelistAlt1(double liveEventId, LiveEventsPrivacyDomainsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method embeds an event on the specified domains. The embed privacy setting must be `whitelist`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEmbedPrivacy.SetLiveEventWhitelistAlt1(liveEventId, body);
}
catch (SdkException<SetLiveEventWhitelistAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SetLiveEventWhitelistAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[LiveEventsPrivacyDomainsRequest?](Models/LiveEventsPrivacyDomainsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetLiveEventWhitelistAlt1Error](Errors/SetLiveEventWhitelistAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SetLiveEventWhitelistAlt2(double liveEventId, MeLiveEventsPrivacyDomainsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method embeds an event on the specified domains. The embed privacy setting must be `whitelist`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEmbedPrivacy.SetLiveEventWhitelistAlt2(liveEventId, body);
}
catch (SdkException<SetLiveEventWhitelistAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SetLiveEventWhitelistAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[MeLiveEventsPrivacyDomainsRequest?](Models/MeLiveEventsPrivacyDomainsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetLiveEventWhitelistAlt2Error](Errors/SetLiveEventWhitelistAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveEssentials

> Source: [LiveEssentials](Api/LiveEssentials.cs)

<details>
<summary><code>Task&lt;RecurringEvent&gt; CreateLiveEvent(double userId, UsersLiveEventsRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new event for the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.CreateLiveEvent(userId, body);
    // TODO: Handle 'response' of type RecurringEvent
}
catch (SdkException<CreateLiveEventError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateLiveEventError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsRequest1](Models/UsersLiveEventsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEvent](Models/RecurringEvent.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateLiveEventError](Errors/CreateLiveEventError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringEvent&gt; CreateLiveEventAlt1(LiveEventsRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new event for the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.CreateLiveEventAlt1(body);
    // TODO: Handle 'response' of type RecurringEvent
}
catch (SdkException<CreateLiveEventAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateLiveEventAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[LiveEventsRequest1](Models/LiveEventsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEvent](Models/RecurringEvent.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateLiveEventAlt1Error](Errors/CreateLiveEventAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringEvent&gt; CreateLiveEventAlt2(MeLiveEventsRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new event for the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.CreateLiveEventAlt2(body);
    // TODO: Handle 'response' of type RecurringEvent
}
catch (SdkException<CreateLiveEventAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateLiveEventAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[MeLiveEventsRequest1](Models/MeLiveEventsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEvent](Models/RecurringEvent.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateLiveEventAlt2Error](Errors/CreateLiveEventAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteLiveEvent(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes a single event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEssentials.DeleteLiveEvent(liveEventId, userId);
}
catch (SdkException<DeleteLiveEventError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteLiveEventError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteLiveEventError](Errors/DeleteLiveEventError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteLiveEventAlt1(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes a single event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEssentials.DeleteLiveEventAlt1(liveEventId);
}
catch (SdkException<DeleteLiveEventAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteLiveEventAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteLiveEventAlt1Error](Errors/DeleteLiveEventAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteLiveEventAlt2(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes a single event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEssentials.DeleteLiveEventAlt2(liveEventId);
}
catch (SdkException<DeleteLiveEventAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteLiveEventAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteLiveEventAlt2Error](Errors/DeleteLiveEventAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteLiveEvents(double userId, UsersLiveEventsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes multiple events belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEssentials.DeleteLiveEvents(userId, body);
}
catch (SdkException<DeleteLiveEventsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteLiveEventsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsRequest](Models/UsersLiveEventsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteLiveEventsError](Errors/DeleteLiveEventsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteLiveEventsAlt1(LiveEventsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes multiple events belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEssentials.DeleteLiveEventsAlt1(body);
}
catch (SdkException<DeleteLiveEventsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteLiveEventsAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[LiveEventsRequest](Models/LiveEventsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteLiveEventsAlt1Error](Errors/DeleteLiveEventsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteLiveEventsAlt2(MeLiveEventsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes multiple events belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEssentials.DeleteLiveEventsAlt2(body);
}
catch (SdkException<DeleteLiveEventsAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteLiveEventsAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[MeLiveEventsRequest](Models/MeLiveEventsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteLiveEventsAlt2Error](Errors/DeleteLiveEventsAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringEvent&gt; GetLiveEvent(double liveEventId, double userId, string? password, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.GetLiveEvent(liveEventId, userId, password);
    // TODO: Handle 'response' of type RecurringEvent
}
catch (SdkException<GetLiveEventError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>password</code> | <code>string?</code> | The password of the event when the privacy is set to `password`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEvent](Models/RecurringEvent.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventError](Errors/GetLiveEventError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringEvent&gt; GetLiveEventAlt1(double liveEventId, string? password, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.GetLiveEventAlt1(liveEventId, password);
    // TODO: Handle 'response' of type RecurringEvent
}
catch (SdkException<GetLiveEventAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>password</code> | <code>string?</code> | The password of the event when the privacy is set to `password`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEvent](Models/RecurringEvent.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventAlt1Error](Errors/GetLiveEventAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringEvent&gt; GetLiveEventAlt2(double liveEventId, string? password, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.GetLiveEventAlt2(liveEventId, password);
    // TODO: Handle 'response' of type RecurringEvent
}
catch (SdkException<GetLiveEventAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>password</code> | <code>string?</code> | The password of the event when the privacy is set to `password`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEvent](Models/RecurringEvent.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventAlt2Error](Errors/GetLiveEventAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LiveEventOccurrenceConnection&gt; GetLiveEventOccurrences(double userId, string startDate, string? endDate, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all live event occurrences for the user within the given date range.

For recurring events (with rrule), each occurrence within the range is returned as a separate entry.
For one-time events (no rrule), the event is included if its start_time falls within the range.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.GetLiveEventOccurrences(userId, startDate, endDate, page, perPage);
    // TODO: Handle 'response' of type LiveEventOccurrenceConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>startDate</code> | <code>string</code> | The start of the date range in ISO 8601 format. |
| <code>endDate</code> | <code>string?</code> | The end of the date range in ISO 8601 format. Defaults to 7 days after start. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LiveEventOccurrenceConnection](Models/LiveEventOccurrenceConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventConnection&gt; GetLiveEvents(double userId, Direction? direction, Filter8? filter, double? page, double? perPage, string? query, Sort8? sort, Type31? type, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The method returns every event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.GetLiveEvents(userId,
        direction,
        filter,
        page,
        perPage,
        query,
        sort,
        type);
    // TODO: Handle 'response' of type EventConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter8?](Models/Enums/Filter8.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `not_in_folder` - Show only events that aren't in a folder.<br> * `not_in_showcase` - Show only events that aren't in a showcase. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date. |
| <code>type</code> | <code>[Type31?](Models/Enums/Type31.cs)</code> | The type of event to return.<br><br>Option descriptions:<br> * `all` - Return all events.<br> * `one_time` - Return one-time events only.<br> * `recurring` - Return recurring events only. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventConnection](Models/EventConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventConnection&gt; GetLiveEventsAlt1(Direction? direction, Filter8? filter, double? page, double? perPage, string? query, Sort8? sort, Type31? type, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The method returns every event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.GetLiveEventsAlt1(direction, filter, page, perPage, query, sort, type);
    // TODO: Handle 'response' of type EventConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter8?](Models/Enums/Filter8.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `not_in_folder` - Show only events that aren't in a folder.<br> * `not_in_showcase` - Show only events that aren't in a showcase. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date. |
| <code>type</code> | <code>[Type31?](Models/Enums/Type31.cs)</code> | The type of event to return.<br><br>Option descriptions:<br> * `all` - Return all events.<br> * `one_time` - Return one-time events only.<br> * `recurring` - Return recurring events only. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventConnection](Models/EventConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventConnection&gt; GetLiveEventsAlt2(Direction? direction, Filter8? filter, double? page, double? perPage, string? query, Sort8? sort, Type31? type, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The method returns every event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.GetLiveEventsAlt2(direction, filter, page, perPage, query, sort, type);
    // TODO: Handle 'response' of type EventConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter8?](Models/Enums/Filter8.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `not_in_folder` - Show only events that aren't in a folder.<br> * `not_in_showcase` - Show only events that aren't in a showcase. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date. |
| <code>type</code> | <code>[Type31?](Models/Enums/Type31.cs)</code> | The type of event to return.<br><br>Option descriptions:<br> * `all` - Return all events.<br> * `one_time` - Return one-time events only.<br> * `recurring` - Return recurring events only. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventConnection](Models/EventConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringEvent&gt; UpdateLiveEvent(double liveEventId, double userId, UsersLiveEventsRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method updates an event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.UpdateLiveEvent(liveEventId, userId, body);
    // TODO: Handle 'response' of type RecurringEvent
}
catch (SdkException<UpdateLiveEventError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UpdateLiveEventError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsRequest2?](Models/UsersLiveEventsRequest2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEvent](Models/RecurringEvent.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateLiveEventError](Errors/UpdateLiveEventError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringEvent&gt; UpdateLiveEventAlt1(double liveEventId, LiveEventsRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method updates an event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.UpdateLiveEventAlt1(liveEventId, body);
    // TODO: Handle 'response' of type RecurringEvent
}
catch (SdkException<UpdateLiveEventAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UpdateLiveEventAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[LiveEventsRequest2?](Models/LiveEventsRequest2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEvent](Models/RecurringEvent.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateLiveEventAlt1Error](Errors/UpdateLiveEventAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringEvent&gt; UpdateLiveEventAlt2(double liveEventId, MeLiveEventsRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method updates an event belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEssentials.UpdateLiveEventAlt2(liveEventId, body);
    // TODO: Handle 'response' of type RecurringEvent
}
catch (SdkException<UpdateLiveEventAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UpdateLiveEventAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[MeLiveEventsRequest2?](Models/MeLiveEventsRequest2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEvent](Models/RecurringEvent.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateLiveEventAlt2Error](Errors/UpdateLiveEventAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveEventM3U8Playback

> Source: [LiveEventM3U8Playback](Api/LiveEventM3U8Playback.cs)

<details>
<summary><code>Task GetLiveEventM3U8Playback(double liveEventId, double userId, double? dvr, double? maxFpsFhd, double? ttl, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns an M3U8 playback URL for the specified event stream. You should use this endpoint only in conjunction with our recommended procedure for playing events via HLS. For more information, see our [HLS guide](https://developer.vimeo.com/api/live/playback).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventM3U8Playback.GetLiveEventM3U8Playback(liveEventId, userId, dvr, maxFpsFhd, ttl);
}
catch (SdkException<GetLiveEventM3U8PlaybackError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventM3U8PlaybackError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>dvr</code> | <code>double?</code> | When set to `1`, returns an fMP4 stream URL if DVR is enabled on the event. If DVR is not enabled, the standard stream URL is returned. |
| <code>maxFpsFhd</code> | <code>double?</code> | The requested maximum frames per second. |
| <code>ttl</code> | <code>double?</code> | The time to live of the playlist link in seconds. This value must be between `10` and `60`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventM3U8PlaybackError](Errors/GetLiveEventM3U8PlaybackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetLiveEventM3U8PlaybackAlt1(double liveEventId, double? dvr, double? maxFpsFhd, double? ttl, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns an M3U8 playback URL for the specified event stream. You should use this endpoint only in conjunction with our recommended procedure for playing events via HLS. For more information, see our [HLS guide](https://developer.vimeo.com/api/live/playback).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventM3U8Playback.GetLiveEventM3U8PlaybackAlt1(liveEventId, dvr, maxFpsFhd, ttl);
}
catch (SdkException<GetLiveEventM3U8PlaybackAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventM3U8PlaybackAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>dvr</code> | <code>double?</code> | When set to `1`, returns an fMP4 stream URL if DVR is enabled on the event. If DVR is not enabled, the standard stream URL is returned. |
| <code>maxFpsFhd</code> | <code>double?</code> | The requested maximum frames per second. |
| <code>ttl</code> | <code>double?</code> | The time to live of the playlist link in seconds. This value must be between `10` and `60`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventM3U8PlaybackAlt1Error](Errors/GetLiveEventM3U8PlaybackAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveEventActivation

> Source: [LiveEventActivation](Api/LiveEventActivation.cs)

<details>
<summary><code>Task&lt;Video&gt; ActivateLiveEvent(double liveEventId, double userId, UsersLiveEventsActivateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates the necessary RTMP links for the specified event. Begin streaming to these links to trigger the event on Vimeo. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventActivation.ActivateLiveEvent(liveEventId, userId, body);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<ActivateLiveEventError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ActivateLiveEventError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsActivateRequest?](Models/UsersLiveEventsActivateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ActivateLiveEventError](Errors/ActivateLiveEventError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; ActivateLiveEventAlt1(double liveEventId, LiveEventsActivateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates the necessary RTMP links for the specified event. Begin streaming to these links to trigger the event on Vimeo. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventActivation.ActivateLiveEventAlt1(liveEventId, body);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<ActivateLiveEventAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ActivateLiveEventAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[LiveEventsActivateRequest?](Models/LiveEventsActivateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ActivateLiveEventAlt1Error](Errors/ActivateLiveEventAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; ActivateLiveEventAlt2(double liveEventId, MeLiveEventsActivateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates the necessary RTMP links for the specified event. Begin streaming to these links to trigger the event on Vimeo. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventActivation.ActivateLiveEventAlt2(liveEventId, body);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<ActivateLiveEventAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ActivateLiveEventAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[MeLiveEventsActivateRequest?](Models/MeLiveEventsActivateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ActivateLiveEventAlt2Error](Errors/ActivateLiveEventAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveEventAutomatedClosedCaptions

> Source: [LiveEventAutomatedClosedCaptions](Api/LiveEventAutomatedClosedCaptions.cs)

<details>
<summary><code>Task&lt;EventAutomatedClosedCaptions&gt; EditLiveEventAutoCc(double liveEventId, double userId, UsersLiveEventsAutoCcRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the automated closed captions preference for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventAutomatedClosedCaptions.EditLiveEventAutoCc(liveEventId, userId, body);
    // TODO: Handle 'response' of type EventAutomatedClosedCaptions
}
catch (SdkException<EditLiveEventAutoCcError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditLiveEventAutoCcError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsAutoCcRequest](Models/UsersLiveEventsAutoCcRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventAutomatedClosedCaptions](Models/EventAutomatedClosedCaptions.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditLiveEventAutoCcError](Errors/EditLiveEventAutoCcError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventAutomatedClosedCaptions&gt; EditLiveEventAutoCcAlt1(double liveEventId, LiveEventsAutoCcRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the automated closed captions preference for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventAutomatedClosedCaptions.EditLiveEventAutoCcAlt1(liveEventId, body);
    // TODO: Handle 'response' of type EventAutomatedClosedCaptions
}
catch (SdkException<EditLiveEventAutoCcAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditLiveEventAutoCcAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[LiveEventsAutoCcRequest](Models/LiveEventsAutoCcRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventAutomatedClosedCaptions](Models/EventAutomatedClosedCaptions.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditLiveEventAutoCcAlt1Error](Errors/EditLiveEventAutoCcAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventAutomatedClosedCaptions&gt; EditLiveEventAutoCcAlt2(double liveEventId, MeLiveEventsAutoCcRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the automated closed captions preference for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventAutomatedClosedCaptions.EditLiveEventAutoCcAlt2(liveEventId, body);
    // TODO: Handle 'response' of type EventAutomatedClosedCaptions
}
catch (SdkException<EditLiveEventAutoCcAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditLiveEventAutoCcAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[MeLiveEventsAutoCcRequest](Models/MeLiveEventsAutoCcRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventAutomatedClosedCaptions](Models/EventAutomatedClosedCaptions.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditLiveEventAutoCcAlt2Error](Errors/EditLiveEventAutoCcAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveEventDestinations

> Source: [LiveEventDestinations](Api/LiveEventDestinations.cs)

<details>
<summary><code>Task&lt;EventDestination&gt; CreateLiveEventDestination(double liveEventId, MeLiveEventsDestinationsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a destination for the specified event. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventDestinations.CreateLiveEventDestination(liveEventId, body);
    // TODO: Handle 'response' of type EventDestination
}
catch (SdkException<CreateLiveEventDestinationError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateLiveEventDestinationError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[MeLiveEventsDestinationsRequest](Models/MeLiveEventsDestinationsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventDestination](Models/EventDestination.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateLiveEventDestinationError](Errors/CreateLiveEventDestinationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventDestination&gt; CreateLiveEventDestinationAlt1(double liveEventId, double userId, UsersLiveEventsDestinationsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a destination for the specified event. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventDestinations.CreateLiveEventDestinationAlt1(liveEventId, userId, body);
    // TODO: Handle 'response' of type EventDestination
}
catch (SdkException<CreateLiveEventDestinationAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateLiveEventDestinationAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsDestinationsRequest](Models/UsersLiveEventsDestinationsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventDestination](Models/EventDestination.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateLiveEventDestinationAlt1Error](Errors/CreateLiveEventDestinationAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OttDestination&gt; CreateOttDestination(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates an OTT channel as the destination of the specified event. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventDestinations.CreateOttDestination(liveEventId, userId);
    // TODO: Handle 'response' of type OttDestination
}
catch (SdkException<CreateOttDestinationError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateOttDestinationError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OttDestination](Models/OttDestination.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateOttDestinationError](Errors/CreateOttDestinationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteLiveEventDestination(double destinationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified event destination belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventDestinations.DeleteLiveEventDestination(destinationId);
}
catch (SdkException<DeleteLiveEventDestinationError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteLiveEventDestinationError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>destinationId</code> | <code>double</code> | The ID of the event destination. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteLiveEventDestinationError](Errors/DeleteLiveEventDestinationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteOttDestination(double liveEventId, double userId, string destinationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes an OTT channel as the destination of the specified event. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventDestinations.DeleteOttDestination(liveEventId, userId, destinationId);
}
catch (SdkException<DeleteOttDestinationError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteOttDestinationError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>destinationId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteOttDestinationError](Errors/DeleteOttDestinationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetAvailableDestinations(double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every available event destination for the authenticated user to stream to.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventDestinations.GetAvailableDestinations(userId);
}
catch (SdkException<GetAvailableDestinationsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAvailableDestinationsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The user ID of the team owner. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAvailableDestinationsError](Errors/GetAvailableDestinationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetAvailableDestinationsAlt1(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every available event destination for the authenticated user to stream to.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventDestinations.GetAvailableDestinationsAlt1();
}
catch (SdkException<GetAvailableDestinationsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAvailableDestinationsAlt1Error
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAvailableDestinationsAlt1Error](Errors/GetAvailableDestinationsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventDestination&gt; GetLiveEventDestination(double destinationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified event destination belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventDestinations.GetLiveEventDestination(destinationId);
    // TODO: Handle 'response' of type EventDestination
}
catch (SdkException<GetLiveEventDestinationError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventDestinationError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>destinationId</code> | <code>double</code> | The ID of the event destination. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventDestination](Models/EventDestination.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventDestinationError](Errors/GetLiveEventDestinationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventDestinationConnection&gt; GetLiveEventDestinations(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every destination of the specified event. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventDestinations.GetLiveEventDestinations(liveEventId);
    // TODO: Handle 'response' of type EventDestinationConnection
}
catch (SdkException<GetLiveEventDestinationsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventDestinationsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventDestinationConnection](Models/EventDestinationConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventDestinationsError](Errors/GetLiveEventDestinationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventDestinationConnection&gt; GetLiveEventDestinationsAlt1(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every destination of the specified event. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventDestinations.GetLiveEventDestinationsAlt1(liveEventId, userId);
    // TODO: Handle 'response' of type EventDestinationConnection
}
catch (SdkException<GetLiveEventDestinationsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventDestinationsAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventDestinationConnection](Models/EventDestinationConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventDestinationsAlt1Error](Errors/GetLiveEventDestinationsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OttDestinationConnection&gt; GetOttDestinations(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every OTT destination of the specified event. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventDestinations.GetOttDestinations(liveEventId, userId);
    // TODO: Handle 'response' of type OttDestinationConnection
}
catch (SdkException<GetOttDestinationsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetOttDestinationsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OttDestinationConnection](Models/OttDestinationConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetOttDestinationsError](Errors/GetOttDestinationsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventDestination&gt; UpdateLiveEventDestination(double destinationId, DestinationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method updates the specified event destination belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventDestinations.UpdateLiveEventDestination(destinationId, body);
    // TODO: Handle 'response' of type EventDestination
}
catch (SdkException<UpdateLiveEventDestinationError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UpdateLiveEventDestinationError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>destinationId</code> | <code>double</code> | The ID of the event destination. |
| <code>body</code> | <code>[DestinationRequest?](Models/DestinationRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventDestination](Models/EventDestination.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateLiveEventDestinationError](Errors/UpdateLiveEventDestinationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveEventEnd

> Source: [LiveEventEnd](Api/LiveEventEnd.cs)

<details>
<summary><code>Task&lt;Video&gt; EndLiveEvent(double liveEventId, string userId, double? clipId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method ends the specified event. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventEnd.EndLiveEvent(liveEventId, userId, clipId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<EndLiveEventError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EndLiveEventError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>string</code> | - |
| <code>clipId</code> | <code>double?</code> | The ID of the streamable video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EndLiveEventError](Errors/EndLiveEventError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; EndLiveEventAlt1(double liveEventId, double? clipId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method ends the specified event. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventEnd.EndLiveEventAlt1(liveEventId, clipId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<EndLiveEventAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EndLiveEventAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>clipId</code> | <code>double?</code> | The ID of the streamable video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EndLiveEventAlt1Error](Errors/EndLiveEventAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; EndLiveEventAlt2(double liveEventId, double? clipId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method ends the specified event. The authenticated user must be the owner of the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventEnd.EndLiveEventAlt2(liveEventId, clipId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<EndLiveEventAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EndLiveEventAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>clipId</code> | <code>double?</code> | The ID of the streamable video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EndLiveEventAlt2Error](Errors/EndLiveEventAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveEventLowLatency

> Source: [LiveEventLowLatency](Api/LiveEventLowLatency.cs)

<details>
<summary><code>Task&lt;RecurringEventLowLatency&gt; ToggleRleLowLatency(double liveEventId, double userId, UsersLiveEventsLowLatencyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method toggles the low-latency option of the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventLowLatency.ToggleRleLowLatency(liveEventId, userId, body);
    // TODO: Handle 'response' of type RecurringEventLowLatency
}
catch (SdkException<ToggleRleLowLatencyError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ToggleRleLowLatencyError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsLowLatencyRequest?](Models/UsersLiveEventsLowLatencyRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEventLowLatency](Models/RecurringEventLowLatency.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ToggleRleLowLatencyError](Errors/ToggleRleLowLatencyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringEventLowLatency&gt; ToggleRleLowLatencyAlt1(double liveEventId, LiveEventsLowLatencyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method toggles the low-latency option of the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventLowLatency.ToggleRleLowLatencyAlt1(liveEventId, body);
    // TODO: Handle 'response' of type RecurringEventLowLatency
}
catch (SdkException<ToggleRleLowLatencyAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ToggleRleLowLatencyAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[LiveEventsLowLatencyRequest?](Models/LiveEventsLowLatencyRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEventLowLatency](Models/RecurringEventLowLatency.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ToggleRleLowLatencyAlt1Error](Errors/ToggleRleLowLatencyAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;RecurringEventLowLatency&gt; ToggleRleLowLatencyAlt2(double liveEventId, MeLiveEventsLowLatencyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method toggles the low-latency option of the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventLowLatency.ToggleRleLowLatencyAlt2(liveEventId, body);
    // TODO: Handle 'response' of type RecurringEventLowLatency
}
catch (SdkException<ToggleRleLowLatencyAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ToggleRleLowLatencyAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[MeLiveEventsLowLatencyRequest?](Models/MeLiveEventsLowLatencyRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[RecurringEventLowLatency](Models/RecurringEventLowLatency.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ToggleRleLowLatencyAlt2Error](Errors/ToggleRleLowLatencyAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveEventSessions

> Source: [LiveEventSessions](Api/LiveEventSessions.cs)

<details>
<summary><code>Task&lt;EventSessionStatus&gt; GetLiveClipIngestStatus(string liveEventId, double? clipId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the ingest status of the specified event and associated video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventSessions.GetLiveClipIngestStatus(liveEventId, clipId);
    // TODO: Handle 'response' of type EventSessionStatus
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>string</code> | - |
| <code>clipId</code> | <code>double?</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventSessionStatus](Models/EventSessionStatus.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EventSessionStatus&gt; GetLiveIngestStatus(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the ingest status of the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventSessions.GetLiveIngestStatus(videoId);
    // TODO: Handle 'response' of type EventSessionStatus
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EventSessionStatus](Models/EventSessionStatus.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveEventThumbnails

> Source: [LiveEventThumbnails](Api/LiveEventThumbnails.cs)

<details>
<summary><code>Task&lt;Picture&gt; CreateLiveEventThumbnail(double liveEventId, double userId, UsersLiveEventsPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a thumbnail image for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.CreateLiveEventThumbnail(liveEventId, userId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<CreateLiveEventThumbnailError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateLiveEventThumbnailError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsPicturesRequest?](Models/UsersLiveEventsPicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateLiveEventThumbnailError](Errors/CreateLiveEventThumbnailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; CreateLiveEventThumbnailAlt1(double liveEventId, LiveEventsPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a thumbnail image for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.CreateLiveEventThumbnailAlt1(liveEventId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<CreateLiveEventThumbnailAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateLiveEventThumbnailAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[LiveEventsPicturesRequest?](Models/LiveEventsPicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateLiveEventThumbnailAlt1Error](Errors/CreateLiveEventThumbnailAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; CreateLiveEventThumbnailAlt2(double liveEventId, MeLiveEventsPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a thumbnail image for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.CreateLiveEventThumbnailAlt2(liveEventId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<CreateLiveEventThumbnailAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateLiveEventThumbnailAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[MeLiveEventsPicturesRequest?](Models/MeLiveEventsPicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateLiveEventThumbnailAlt2Error](Errors/CreateLiveEventThumbnailAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteLiveEventThumbnail(double liveEventId, double thumbnailId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes a thumbnail image for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventThumbnails.DeleteLiveEventThumbnail(liveEventId, thumbnailId, userId);
}
catch (SdkException<DeleteLiveEventThumbnailError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteLiveEventThumbnailError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the thumbnail. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteLiveEventThumbnailError](Errors/DeleteLiveEventThumbnailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteLiveEventThumbnailAlt1(double liveEventId, double thumbnailId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes a thumbnail image for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventThumbnails.DeleteLiveEventThumbnailAlt1(liveEventId, thumbnailId);
}
catch (SdkException<DeleteLiveEventThumbnailAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteLiveEventThumbnailAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the thumbnail. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteLiveEventThumbnailAlt1Error](Errors/DeleteLiveEventThumbnailAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteLiveEventThumbnailAlt2(double liveEventId, double thumbnailId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes a thumbnail image for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventThumbnails.DeleteLiveEventThumbnailAlt2(liveEventId, thumbnailId);
}
catch (SdkException<DeleteLiveEventThumbnailAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteLiveEventThumbnailAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the thumbnail. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteLiveEventThumbnailAlt2Error](Errors/DeleteLiveEventThumbnailAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; EditLiveEventThumbnail(double liveEventId, double thumbnailId, double userId, UsersLiveEventsPicturesThumbnailIdRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits a thumbnail image for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.EditLiveEventThumbnail(liveEventId, thumbnailId, userId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<EditLiveEventThumbnailError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditLiveEventThumbnailError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the thumbnail. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsPicturesThumbnailIdRequest?](Models/UsersLiveEventsPicturesThumbnailIdRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditLiveEventThumbnailError](Errors/EditLiveEventThumbnailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; EditLiveEventThumbnailAlt1(double liveEventId, double thumbnailId, LiveEventsPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits a thumbnail image for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.EditLiveEventThumbnailAlt1(liveEventId, thumbnailId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<EditLiveEventThumbnailAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditLiveEventThumbnailAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the thumbnail. |
| <code>body</code> | <code>[LiveEventsPicturesRequest?](Models/LiveEventsPicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditLiveEventThumbnailAlt1Error](Errors/EditLiveEventThumbnailAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; EditLiveEventThumbnailAlt2(double liveEventId, double thumbnailId, MeLiveEventsPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits a thumbnail image for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.EditLiveEventThumbnailAlt2(liveEventId, thumbnailId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<EditLiveEventThumbnailAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditLiveEventThumbnailAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the thumbnail. |
| <code>body</code> | <code>[MeLiveEventsPicturesRequest?](Models/MeLiveEventsPicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditLiveEventThumbnailAlt2Error](Errors/EditLiveEventThumbnailAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetLiveEventThumbnail(double liveEventId, double thumbnailId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single thumbnail image of the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.GetLiveEventThumbnail(liveEventId, thumbnailId, userId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetLiveEventThumbnailError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventThumbnailError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the thumbnail. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventThumbnailError](Errors/GetLiveEventThumbnailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetLiveEventThumbnailAlt1(double liveEventId, double thumbnailId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single thumbnail image of the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.GetLiveEventThumbnailAlt1(liveEventId, thumbnailId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetLiveEventThumbnailAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventThumbnailAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the thumbnail. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventThumbnailAlt1Error](Errors/GetLiveEventThumbnailAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetLiveEventThumbnailAlt2(double liveEventId, double thumbnailId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single thumbnail image of the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.GetLiveEventThumbnailAlt2(liveEventId, thumbnailId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetLiveEventThumbnailAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventThumbnailAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the thumbnail. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventThumbnailAlt2Error](Errors/GetLiveEventThumbnailAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetLiveEventThumbnails(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every thumbnail image of the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.GetLiveEventThumbnails(liveEventId, userId);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<GetLiveEventThumbnailsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventThumbnailsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventThumbnailsError](Errors/GetLiveEventThumbnailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetLiveEventThumbnailsAlt1(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every thumbnail image of the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.GetLiveEventThumbnailsAlt1(liveEventId);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<GetLiveEventThumbnailsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventThumbnailsAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventThumbnailsAlt1Error](Errors/GetLiveEventThumbnailsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetLiveEventThumbnailsAlt2(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every thumbnail image of the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventThumbnails.GetLiveEventThumbnailsAlt2(liveEventId);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<GetLiveEventThumbnailsAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventThumbnailsAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventThumbnailsAlt2Error](Errors/GetLiveEventThumbnailsAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveEventVideos

> Source: [LiveEventVideos](Api/LiveEventVideos.cs)

<details>
<summary><code>Task AddVideosToLiveEvent(double liveEventId, double userId, UsersLiveEventsVideosRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds multiple videos to the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventVideos.AddVideosToLiveEvent(liveEventId, userId, body);
}
catch (SdkException<AddVideosToLiveEventError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideosToLiveEventError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsVideosRequest1?](Models/UsersLiveEventsVideosRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideosToLiveEventError](Errors/AddVideosToLiveEventError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AddVideosToLiveEventAlt1(double liveEventId, LiveEventsVideosRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds multiple videos to the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventVideos.AddVideosToLiveEventAlt1(liveEventId, body);
}
catch (SdkException<AddVideosToLiveEventAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideosToLiveEventAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[LiveEventsVideosRequest1?](Models/LiveEventsVideosRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideosToLiveEventAlt1Error](Errors/AddVideosToLiveEventAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AddVideosToLiveEventAlt2(double liveEventId, MeLiveEventsVideosRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds multiple videos to the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventVideos.AddVideosToLiveEventAlt2(liveEventId, body);
}
catch (SdkException<AddVideosToLiveEventAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideosToLiveEventAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[MeLiveEventsVideosRequest1?](Models/MeLiveEventsVideosRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideosToLiveEventAlt2Error](Errors/AddVideosToLiveEventAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; GetLiveEventVideo(double liveEventId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video in the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventVideos.GetLiveEventVideo(liveEventId, userId, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<GetLiveEventVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventVideoError](Errors/GetLiveEventVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; GetLiveEventVideoAlt1(double liveEventId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video in the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventVideos.GetLiveEventVideoAlt1(liveEventId, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<GetLiveEventVideoAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventVideoAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventVideoAlt1Error](Errors/GetLiveEventVideoAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; GetLiveEventVideoAlt2(double liveEventId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video in the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventVideos.GetLiveEventVideoAlt2(liveEventId, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<GetLiveEventVideoAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventVideoAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventVideoAlt2Error](Errors/GetLiveEventVideoAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetLiveEventVideos(double liveEventId, double userId, string? containingUri, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort17? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video in the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventVideos.GetLiveEventVideos(liveEventId,
        userId,
        containingUri,
        direction,
        filter,
        filterEmbeddable,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetLiveEventVideosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventVideosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>containingUri</code> | <code>string?</code> | The page that contains the video URI. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable events. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort17?](Models/Enums/Sort17.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `added` - Sort the results by most recently added videos.<br> * `alphabetical` - Sort the results alphabetically.<br> * `arranged` - Sort the results in the order that the user has arranged the videos.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by creation date.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventVideosError](Errors/GetLiveEventVideosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetLiveEventVideosAlt1(double liveEventId, string? containingUri, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort17? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video in the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventVideos.GetLiveEventVideosAlt1(liveEventId,
        containingUri,
        direction,
        filter,
        filterEmbeddable,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetLiveEventVideosAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventVideosAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>containingUri</code> | <code>string?</code> | The page that contains the video URI. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable events. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort17?](Models/Enums/Sort17.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `added` - Sort the results by most recently added videos.<br> * `alphabetical` - Sort the results alphabetically.<br> * `arranged` - Sort the results in the order that the user has arranged the videos.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by creation date.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventVideosAlt1Error](Errors/GetLiveEventVideosAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetLiveEventVideosAlt2(double liveEventId, string? containingUri, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort17? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video in the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveEventVideos.GetLiveEventVideosAlt2(liveEventId,
        containingUri,
        direction,
        filter,
        filterEmbeddable,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetLiveEventVideosAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetLiveEventVideosAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>containingUri</code> | <code>string?</code> | The page that contains the video URI. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable events. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort17?](Models/Enums/Sort17.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `added` - Sort the results by most recently added videos.<br> * `alphabetical` - Sort the results alphabetically.<br> * `arranged` - Sort the results in the order that the user has arranged the videos.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by creation date.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetLiveEventVideosAlt2Error](Errors/GetLiveEventVideosAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveVideosFromLiveEvent(double liveEventId, double userId, UsersLiveEventsVideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes multiple videos from the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventVideos.RemoveVideosFromLiveEvent(liveEventId, userId, body);
}
catch (SdkException<RemoveVideosFromLiveEventError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveVideosFromLiveEventError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersLiveEventsVideosRequest?](Models/UsersLiveEventsVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveVideosFromLiveEventError](Errors/RemoveVideosFromLiveEventError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveVideosFromLiveEventAlt1(double liveEventId, LiveEventsVideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes multiple videos from the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventVideos.RemoveVideosFromLiveEventAlt1(liveEventId, body);
}
catch (SdkException<RemoveVideosFromLiveEventAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveVideosFromLiveEventAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[LiveEventsVideosRequest?](Models/LiveEventsVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveVideosFromLiveEventAlt1Error](Errors/RemoveVideosFromLiveEventAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveVideosFromLiveEventAlt2(double liveEventId, MeLiveEventsVideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes multiple videos from the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveEventVideos.RemoveVideosFromLiveEventAlt2(liveEventId, body);
}
catch (SdkException<RemoveVideosFromLiveEventAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveVideosFromLiveEventAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[MeLiveEventsVideosRequest?](Models/MeLiveEventsVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveVideosFromLiveEventAlt2Error](Errors/RemoveVideosFromLiveEventAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveGraphics

> Source: [LiveGraphics](Api/LiveGraphics.cs)

<details>
<summary><code>Task&lt;ComposerGraphics&gt; AddComposerVideoGraphicItem(double liveEventId, LiveEventsComposerGraphicsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method add a new video graphics item to the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveGraphics.AddComposerVideoGraphicItem(liveEventId, body);
    // TODO: Handle 'response' of type ComposerGraphics
}
catch (SdkException<AddComposerVideoGraphicItemError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddComposerVideoGraphicItemError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[LiveEventsComposerGraphicsVideosRequest](Models/LiveEventsComposerGraphicsVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ComposerGraphics](Models/ComposerGraphics.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddComposerVideoGraphicItemError](Errors/AddComposerVideoGraphicItemError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteComposerVideoGraphicItem(double liveEventId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes a video graphics item belonging to the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.LiveGraphics.DeleteComposerVideoGraphicItem(liveEventId, videoId);
}
catch (SdkException<DeleteComposerVideoGraphicItemError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteComposerVideoGraphicItemError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>videoId</code> | <code>double</code> | The ID of the associated video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteComposerVideoGraphicItemError](Errors/DeleteComposerVideoGraphicItemError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ComposerGraphicsConnection&gt; GetComposerVideoGraphicItems(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The method returns every video graphics item belonging to the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveGraphics.GetComposerVideoGraphicItems(liveEventId);
    // TODO: Handle 'response' of type ComposerGraphicsConnection
}
catch (SdkException<GetComposerVideoGraphicItemsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetComposerVideoGraphicItemsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ComposerGraphicsConnection](Models/ComposerGraphicsConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetComposerVideoGraphicItemsError](Errors/GetComposerVideoGraphicItemsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## LiveScenes

> Source: [LiveScenes](Api/LiveScenes.cs)

<details>
<summary><code>Task&lt;ComposerScenes&gt; AttachGraphicItemToScene(double liveEventId, string sceneId, LiveEventsComposerScenesGraphicsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method attaches a graphic item to the specified scene.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveScenes.AttachGraphicItemToScene(liveEventId, sceneId, body);
    // TODO: Handle 'response' of type ComposerScenes
}
catch (SdkException<AttachGraphicItemToSceneError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AttachGraphicItemToSceneError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>sceneId</code> | <code>string</code> | The ID of the scene. |
| <code>body</code> | <code>[LiveEventsComposerScenesGraphicsRequest](Models/LiveEventsComposerScenesGraphicsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ComposerScenes](Models/ComposerScenes.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AttachGraphicItemToSceneError](Errors/AttachGraphicItemToSceneError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ComposerScenes&gt; CreateComposerScene(double liveEventId, LiveEventsComposerScenesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The method creates a new scene for the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveScenes.CreateComposerScene(liveEventId, body);
    // TODO: Handle 'response' of type ComposerScenes
}
catch (SdkException<CreateComposerSceneError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateComposerSceneError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>body</code> | <code>[LiveEventsComposerScenesRequest?](Models/LiveEventsComposerScenesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ComposerScenes](Models/ComposerScenes.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateComposerSceneError](Errors/CreateComposerSceneError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ComposerScenesConnection&gt; GetComposerScenes(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The method returns every scene belonging to the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveScenes.GetComposerScenes(liveEventId);
    // TODO: Handle 'response' of type ComposerScenesConnection
}
catch (SdkException<GetComposerScenesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetComposerScenesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ComposerScenesConnection](Models/ComposerScenesConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetComposerScenesError](Errors/GetComposerScenesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ComposerScenes&gt;&gt; ResetComposerScenes(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The method resets the scenes that belong to the specified event by deleting every existing scene and then recreating the default scene.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveScenes.ResetComposerScenes(liveEventId);
    // TODO: Handle 'response' of type IReadOnlyList<ComposerScenes>
}
catch (SdkException<ResetComposerScenesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ResetComposerScenesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ComposerScenes](Models/ComposerScenes.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ResetComposerScenesError](Errors/ResetComposerScenesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ComposerScenes&gt; UpdateComposerScene(double liveEventId, string sceneId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The method updates a scene belonging to the specified event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiveScenes.UpdateComposerScene(liveEventId, sceneId);
    // TODO: Handle 'response' of type ComposerScenes
}
catch (SdkException<UpdateComposerSceneError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UpdateComposerSceneError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>liveEventId</code> | <code>double</code> | The ID of the event. |
| <code>sceneId</code> | <code>string</code> | The ID of the scene. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ComposerScenes](Models/ComposerScenes.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateComposerSceneError](Errors/UpdateComposerSceneError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OnDemandBackgrounds

> Source: [OnDemandBackgrounds](Api/OnDemandBackgrounds.cs)

<details>
<summary><code>Task&lt;Picture&gt; CreateVodBackground(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a background image to the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandBackgrounds.CreateVodBackground(ondemandId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<CreateVodBackgroundError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateVodBackgroundError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateVodBackgroundError](Errors/CreateVodBackgroundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVodBackground(double backgroundId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified background image on an On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.OnDemandBackgrounds.DeleteVodBackground(backgroundId, ondemandId);
}
catch (SdkException<DeleteVodBackgroundError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVodBackgroundError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>backgroundId</code> | <code>double</code> | The ID of the background image. |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVodBackgroundError](Errors/DeleteVodBackgroundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; EditVodBackground(double backgroundId, double ondemandId, OndemandPagesBackgroundsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified background image on an On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandBackgrounds.EditVodBackground(backgroundId, ondemandId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<EditVodBackgroundError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditVodBackgroundError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>backgroundId</code> | <code>double</code> | The ID of the background image. |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>body</code> | <code>[OndemandPagesBackgroundsRequest?](Models/OndemandPagesBackgroundsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditVodBackgroundError](Errors/EditVodBackgroundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetVodBackground(double backgroundId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single background image on the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandBackgrounds.GetVodBackground(backgroundId, ondemandId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetVodBackgroundError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodBackgroundError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>backgroundId</code> | <code>double</code> | The ID of the background image. |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodBackgroundError](Errors/GetVodBackgroundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetVodBackgrounds(double ondemandId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every background image on the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandBackgrounds.GetVodBackgrounds(ondemandId, page, perPage);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<GetVodBackgroundsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodBackgroundsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodBackgroundsError](Errors/GetVodBackgroundsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OnDemandEssentials

> Source: [OnDemandEssentials](Api/OnDemandEssentials.cs)

<details>
<summary><code>Task&lt;OnDemandPage&gt; CreateVod(double userId, UsersOndemandPagesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new On Demand page for the specified user. To publish the page, use the [edit](https://developer.vimeo.com/api/reference/on-demand#edit_vod) method.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandEssentials.CreateVod(userId, body);
    // TODO: Handle 'response' of type OnDemandPage
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersOndemandPagesRequest](Models/UsersOndemandPagesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPage](Models/OnDemandPage.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPage&gt; CreateVodAlt1(MeOndemandPagesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new On Demand page for the specified user. To publish the page, use the [edit](https://developer.vimeo.com/api/reference/on-demand#edit_vod) method.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandEssentials.CreateVodAlt1(body);
    // TODO: Handle 'response' of type OnDemandPage
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[MeOndemandPagesRequest](Models/MeOndemandPagesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPage](Models/OnDemandPage.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVodDraft(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified On Demand page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.OnDemandEssentials.DeleteVodDraft(ondemandId);
}
catch (SdkException<DeleteVodDraftError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVodDraftError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVodDraftError](Errors/DeleteVodDraftError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPage&gt; EditVod(double ondemandId, OndemandPagesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified On Demand page. Use this method to enable preorders on the page or to publish the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandEssentials.EditVod(ondemandId, body);
    // TODO: Handle 'response' of type OnDemandPage
}
catch (SdkException<EditVodError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditVodError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>body</code> | <code>[OndemandPagesRequest?](Models/OndemandPagesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPage](Models/OnDemandPage.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditVodError](Errors/EditVodError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPageConnection&gt; GetUserVods(double userId, Direction? direction, Filter18? filter, double? page, double? perPage, Sort32? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every On Demand page belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandEssentials.GetUserVods(userId, direction, filter, page, perPage, sort);
    // TODO: Handle 'response' of type OnDemandPageConnection
}
catch (SdkException<GetUserVodsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetUserVodsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter18?](Models/Enums/Filter18.cs)</code> | The type of the page to return.<br><br>Option descriptions:<br> * `film` - The page type is a film.<br> * `series` - The page type is a series. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort32?](Models/Enums/Sort32.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `added` - Sort the results by most recently added page.<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `modified_time` - Sort the results by time of page modification.<br> * `name` - Sort the results by page name.<br> * `publish.time` - Sort the results by time of page publishing.<br> * `rating` - Sort the results by content rating. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPageConnection](Models/OnDemandPageConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetUserVodsError](Errors/GetUserVodsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPageConnection&gt; GetUserVodsAlt1(Direction? direction, Filter18? filter, double? page, double? perPage, Sort32? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every On Demand page belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandEssentials.GetUserVodsAlt1(direction, filter, page, perPage, sort);
    // TODO: Handle 'response' of type OnDemandPageConnection
}
catch (SdkException<GetUserVodsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetUserVodsAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter18?](Models/Enums/Filter18.cs)</code> | The type of the page to return.<br><br>Option descriptions:<br> * `film` - The page type is a film.<br> * `series` - The page type is a series. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort32?](Models/Enums/Sort32.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `added` - Sort the results by most recently added page.<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `modified_time` - Sort the results by time of page modification.<br> * `name` - Sort the results by page name.<br> * `publish.time` - Sort the results by time of page publishing.<br> * `rating` - Sort the results by content rating. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPageConnection](Models/OnDemandPageConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetUserVodsAlt1Error](Errors/GetUserVodsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPage&gt; GetVod(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified On Demand page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandEssentials.GetVod(ondemandId);
    // TODO: Handle 'response' of type OnDemandPage
}
catch (SdkException<GetVodError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPage](Models/OnDemandPage.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodError](Errors/GetVodError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OnDemandGenres

> Source: [OnDemandGenres](Api/OnDemandGenres.cs)

<details>
<summary><code>Task&lt;OnDemandGenre&gt; AddVodGenre(string genreId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds the specified genre designation to an On Demand page. A page can be associated with a maximum of two genres. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandGenres.AddVodGenre(genreId, ondemandId);
    // TODO: Handle 'response' of type OnDemandGenre
}
catch (SdkException<AddVodGenreError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVodGenreError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>genreId</code> | <code>string</code> | The ID of the genre. |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandGenre](Models/OnDemandGenre.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVodGenreError](Errors/AddVodGenreError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVodGenre(string genreId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a genre association from the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.OnDemandGenres.DeleteVodGenre(genreId, ondemandId);
}
catch (SdkException<DeleteVodGenreError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVodGenreError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>genreId</code> | <code>string</code> | The ID of the genre. |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVodGenreError](Errors/DeleteVodGenreError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPage&gt; GetGenreVod(string genreId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single On Demand page that belongs to the specified genre.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandGenres.GetGenreVod(genreId, ondemandId);
    // TODO: Handle 'response' of type OnDemandPage
}
catch (SdkException<GetGenreVodError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetGenreVodError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>genreId</code> | <code>string</code> | The ID of the genre. |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPage](Models/OnDemandPage.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGenreVodError](Errors/GetGenreVodError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPageConnection&gt; GetGenreVods(string genreId, Direction? direction, Filter24? filter, double? page, double? perPage, string? query, Sort41? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every On Demand page that belongs to the specified genre.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandGenres.GetGenreVods(genreId, direction, filter, page, perPage, query, sort);
    // TODO: Handle 'response' of type OnDemandPageConnection
}
catch (SdkException<GetGenreVodsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetGenreVodsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>genreId</code> | <code>string</code> | The ID of the genre. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter24?](Models/Enums/Filter24.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `country` - Sort the results by country.<br> * `my_region` - Sort the results by user's region. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort41?](Models/Enums/Sort41.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `name` - Sort the results by name.<br> * `publish.time` - Sort the results by time of publishing.<br> * `videos` - Sort the results by video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPageConnection](Models/OnDemandPageConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetGenreVodsError](Errors/GetGenreVodsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandGenre&gt; GetVodGenre(string genreId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single On Demand genre.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandGenres.GetVodGenre(genreId);
    // TODO: Handle 'response' of type OnDemandGenre
}
catch (SdkException<GetVodGenreError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodGenreError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>genreId</code> | <code>string</code> | The ID of the genre. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandGenre](Models/OnDemandGenre.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodGenreError](Errors/GetVodGenreError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandGenre&gt; GetVodGenreByOndemandId(string genreId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether an On Demand page is associated with the specified genre.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandGenres.GetVodGenreByOndemandId(genreId, ondemandId);
    // TODO: Handle 'response' of type OnDemandGenre
}
catch (SdkException<GetVodGenreByOndemandIdError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodGenreByOndemandIdError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>genreId</code> | <code>string</code> | The ID of the genre. |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandGenre](Models/OnDemandGenre.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodGenreByOndemandIdError](Errors/GetVodGenreByOndemandIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandGenreConnection&gt; GetVodGenres(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every existing On Demand genre.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandGenres.GetVodGenres();
    // TODO: Handle 'response' of type OnDemandGenreConnection
}
catch (SdkException<GetVodGenresError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodGenresError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandGenreConnection](Models/OnDemandGenreConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodGenresError](Errors/GetVodGenresError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandGenreConnection&gt; GetVodGenresByOndemandId(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every genre associated with the specified On Demand page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandGenres.GetVodGenresByOndemandId(ondemandId);
    // TODO: Handle 'response' of type OnDemandGenreConnection
}
catch (SdkException<GetVodGenresByOndemandIdError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodGenresByOndemandIdError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandGenreConnection](Models/OnDemandGenreConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodGenresByOndemandIdError](Errors/GetVodGenresByOndemandIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OnDemandPosters

> Source: [OnDemandPosters](Api/OnDemandPosters.cs)

<details>
<summary><code>Task&lt;Picture&gt; AddVodPoster(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a poster image to the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandPosters.AddVodPoster(ondemandId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<AddVodPosterError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVodPosterError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVodPosterError](Errors/AddVodPosterError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; EditVodPoster(double ondemandId, double posterId, OndemandPagesPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits a poster image on the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandPosters.EditVodPoster(ondemandId, posterId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>posterId</code> | <code>double</code> | The ID of the poster. |
| <code>body</code> | <code>[OndemandPagesPicturesRequest?](Models/OndemandPagesPicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetVodPoster(double ondemandId, double posterId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single poster on the specified On Demand page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandPosters.GetVodPoster(ondemandId, posterId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>posterId</code> | <code>double</code> | The ID of the poster. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetVodPosters(double ondemandId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every poster on the specified On Demand page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandPosters.GetVodPosters(ondemandId, page, perPage);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<GetVodPostersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodPostersError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodPostersError](Errors/GetVodPostersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OnDemandPromotions

> Source: [OnDemandPromotions](Api/OnDemandPromotions.cs)

<details>
<summary><code>Task&lt;OnDemandPromotion&gt; CreateVodPromotion(double ondemandId, OndemandPagesPromotionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a promotion to the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandPromotions.CreateVodPromotion(ondemandId, body);
    // TODO: Handle 'response' of type OnDemandPromotion
}
catch (SdkException<CreateVodPromotionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateVodPromotionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>body</code> | <code>[OndemandPagesPromotionsRequest](Models/OndemandPagesPromotionsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPromotion](Models/OnDemandPromotion.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateVodPromotionError](Errors/CreateVodPromotionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVodPromotion(double ondemandId, double promotionId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes a promotion on the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.OnDemandPromotions.DeleteVodPromotion(ondemandId, promotionId);
}
catch (SdkException<DeleteVodPromotionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVodPromotionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>promotionId</code> | <code>double</code> | The ID of the promotion. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVodPromotionError](Errors/DeleteVodPromotionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPromotion&gt; GetVodPromotion(double ondemandId, double promotionId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single promotion on the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandPromotions.GetVodPromotion(ondemandId, promotionId);
    // TODO: Handle 'response' of type OnDemandPromotion
}
catch (SdkException<GetVodPromotionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodPromotionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>promotionId</code> | <code>double</code> | The ID of the promotion. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPromotion](Models/OnDemandPromotion.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodPromotionError](Errors/GetVodPromotionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPromotionCode&gt; GetVodPromotionCodes(double ondemandId, double promotionId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every code of the specified promotion on an On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandPromotions.GetVodPromotionCodes(ondemandId, promotionId, page, perPage);
    // TODO: Handle 'response' of type OnDemandPromotionCode
}
catch (SdkException<GetVodPromotionCodesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodPromotionCodesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>promotionId</code> | <code>double</code> | The ID of the promotion. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPromotionCode](Models/OnDemandPromotionCode.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodPromotionCodesError](Errors/GetVodPromotionCodesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPromotion&gt; GetVodPromotions(double ondemandId, Filter26 filter, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every promotion on the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandPromotions.GetVodPromotions(ondemandId, filter, page, perPage);
    // TODO: Handle 'response' of type OnDemandPromotion
}
catch (SdkException<GetVodPromotionsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodPromotionsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>filter</code> | <code>[Filter26](Models/Enums/Filter26.cs)</code> | The type of filter to apply to the results.<br><br>Option descriptions:<br> * `batch` - Filter the results by the `batch` promotion.<br> * `default` - Filter the results by the default promotion.<br> * `single` - Filter the results by the `single` promotion.<br> * `vip` - Filter the results by the `vip` promotion. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPromotion](Models/OnDemandPromotion.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodPromotionsError](Errors/GetVodPromotionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OnDemandPurchasesAndRentals

> Source: [OnDemandPurchasesAndRentals](Api/OnDemandPurchasesAndRentals.cs)

<details>
<summary><code>Task&lt;OnDemandPage&gt; CheckIfVodWasPurchasedAlt1(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the authenticated user has made a purchase or rental from the specified On Demand page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandPurchasesAndRentals.CheckIfVodWasPurchasedAlt1(ondemandId);
    // TODO: Handle 'response' of type OnDemandPage
}
catch (SdkException<CheckIfVodWasPurchasedAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfVodWasPurchasedAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPage](Models/OnDemandPage.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfVodWasPurchasedAlt1Error](Errors/CheckIfVodWasPurchasedAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPageConnection&gt; GetVodPurchases(double userId, Direction? direction, Filter19? filter, double? page, double? perPage, Sort33? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every purchase and rental that the authenticated user has made across all On Demand pages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandPurchasesAndRentals.GetVodPurchases(userId,
        direction,
        filter,
        page,
        perPage,
        sort);
    // TODO: Handle 'response' of type OnDemandPageConnection
}
catch (SdkException<GetVodPurchasesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodPurchasesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter19?](Models/Enums/Filter19.cs)</code> | The type of the On Demand video to filter on.<br><br>Option descriptions:<br> * `all` - Filter by all video types.<br> * `expiring_soon` - Filter by videos that expire soon.<br> * `film` - Filter by film.<br> * `important` - Filter by pages that are about to expire.<br> * `purchased` - Filter by purchased videos.<br> * `rented` - Filter by rented videos.<br> * `series` - Filter by series.<br> * `subscription` - Filter by video subscription.<br> * `unwatched` - Filter by unwatched videos.<br> * `watched` - Filter by watched videos. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort33?](Models/Enums/Sort33.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `added` - Sort the results by most recently added video.<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `name` - Sort the results by video name.<br> * `purchase_time` - Sort the results by time of video purchase.<br> * `rating` - Sort the results by content rating.<br> * `release_date` - Sort the results by video release date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPageConnection](Models/OnDemandPageConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodPurchasesError](Errors/GetVodPurchasesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandPageConnection&gt; GetVodPurchasesAlt1(Direction? direction, Filter19? filter, double? page, double? perPage, Sort33? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every purchase and rental that the authenticated user has made across all On Demand pages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandPurchasesAndRentals.GetVodPurchasesAlt1(direction, filter, page, perPage, sort);
    // TODO: Handle 'response' of type OnDemandPageConnection
}
catch (SdkException<GetVodPurchasesAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodPurchasesAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter19?](Models/Enums/Filter19.cs)</code> | The type of the On Demand video to filter on.<br><br>Option descriptions:<br> * `all` - Filter by all video types.<br> * `expiring_soon` - Filter by videos that expire soon.<br> * `film` - Filter by film.<br> * `important` - Filter by pages that are about to expire.<br> * `purchased` - Filter by purchased videos.<br> * `rented` - Filter by rented videos.<br> * `series` - Filter by series.<br> * `subscription` - Filter by video subscription.<br> * `unwatched` - Filter by unwatched videos.<br> * `watched` - Filter by watched videos. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort33?](Models/Enums/Sort33.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `added` - Sort the results by most recently added video.<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date.<br> * `name` - Sort the results by video name.<br> * `purchase_time` - Sort the results by time of video purchase.<br> * `rating` - Sort the results by content rating.<br> * `release_date` - Sort the results by video release date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandPageConnection](Models/OnDemandPageConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodPurchasesAlt1Error](Errors/GetVodPurchasesAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OnDemandRegions

> Source: [OnDemandRegions](Api/OnDemandRegions.cs)

<details>
<summary><code>Task&lt;OnDemandRegion&gt; AddVodRegion(string country, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a single region to the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandRegions.AddVodRegion(country, ondemandId);
    // TODO: Handle 'response' of type OnDemandRegion
}
catch (SdkException<AddVodRegionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVodRegionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>country</code> | <code>string</code> | The country code of the region to add. |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandRegion](Models/OnDemandRegion.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVodRegionError](Errors/AddVodRegionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVodRegion(string country, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a single region from the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.OnDemandRegions.DeleteVodRegion(country, ondemandId);
}
catch (SdkException<DeleteVodRegionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVodRegionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>country</code> | <code>string</code> | The country code of the region to remove. |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVodRegionError](Errors/DeleteVodRegionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;OnDemandRegion&gt;&gt; DeleteVodRegions(double ondemandId, OndemandPagesRegionsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes multiple regions from the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandRegions.DeleteVodRegions(ondemandId, body);
    // TODO: Handle 'response' of type IReadOnlyList<OnDemandRegion>
}
catch (SdkException<DeleteVodRegionsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVodRegionsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>body</code> | <code>[OndemandPagesRegionsRequest?](Models/OndemandPagesRegionsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[OnDemandRegion](Models/OnDemandRegion.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVodRegionsError](Errors/DeleteVodRegionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandRegion&gt; GetRegion(string country, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single On Demand region.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandRegions.GetRegion(country);
    // TODO: Handle 'response' of type OnDemandRegion
}
catch (SdkException<GetRegionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetRegionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>country</code> | <code>string</code> | The country code of the region to return. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandRegion](Models/OnDemandRegion.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetRegionError](Errors/GetRegionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandRegionConnection&gt; GetRegions(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every existing On Demand region.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandRegions.GetRegions();
    // TODO: Handle 'response' of type OnDemandRegionConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandRegionConnection](Models/OnDemandRegionConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandRegion&gt; GetVodRegion(string country, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single region on the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandRegions.GetVodRegion(country, ondemandId);
    // TODO: Handle 'response' of type OnDemandRegion
}
catch (SdkException<GetVodRegionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodRegionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>country</code> | <code>string</code> | The country code of the region to return. |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandRegion](Models/OnDemandRegion.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodRegionError](Errors/GetVodRegionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandRegionConnection&gt; GetVodRegions(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every region on the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandRegions.GetVodRegions(ondemandId);
    // TODO: Handle 'response' of type OnDemandRegionConnection
}
catch (SdkException<GetVodRegionsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodRegionsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandRegionConnection](Models/OnDemandRegionConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodRegionsError](Errors/GetVodRegionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandRegion&gt; SetVodRegions(double ondemandId, OndemandPagesRegionsRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds multiple regions to the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandRegions.SetVodRegions(ondemandId, body);
    // TODO: Handle 'response' of type OnDemandRegion
}
catch (SdkException<SetVodRegionsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SetVodRegionsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>body</code> | <code>[OndemandPagesRegionsRequest1](Models/OndemandPagesRegionsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandRegion](Models/OnDemandRegion.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetVodRegionsError](Errors/SetVodRegionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OnDemandSeasons

> Source: [OnDemandSeasons](Api/OnDemandSeasons.cs)

<details>
<summary><code>Task&lt;OnDemandSeason&gt; GetVodSeason(double ondemandId, double seasonId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single season on the specified On Demand page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandSeasons.GetVodSeason(ondemandId, seasonId);
    // TODO: Handle 'response' of type OnDemandSeason
}
catch (SdkException<GetVodSeasonError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodSeasonError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>seasonId</code> | <code>double</code> | The ID of the season. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandSeason](Models/OnDemandSeason.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodSeasonError](Errors/GetVodSeasonError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetVodSeasonVideos(double ondemandId, double seasonId, Filter27? filter, double? page, double? perPage, Sort44? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video in the specified season on an On Demand page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandSeasons.GetVodSeasonVideos(ondemandId, seasonId, filter, page, perPage, sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>seasonId</code> | <code>double</code> | The ID of the season. |
| <code>filter</code> | <code>[Filter27?](Models/Enums/Filter27.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `viewable` - Filter by viewable videos. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort44?](Models/Enums/Sort44.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `date` - Sort the results by date.<br> * `default` - Use the default sorting method.<br> * `manual` - Sort the results manually.<br> * `name` - Sort the results by name.<br> * `purchase_time` - Sort the results by time of purchase.<br> * `release_date` - Sort the results by release date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandSeasonConnection&gt; GetVodSeasons(double ondemandId, Direction? direction, Filter27? filter, double? page, double? perPage, Sort43? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every season on the specified On Demand page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandSeasons.GetVodSeasons(ondemandId, direction, filter, page, perPage, sort);
    // TODO: Handle 'response' of type OnDemandSeasonConnection
}
catch (SdkException<GetVodSeasonsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVodSeasonsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter27?](Models/Enums/Filter27.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `viewable` - Filter by viewable seasons. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort43?](Models/Enums/Sort43.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `date` - Sort the results by date.<br> * `manual` - Sort the results manually. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandSeasonConnection](Models/OnDemandSeasonConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVodSeasonsError](Errors/GetVodSeasonsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OnDemandVideos

> Source: [OnDemandVideos](Api/OnDemandVideos.cs)

<details>
<summary><code>Task&lt;OnDemandVideo&gt; AddVideoToVod(double ondemandId, double videoId, OndemandPagesVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a video to the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandVideos.AddVideoToVod(ondemandId, videoId, body);
    // TODO: Handle 'response' of type OnDemandVideo
}
catch (SdkException<AddVideoToVodError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoToVodError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[OndemandPagesVideosRequest](Models/OndemandPagesVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandVideo](Models/OnDemandVideo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoToVodError](Errors/AddVideoToVodError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoFromVod(double ondemandId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a video from the specified On Demand page. The authenticated user must be the owner of the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.OnDemandVideos.DeleteVideoFromVod(ondemandId, videoId);
}
catch (SdkException<DeleteVideoFromVodError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoFromVodError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoFromVodError](Errors/DeleteVideoFromVodError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; GetVodVideo(double ondemandId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video on the specified On Demand page. Use this method to determine whether the video is on the page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandVideos.GetVodVideo(ondemandId, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnDemandVideoConnection&gt; GetVodVideos(double ondemandId, Direction? direction, Filter29? filter, double? page, double? perPage, Sort45? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video on the specified On Demand page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OnDemandVideos.GetVodVideos(ondemandId, direction, filter, page, perPage, sort);
    // TODO: Handle 'response' of type OnDemandVideoConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>ondemandId</code> | <code>double</code> | The ID of the On Demand page. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter29?](Models/Enums/Filter29.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `all` - Filter for all videos.<br> * `buy` - Filter for purchased videos.<br> * `expiring_soon` - Filter for videos that expire soon.<br> * `extra` - Filter for extra footage videos.<br> * `main` - Filter for main videos.<br> * `main.viewable` - Filter for videos that are both the main video and are viewable.<br> * `rent` - Filter for rented videos.<br> * `trailer` - Filter for trailer videos.<br> * `unwatched` - Filter for unwatched videos.<br> * `viewable` - Filter for videos that are viewable.<br> * `watched` - Filter for watched videos. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort45?](Models/Enums/Sort45.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `date` - Sort the results by date.<br> * `default` - Use the default sorting method.<br> * `episode` - Sort the results by episode.<br> * `manual` - Sort the results manually.<br> * `name` - Sort the results by name.<br> * `purchase_time` - Sort the results by time of purchase.<br> * `release_date` - Sort the results by release date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnDemandVideoConnection](Models/OnDemandVideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentsEssentials

> Source: [PaymentsEssentials](Api/PaymentsEssentials.cs)

<details>
<summary><code>Task DeletePaymentMethod(string paymentMethodId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified Vimeo payments service payment method.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PaymentsEssentials.DeletePaymentMethod(paymentMethodId);
}
catch (SdkException<DeletePaymentMethodError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeletePaymentMethodError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentMethodId</code> | <code>string</code> | The ID of the payment method. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeletePaymentMethodError](Errors/DeletePaymentMethodError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentMethod&gt; GetPaymentMethodInfo(string paymentMethodId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns information about the specified Vimeo payments service payment method.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsEssentials.GetPaymentMethodInfo(paymentMethodId);
    // TODO: Handle 'response' of type PaymentMethod
}
catch (SdkException<GetPaymentMethodInfoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetPaymentMethodInfoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentMethodId</code> | <code>string</code> | The ID of the payment method. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentMethod](Models/PaymentMethod.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentMethodInfoError](Errors/GetPaymentMethodInfoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetSubscriptionInfo(string subscriptionId, string userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns information about the specified Vimeo payments service subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PaymentsEssentials.GetSubscriptionInfo(subscriptionId, userId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>subscriptionId</code> | <code>string</code> | The ID of the subscription. |
| <code>userId</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentMethodConnection&gt; ListPaymentMethods(string? cardmemberName, double? page, double? perPage, bool? showDisabled, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a list of all Vimeo payments service payment methods that are available to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentsEssentials.ListPaymentMethods(cardmemberName, page, perPage, showDisabled);
    // TODO: Handle 'response' of type PaymentMethodConnection
}
catch (SdkException<ListPaymentMethodsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ListPaymentMethodsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cardmemberName</code> | <code>string?</code> | The name of the card member. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>showDisabled</code> | <code>bool?</code> | Whether to return disabled payment methods. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentMethodConnection](Models/PaymentMethodConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ListPaymentMethodsError](Errors/ListPaymentMethodsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PortfoliosEssentials

> Source: [PortfoliosEssentials](Api/PortfoliosEssentials.cs)

<details>
<summary><code>Task&lt;Portfolio&gt; GetPortfolio(double portfolioId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfoliosEssentials.GetPortfolio(portfolioId, userId);
    // TODO: Handle 'response' of type Portfolio
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portfolioId</code> | <code>double</code> | The ID of the portfolio. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Portfolio](Models/Portfolio.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Portfolio&gt; GetPortfolioAlt1(double portfolioId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfoliosEssentials.GetPortfolioAlt1(portfolioId);
    // TODO: Handle 'response' of type Portfolio
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portfolioId</code> | <code>double</code> | The ID of the portfolio. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Portfolio](Models/Portfolio.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PortfolioConnection&gt; GetPortfolios(double userId, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfoliosEssentials.GetPortfolios(userId, direction, page, perPage, query, sort);
    // TODO: Handle 'response' of type PortfolioConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PortfolioConnection](Models/PortfolioConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PortfolioConnection&gt; GetPortfoliosAlt1(Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfoliosEssentials.GetPortfoliosAlt1(direction, page, perPage, query, sort);
    // TODO: Handle 'response' of type PortfolioConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PortfolioConnection](Models/PortfolioConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PortfoliosVideos

> Source: [PortfoliosVideos](Api/PortfoliosVideos.cs)

<details>
<summary><code>Task AddVideoToPortfolio(double portfolioId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a video to the specified portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PortfoliosVideos.AddVideoToPortfolio(portfolioId, userId, videoId);
}
catch (SdkException<AddVideoToPortfolioError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoToPortfolioError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portfolioId</code> | <code>double</code> | The ID of the portfolio. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoToPortfolioError](Errors/AddVideoToPortfolioError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AddVideoToPortfolioAlt1(double portfolioId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a video to the specified portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PortfoliosVideos.AddVideoToPortfolioAlt1(portfolioId, videoId);
}
catch (SdkException<AddVideoToPortfolioAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoToPortfolioAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portfolioId</code> | <code>double</code> | The ID of the portfolio. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoToPortfolioAlt1Error](Errors/AddVideoToPortfolioAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoFromPortfolio(double portfolioId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a video from the specified portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PortfoliosVideos.DeleteVideoFromPortfolio(portfolioId, userId, videoId);
}
catch (SdkException<DeleteVideoFromPortfolioError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoFromPortfolioError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portfolioId</code> | <code>double</code> | The ID of the portfolio. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoFromPortfolioError](Errors/DeleteVideoFromPortfolioError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoFromPortfolioAlt1(double portfolioId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes a video from the specified portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PortfoliosVideos.DeleteVideoFromPortfolioAlt1(portfolioId, videoId);
}
catch (SdkException<DeleteVideoFromPortfolioAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoFromPortfolioAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portfolioId</code> | <code>double</code> | The ID of the portfolio. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoFromPortfolioAlt1Error](Errors/DeleteVideoFromPortfolioAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; GetPortfolioVideo(double portfolioId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video from the specified portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfoliosVideos.GetPortfolioVideo(portfolioId, userId, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portfolioId</code> | <code>double</code> | The ID of the portfolio. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; GetPortfolioVideoAlt1(double portfolioId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video from the specified portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfoliosVideos.GetPortfolioVideoAlt1(portfolioId, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portfolioId</code> | <code>double</code> | The ID of the portfolio. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetPortfolioVideos(double portfolioId, double userId, string? containingUri, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, Sort35? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video from the specified portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfoliosVideos.GetPortfolioVideos(portfolioId,
        userId,
        containingUri,
        filter,
        filterEmbeddable,
        page,
        perPage,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portfolioId</code> | <code>double</code> | The ID of the portfolio. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>containingUri</code> | <code>string?</code> | The page that contains the video URI. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort35?](Models/Enums/Sort35.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by creation date.<br> * `default` - Use the default sorting method.<br> * `likes` - Sort the results by number of likes.<br> * `manual` - Sort the results by their user-specified order.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetPortfolioVideosAlt1(double portfolioId, string? containingUri, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, Sort35? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video from the specified portfolio belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfoliosVideos.GetPortfolioVideosAlt1(portfolioId,
        containingUri,
        filter,
        filterEmbeddable,
        page,
        perPage,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portfolioId</code> | <code>double</code> | The ID of the portfolio. |
| <code>containingUri</code> | <code>string?</code> | The page that contains the video URI. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort35?](Models/Enums/Sort35.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by creation date.<br> * `default` - Use the default sorting method.<br> * `likes` - Sort the results by number of likes.<br> * `manual` - Sort the results by their user-specified order.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SearchFederated

> Source: [SearchFederated](Api/SearchFederated.cs)

<details>
<summary><code>Task&lt;FederatedSearchItemsConnection&gt; FederatedSearchUserItems(double userId, Direction? direction, Filter30? filter, string? filterPrivacy, string? modifiedEndDate, string? modifiedStartDate, double? page, double? perPage, string? query, string? queryFields, Sort46? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the federated search results of the authenticated user's videos and folders according to a search query.

If no query is provided, the method returns items sorted by the most recent user action.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SearchFederated.FederatedSearchUserItems(userId,
        direction,
        filter,
        filterPrivacy,
        modifiedEndDate,
        modifiedStartDate,
        page,
        perPage,
        query,
        queryFields,
        sort);
    // TODO: Handle 'response' of type FederatedSearchItemsConnection
}
catch (SdkException<FederatedSearchUserItemsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type FederatedSearchUserItemsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter30?](Models/Enums/Filter30.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `video` - Return videos. |
| <code>filterPrivacy</code> | <code>string?</code> | A comma-separated list of privacy settings to filter the results by. Possible values include `unlisted` for videos that are accessible but not searchable from Vimeo, `password` for videos on Vimeo that anyone can access with the correct password, `hide-from-vimeo` for videos that don't appear on Vimeo, `private` for videos on Vimeo that only their owner can access, and `public` for videos on Vimeo that anyone can access. By default, all privacy settings are considered. |
| <code>modifiedEndDate</code> | <code>string?</code> | The inclusive end date of the range. |
| <code>modifiedStartDate</code> | <code>string?</code> | The inclusive start date of the range. This value must be earlier than the modified end date. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>queryFields</code> | <code>string?</code> | A comma-separated list of fields to query over. The default value is `title,description,chapters,tags`. |
| <code>sort</code> | <code>[Sort46?](Models/Enums/Sort46.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date.<br> * `default` - Use the default sorting order.<br> * `duration` - Sort the results by duration, where available.<br> * `folder_path` - Sort the results by the hierarchy of folders.<br> * `last_user_action_event_date` - Sort the results by most recent user interaction. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FederatedSearchItemsConnection](Models/FederatedSearchItemsConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FederatedSearchUserItemsError](Errors/FederatedSearchUserItemsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FederatedSearchItemsConnection&gt; FederatedSearchUserItemsAlt1(string workspaceUuid, Direction? direction, Filter30? filter, string? filterPrivacy, string? modifiedEndDate, string? modifiedStartDate, double? page, double? perPage, string? query, string? queryFields, Sort46? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the federated search results of the authenticated user's videos and folders according to a search query.

If no query is provided, the method returns items sorted by the most recent user action.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SearchFederated.FederatedSearchUserItemsAlt1(workspaceUuid,
        direction,
        filter,
        filterPrivacy,
        modifiedEndDate,
        modifiedStartDate,
        page,
        perPage,
        query,
        queryFields,
        sort);
    // TODO: Handle 'response' of type FederatedSearchItemsConnection
}
catch (SdkException<FederatedSearchUserItemsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type FederatedSearchUserItemsAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>workspaceUuid</code> | <code>string</code> | The UUID of the workspace. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter30?](Models/Enums/Filter30.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `video` - Return videos. |
| <code>filterPrivacy</code> | <code>string?</code> | A comma-separated list of privacy settings to filter the results by. Possible values include `unlisted` for videos that are accessible but not searchable from Vimeo, `password` for videos on Vimeo that anyone can access with the correct password, `hide-from-vimeo` for videos that don't appear on Vimeo, `private` for videos on Vimeo that only their owner can access, and `public` for videos on Vimeo that anyone can access. By default, all privacy settings are considered. |
| <code>modifiedEndDate</code> | <code>string?</code> | The inclusive end date of the range. |
| <code>modifiedStartDate</code> | <code>string?</code> | The inclusive start date of the range. This value must be earlier than the modified end date. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>queryFields</code> | <code>string?</code> | A comma-separated list of fields to query over. The default value is `title,description,chapters,tags`. |
| <code>sort</code> | <code>[Sort46?](Models/Enums/Sort46.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date.<br> * `default` - Use the default sorting order.<br> * `duration` - Sort the results by duration, where available.<br> * `folder_path` - Sort the results by the hierarchy of folders.<br> * `last_user_action_event_date` - Sort the results by most recent user interaction. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FederatedSearchItemsConnection](Models/FederatedSearchItemsConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FederatedSearchUserItemsAlt1Error](Errors/FederatedSearchUserItemsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ShowcasesCustomShowcaseLogos

> Source: [ShowcasesCustomShowcaseLogos](Api/ShowcasesCustomShowcaseLogos.cs)

<details>
<summary><code>Task&lt;Picture&gt; CreateShowcaseLogo(double albumId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds an image file as a custom logo to the specified showcase. The authenticated user must be the owner of the showcase.

For information on how to upload the logo, see our [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails) guide.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesCustomShowcaseLogos.CreateShowcaseLogo(albumId, userId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<CreateShowcaseLogoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateShowcaseLogoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateShowcaseLogoError](Errors/CreateShowcaseLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteShowcaseLogo(double albumId, double logoId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified custom logo from its showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesCustomShowcaseLogos.DeleteShowcaseLogo(albumId, logoId, userId);
}
catch (SdkException<DeleteShowcaseLogoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteShowcaseLogoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>logoId</code> | <code>double</code> | The ID of the custom logo. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteShowcaseLogoError](Errors/DeleteShowcaseLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetShowcaseLogo(double albumId, double logoId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single custom logo of the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesCustomShowcaseLogos.GetShowcaseLogo(albumId, logoId, userId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetShowcaseLogoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcaseLogoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>logoId</code> | <code>double</code> | The ID of the custom logo. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcaseLogoError](Errors/GetShowcaseLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetShowcaseLogos(double albumId, double userId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every custom logo of the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesCustomShowcaseLogos.GetShowcaseLogos(albumId, userId, page, perPage);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<GetShowcaseLogosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcaseLogosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcaseLogosError](Errors/GetShowcaseLogosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; ReplaceShowcaseLogo(double albumId, double logoId, double userId, UsersAlbumsLogosLogoIdRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method replaces the specified custom showcase logo with a new image file. The authenticated user must be the owner of the showcase.

For information on how to upload the logo, see our [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails) guide.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesCustomShowcaseLogos.ReplaceShowcaseLogo(albumId, logoId, userId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<ReplaceShowcaseLogoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ReplaceShowcaseLogoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>logoId</code> | <code>double</code> | The ID of the custom logo. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersAlbumsLogosLogoIdRequest?](Models/UsersAlbumsLogosLogoIdRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ReplaceShowcaseLogoError](Errors/ReplaceShowcaseLogoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ShowcasesCustomShowcaseThumbnails

> Source: [ShowcasesCustomShowcaseThumbnails](Api/ShowcasesCustomShowcaseThumbnails.cs)

<details>
<summary><code>Task&lt;Picture&gt; CreateShowcaseCustomThumb(double albumId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds an uploaded image file as a custom thumbnail for the specified showcase. The image doesn't need to be a still from a showcase video, unlike with the [standard thumbnail method](https://developer.vimeo.com/api/reference/showcases#set_video_as_showcase_thumbnail). The authenticated user must be the owner of the showcase.

For information on how to upload the thumbnail, see our [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails) guide, and follow the same steps.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesCustomShowcaseThumbnails.CreateShowcaseCustomThumb(albumId, userId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<CreateShowcaseCustomThumbError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateShowcaseCustomThumbError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateShowcaseCustomThumbError](Errors/CreateShowcaseCustomThumbError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteShowcaseCustomThumbnail(double albumId, double thumbnailId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified custom thumbnail from its showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesCustomShowcaseThumbnails.DeleteShowcaseCustomThumbnail(albumId, thumbnailId, userId);
}
catch (SdkException<DeleteShowcaseCustomThumbnailError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteShowcaseCustomThumbnailError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the custom thumbnail. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteShowcaseCustomThumbnailError](Errors/DeleteShowcaseCustomThumbnailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetShowcaseCustomThumbnail(double albumId, double thumbnailId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single custom thumbnail of the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesCustomShowcaseThumbnails.GetShowcaseCustomThumbnail(albumId,
        thumbnailId,
        userId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetShowcaseCustomThumbnailError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcaseCustomThumbnailError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the custom thumbnail. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcaseCustomThumbnailError](Errors/GetShowcaseCustomThumbnailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetShowcaseCustomThumbs(double albumId, double userId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every custom thumbnail of the specified showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesCustomShowcaseThumbnails.GetShowcaseCustomThumbs(albumId,
        userId,
        page,
        perPage);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<GetShowcaseCustomThumbsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcaseCustomThumbsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcaseCustomThumbsError](Errors/GetShowcaseCustomThumbsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; ReplaceShowcaseCustomThumb(double albumId, double thumbnailId, double userId, UsersAlbumsCustomThumbnailsThumbnailIdRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method replaces the specified custom showcase thumbnail with a new image file. The authenticated user must be the owner of the showcase.

For information on how to upload the thumbnail, see our [Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails) guide.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesCustomShowcaseThumbnails.ReplaceShowcaseCustomThumb(albumId,
        thumbnailId,
        userId,
        body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<ReplaceShowcaseCustomThumbError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ReplaceShowcaseCustomThumbError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>thumbnailId</code> | <code>double</code> | The ID of the custom thumbnail. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersAlbumsCustomThumbnailsThumbnailIdRequest?](Models/UsersAlbumsCustomThumbnailsThumbnailIdRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ReplaceShowcaseCustomThumbError](Errors/ReplaceShowcaseCustomThumbError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ShowcasesEssentials

> Source: [ShowcasesEssentials](Api/ShowcasesEssentials.cs)

<details>
<summary><code>Task AddFolderToShowcases(double userId, string albumUris, double folderId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds all videos and events from a specified folder to showcases.

The authenticated user must either be the owner of the showcase or have team permissions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesEssentials.AddFolderToShowcases(userId, albumUris, folderId);
}
catch (SdkException<AddFolderToShowcasesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddFolderToShowcasesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>albumUris</code> | <code>string</code> | A comma-separated list of showcase URIs. |
| <code>folderId</code> | <code>double</code> | The ID of the folder containing videos and events to add. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddFolderToShowcasesError](Errors/AddFolderToShowcasesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; CopyShowcase(double albumId, double userId, UsersAlbumsCopyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a copy of the specified showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesEssentials.CopyShowcase(albumId, userId, body);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<CopyShowcaseError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CopyShowcaseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersAlbumsCopyRequest?](Models/UsersAlbumsCopyRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CopyShowcaseError](Errors/CopyShowcaseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; CopyShowcaseAlt2(double albumId, MeAlbumsCopyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a copy of the specified showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesEssentials.CopyShowcaseAlt2(albumId, body);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<CopyShowcaseAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CopyShowcaseAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>body</code> | <code>[MeAlbumsCopyRequest?](Models/MeAlbumsCopyRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CopyShowcaseAlt2Error](Errors/CopyShowcaseAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; CreateShowcase(double userId, UsersAlbumsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new showcase for the specified user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesEssentials.CreateShowcase(userId, body);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<CreateShowcaseError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateShowcaseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersAlbumsRequest](Models/UsersAlbumsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateShowcaseError](Errors/CreateShowcaseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; CreateShowcaseAlt1(MeAlbumsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new showcase for the specified user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesEssentials.CreateShowcaseAlt1(body);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<CreateShowcaseAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateShowcaseAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[MeAlbumsRequest](Models/MeAlbumsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateShowcaseAlt1Error](Errors/CreateShowcaseAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteShowcase(double albumId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesEssentials.DeleteShowcase(albumId, userId);
}
catch (SdkException<DeleteShowcaseError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteShowcaseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteShowcaseError](Errors/DeleteShowcaseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteShowcaseAlt2(double albumId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesEssentials.DeleteShowcaseAlt2(albumId);
}
catch (SdkException<DeleteShowcaseAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteShowcaseAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteShowcaseAlt2Error](Errors/DeleteShowcaseAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; EditShowcase(double albumId, double userId, UsersAlbumsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesEssentials.EditShowcase(albumId, userId, body);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<EditShowcaseError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditShowcaseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersAlbumsRequest1?](Models/UsersAlbumsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditShowcaseError](Errors/EditShowcaseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; EditShowcaseAlt2(double albumId, MeAlbumsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesEssentials.EditShowcaseAlt2(albumId, body);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<EditShowcaseAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditShowcaseAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>body</code> | <code>[MeAlbumsRequest1?](Models/MeAlbumsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditShowcaseAlt2Error](Errors/EditShowcaseAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; GetShowcase(double albumId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesEssentials.GetShowcase(albumId, userId);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<GetShowcaseError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcaseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcaseError](Errors/GetShowcaseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; GetShowcaseAlt2(double albumId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesEssentials.GetShowcaseAlt2(albumId);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<GetShowcaseAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcaseAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcaseAlt2Error](Errors/GetShowcaseAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlbumConnection&gt; GetShowcases(double userId, Direction? direction, string? filterPrivacy, double? page, double? perPage, string? query, Sort18? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every showcase belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesEssentials.GetShowcases(userId,
        direction,
        filterPrivacy,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type AlbumConnection
}
catch (SdkException<GetShowcasesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcasesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filterPrivacy</code> | <code>string?</code> | A comma-separated list of showcase privacies to include. Valid options are `anybody` for universal access, `password` for password-restricted access, `embed_only` for restricted access on Vimeo but available as an embedded showcase elsewhere, `team` for team-only access, `nobody` for owner-only access, and `unlisted` for restricted access except for those with a direct link. By default, all privacies are returned. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort18?](Models/Enums/Sort18.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date of creation.<br> * `duration` - Sort the results by duration.<br> * `last_modified` - Sort the results by last modified date.<br> * `videos` - Sort the results by the number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlbumConnection](Models/AlbumConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcasesError](Errors/GetShowcasesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlbumConnection&gt; GetShowcasesAlt1(Direction? direction, string? filterPrivacy, double? page, double? perPage, string? query, Sort18? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every showcase belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesEssentials.GetShowcasesAlt1(direction,
        filterPrivacy,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type AlbumConnection
}
catch (SdkException<GetShowcasesAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcasesAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filterPrivacy</code> | <code>string?</code> | A comma-separated list of showcase privacies to include. Valid options are `anybody` for universal access, `password` for password-restricted access, `embed_only` for restricted access on Vimeo but available as an embedded showcase elsewhere, `team` for team-only access, `nobody` for owner-only access, and `unlisted` for restricted access except for those with a direct link. By default, all privacies are returned. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort18?](Models/Enums/Sort18.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date of creation.<br> * `duration` - Sort the results by duration.<br> * `last_modified` - Sort the results by last modified date.<br> * `videos` - Sort the results by the number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlbumConnection](Models/AlbumConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcasesAlt1Error](Errors/GetShowcasesAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateShowcases(double userId, string albumItemUris, string albumUris, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds videos and events to the specified showcases. The authenticated user must either be the owner of the showcase or have team permissions.

The present setup permits only one event per showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesEssentials.UpdateShowcases(userId, albumItemUris, albumUris);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>albumItemUris</code> | <code>string</code> | A comma-separated list of video or event URIs. |
| <code>albumUris</code> | <code>string</code> | A comma-separated list of showcase URIs. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ShowcasesShowcaseVideos

> Source: [ShowcasesShowcaseVideos](Api/ShowcasesShowcaseVideos.cs)

<details>
<summary><code>Task AddVideoToShowcase(double albumId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a single video to the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesShowcaseVideos.AddVideoToShowcase(albumId, userId, videoId);
}
catch (SdkException<AddVideoToShowcaseError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoToShowcaseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoToShowcaseError](Errors/AddVideoToShowcaseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AddVideoToShowcaseAlt2(double albumId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a single video to the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesShowcaseVideos.AddVideoToShowcaseAlt2(albumId, videoId);
}
catch (SdkException<AddVideoToShowcaseAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoToShowcaseAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoToShowcaseAlt2Error](Errors/AddVideoToShowcaseAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetAvailableShowcaseVideos(double albumId, Direction? direction, double? page, double? perPage, string? query, Sort2? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video belonging to the authenticated user that can be added to or removed from the specified showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesShowcaseVideos.GetAvailableShowcaseVideos(albumId,
        direction,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetAvailableShowcaseVideosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAvailableShowcaseVideosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort2?](Models/Enums/Sort2.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by date.<br> * `default` - Sort the results by the default method.<br> * `duration` - Sort the results by duration.<br> * `last_user_action_event_date` - Sort the results by most recent user interaction.<br> * `likes` - Sort the results by number of likes.<br> * `modified_time` - Sort the results by last modification.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAvailableShowcaseVideosError](Errors/GetAvailableShowcaseVideosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlbumConnection&gt; GetAvailableVideoShowcases(double videoId, Direction? direction, double? page, double? perPage, string? query, Sort74? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every showcase to which the authenticated user can add or remove the specified video. The user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesShowcaseVideos.GetAvailableVideoShowcases(videoId,
        direction,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type AlbumConnection
}
catch (SdkException<GetAvailableVideoShowcasesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAvailableVideoShowcasesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort74?](Models/Enums/Sort74.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date.<br> * `duration` - Sort the results by duration.<br> * `videos` - Sort the results by number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlbumConnection](Models/AlbumConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAvailableVideoShowcasesError](Errors/GetAvailableVideoShowcasesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; GetShowcaseVideo(double albumId, double userId, double videoId, string? password, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video belonging to the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesShowcaseVideos.GetShowcaseVideo(albumId, userId, videoId, password);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<GetShowcaseVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcaseVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>password</code> | <code>string?</code> | The password of the showcase. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcaseVideoError](Errors/GetShowcaseVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; GetShowcaseVideoAlt2(double albumId, double videoId, string? password, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video belonging to the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesShowcaseVideos.GetShowcaseVideoAlt2(albumId, videoId, password);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<GetShowcaseVideoAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcaseVideoAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>password</code> | <code>string?</code> | The password of the showcase. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcaseVideoAlt2Error](Errors/GetShowcaseVideoAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetShowcaseVideos(double albumId, double userId, string? containingUri, Direction? direction, Filter10? filter, bool? filterEmbeddable, double? page, string? password, double? perPage, string? query, Sort21? sort, bool? weakSearch, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video in the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesShowcaseVideos.GetShowcaseVideos(albumId,
        userId,
        containingUri,
        direction,
        filter,
        filterEmbeddable,
        page,
        password,
        perPage,
        query,
        sort,
        weakSearch);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetShowcaseVideosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcaseVideosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>containingUri</code> | <code>string?</code> | The page containing the video URI. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter10?](Models/Enums/Filter10.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Filter the results by the **embeddable** attribute.<br> * `playable` - Filter the results by the **playable** attribute. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>password</code> | <code>string?</code> | The password of the showcase. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort21?](Models/Enums/Sort21.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by date.<br> * `default` - Sort the results by the default method.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `manual` - Sort the results by their manual order.<br> * `modified_time` - Sort the results by last modification.<br> * `plays` - Sort the results by number of plays. |
| <code>weakSearch</code> | <code>bool?</code> | Whether to include private videos in the search. Please note that a separate search service provides this functionality. The service performs a partial text search on the video's name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcaseVideosError](Errors/GetShowcaseVideosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetShowcaseVideosAlt2(double albumId, string? containingUri, Direction? direction, Filter10? filter, bool? filterEmbeddable, double? page, string? password, double? perPage, string? query, Sort21? sort, bool? weakSearch, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video in the specified showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesShowcaseVideos.GetShowcaseVideosAlt2(albumId,
        containingUri,
        direction,
        filter,
        filterEmbeddable,
        page,
        password,
        perPage,
        query,
        sort,
        weakSearch);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetShowcaseVideosAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetShowcaseVideosAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>containingUri</code> | <code>string?</code> | The page containing the video URI. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter10?](Models/Enums/Filter10.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Filter the results by the **embeddable** attribute.<br> * `playable` - Filter the results by the **playable** attribute. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>password</code> | <code>string?</code> | The password of the showcase. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort21?](Models/Enums/Sort21.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by date.<br> * `default` - Sort the results by the default method.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `manual` - Sort the results by their manual order.<br> * `modified_time` - Sort the results by last modification.<br> * `plays` - Sort the results by number of plays. |
| <code>weakSearch</code> | <code>bool?</code> | Whether to include private videos in the search. Please note that a separate search service provides this functionality. The service performs a partial text search on the video's name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetShowcaseVideosAlt2Error](Errors/GetShowcaseVideosAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveVideoFromShowcase(double albumId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the specified video from its showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesShowcaseVideos.RemoveVideoFromShowcase(albumId, userId, videoId);
}
catch (SdkException<RemoveVideoFromShowcaseError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveVideoFromShowcaseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveVideoFromShowcaseError](Errors/RemoveVideoFromShowcaseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RemoveVideoFromShowcaseAlt2(double albumId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the specified video from its showcase. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesShowcaseVideos.RemoveVideoFromShowcaseAlt2(albumId, videoId);
}
catch (SdkException<RemoveVideoFromShowcaseAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type RemoveVideoFromShowcaseAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RemoveVideoFromShowcaseAlt2Error](Errors/RemoveVideoFromShowcaseAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task ReplaceVideosInShowcase(double albumId, double userId, UsersAlbumsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method replaces all the videos in the specified showcase with a new set of one or more videos. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesShowcaseVideos.ReplaceVideosInShowcase(albumId, userId, body);
}
catch (SdkException<ReplaceVideosInShowcaseError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ReplaceVideosInShowcaseError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersAlbumsVideosRequest](Models/UsersAlbumsVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ReplaceVideosInShowcaseError](Errors/ReplaceVideosInShowcaseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task ReplaceVideosInShowcaseAlt2(double albumId, MeAlbumsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method replaces all the videos in the specified showcase with a new set of one or more videos. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ShowcasesShowcaseVideos.ReplaceVideosInShowcaseAlt2(albumId, body);
}
catch (SdkException<ReplaceVideosInShowcaseAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ReplaceVideosInShowcaseAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>body</code> | <code>[MeAlbumsVideosRequest](Models/MeAlbumsVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ReplaceVideosInShowcaseAlt2Error](Errors/ReplaceVideosInShowcaseAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; SetVideoAsShowcaseFeatured(double albumId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method sets the featured video of the specified showcase. The authenticated user must be the owner of the showcase, and the featured video must belong to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesShowcaseVideos.SetVideoAsShowcaseFeatured(albumId, userId, videoId);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<SetVideoAsShowcaseFeaturedError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SetVideoAsShowcaseFeaturedError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetVideoAsShowcaseFeaturedError](Errors/SetVideoAsShowcaseFeaturedError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; SetVideoAsShowcaseFeaturedAlt2(double albumId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method sets the featured video of the specified showcase. The authenticated user must be the owner of the showcase, and the featured video must belong to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesShowcaseVideos.SetVideoAsShowcaseFeaturedAlt2(albumId, videoId);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<SetVideoAsShowcaseFeaturedAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SetVideoAsShowcaseFeaturedAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetVideoAsShowcaseFeaturedAlt2Error](Errors/SetVideoAsShowcaseFeaturedAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; SetVideoAsShowcaseThumbnail(double albumId, double userId, double videoId, UsersAlbumsVideosVideoIdSetAlbumThumbnailRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a thumbnail image for a showcase from the specified frame of a showcase video. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesShowcaseVideos.SetVideoAsShowcaseThumbnail(albumId, userId, videoId, body);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<SetVideoAsShowcaseThumbnailError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SetVideoAsShowcaseThumbnailError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[UsersAlbumsVideosVideoIdSetAlbumThumbnailRequest?](Models/UsersAlbumsVideosVideoIdSetAlbumThumbnailRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetVideoAsShowcaseThumbnailError](Errors/SetVideoAsShowcaseThumbnailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Album&gt; SetVideoAsShowcaseThumbnailAlt2(double albumId, double videoId, MeAlbumsVideosSetAlbumThumbnailRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a thumbnail image for a showcase from the specified frame of a showcase video. The authenticated user must be the owner of the showcase.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ShowcasesShowcaseVideos.SetVideoAsShowcaseThumbnailAlt2(albumId, videoId, body);
    // TODO: Handle 'response' of type Album
}
catch (SdkException<SetVideoAsShowcaseThumbnailAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SetVideoAsShowcaseThumbnailAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[MeAlbumsVideosSetAlbumThumbnailRequest?](Models/MeAlbumsVideosSetAlbumThumbnailRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Album](Models/Album.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetVideoAsShowcaseThumbnailAlt2Error](Errors/SetVideoAsShowcaseThumbnailAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SubscriptionPlansEssentials

> Source: [SubscriptionPlansEssentials](Api/SubscriptionPlansEssentials.cs)

<details>
<summary><code>Task GetPlan(Tier1 tier, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified subscription plan.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SubscriptionPlansEssentials.GetPlan(tier);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>tier</code> | <code>[Tier1](Models/Enums/Tier1.cs)</code> | The type of subscription plan.<br><br>Option descriptions:<br> * `advanced` - The plan type is Vimeo Advanced.<br> * `business` - The plan type is Vimeo Business.<br> * `free` - The plan type is Vimeo Free.<br> * `live_premium` - The plan type is Vimeo Premium.<br> * `plus` - The plan type is Vimeo Plus.<br> * `pro` - The plan type is Vimeo Pro.<br> * `pro_unlimited` - The plan type is Vimeo Pro Unlimited.<br> * `standard` - The plan type is Vimeo Standard.<br> * `starter` - The plan type is Vimeo Starter. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TagsEssentials

> Source: [TagsEssentials](Api/TagsEssentials.cs)

<details>
<summary><code>Task&lt;Tag&gt; GetTag(string word, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified tag.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TagsEssentials.GetTag(word);
    // TODO: Handle 'response' of type Tag
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>word</code> | <code>string</code> | The tag to return. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Tag](Models/Tag.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TeamsEssentials

> Source: [TeamsEssentials](Api/TeamsEssentials.cs)

<details>
<summary><code>Task BackfillTeamCustomMetadata(double userId, TeamsCustomMetadataBackfillRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method applies a custom metadata value across every existing video owned by the
team. Use it to populate a newly created field, fix a typo across a library, or align
a large catalog after a workflow change.

The backfill runs **asynchronously**. The response is returned as soon as the job is
accepted, but the values themselves are propagated in the background and may take
several minutes for large libraries. The `total_videos` count in the response is a
snapshot of how many videos match the request at the moment it's accepted; videos
uploaded after that point aren't included and need a separate backfill.

By default, only videos that don't already have a value for the field are updated.
Set `override_existing` to `true` to replace existing values as well.

The value provided must match the field's data type. For example, a `date` field
requires `YYYY-MM-DD`, a `select` field requires one of its allowed values, and a
`multi-select` field requires a JSON-encoded array of allowed values.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TeamsEssentials.BackfillTeamCustomMetadata(userId, body);
}
catch (SdkException<BackfillTeamCustomMetadataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type BackfillTeamCustomMetadataError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the team owner. |
| <code>body</code> | <code>[TeamsCustomMetadataBackfillRequest](Models/TeamsCustomMetadataBackfillRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BackfillTeamCustomMetadataError](Errors/BackfillTeamCustomMetadataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetTeamCustomMetadataIncompleteVideos(double userId, double? page, double? perPage, Sort48? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the team's videos that are missing one or more values for
**mandatory** custom metadata fields. Use it to power dashboards that surface incomplete
videos, drive curation workflows, or generate reports of catalog completeness.

Each item in the response includes the video's title and identifier, a link to the
video's management page, a thumbnail, the last modified timestamp, and the list of
mandatory fields that still need a value (each with its `field_id` and `name`).

Only fields marked `mandatory: true` (see `POST /teams/{user_id}/custom_metadata`) are
considered. Teams with no mandatory fields receive an empty result set.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TeamsEssentials.GetTeamCustomMetadataIncompleteVideos(userId, page, perPage, sort);
}
catch (SdkException<GetTeamCustomMetadataIncompleteVideosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetTeamCustomMetadataIncompleteVideosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the team owner. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. Defaults to `1`. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page, up to a maximum of `100`. Defaults to `25`. |
| <code>sort</code> | <code>[Sort48?](Models/Enums/Sort48.cs)</code> | The order in which to return the results. Defaults to `title_asc`.<br><br>Option descriptions:<br> * `modified_asc` - Sort by last modified time, oldest first.<br> * `modified_desc` - Sort by last modified time, newest first.<br> * `title_asc` - Sort by video title, ascending.<br> * `title_desc` - Sort by video title, descending. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTeamCustomMetadataIncompleteVideosError](Errors/GetTeamCustomMetadataIncompleteVideosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CustomMetadataSettingsConnection&gt; GetTeamCustomMetadataSettings(double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every custom metadata field defined for the specified team.

Custom metadata fields let teams attach structured, queryable information to videos
(for example, a department selector, a release date, or a freeform note). Once a field
is defined here, you can assign per-video values via
`PUT /videos/{video_id}/custom_metadata`.

The response contains the field definitions only; per-video values are returned by
the video endpoints. Use this method to populate a UI that lets users fill in metadata,
or to discover the field IDs you need for backfills and value updates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamsEssentials.GetTeamCustomMetadataSettings(userId);
    // TODO: Handle 'response' of type CustomMetadataSettingsConnection
}
catch (SdkException<GetTeamCustomMetadataSettingsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetTeamCustomMetadataSettingsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the team owner. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CustomMetadataSettingsConnection](Models/CustomMetadataSettingsConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTeamCustomMetadataSettingsError](Errors/GetTeamCustomMetadataSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CustomMetadataSettings&gt; UpdateCustomMetadataFieldOptions(double userId, TeamsCustomMetadataOptionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method modifies the allowed value list of a `select` or `multi-select` custom
metadata field. Use it to rename an option, remove an option, or add a new option
without recreating the field.

Each entry in the `options` array describes one atomic change, defined by combining
`old_value` and `new_value`:

| `old_value`     | `new_value`     | Operation                      |
| --------------- | --------------- | ------------------------------ |
| string          | string          | Rename `old_value` to `new_value` |
| string          | `null` / omitted | Delete `old_value` from the field |
| `null` / omitted | string          | Add `new_value` to the field   |

Renames are propagated to every existing video that uses the option, so the change
is visible across the team's library. Deletes also remove the option from every
video that had it set. Propagation runs in the background; the field's option list
itself is updated synchronously and returned in the response.

A few rules to be aware of:

- The field must be of type `select` or `multi-select`. Other types reject the request.
- Cascading renames (renaming `A` to `B`, then `B` to `C` in the same call) are not
  allowed; submit them as separate requests if you need that effect.
- The resulting option list must not contain duplicates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamsEssentials.UpdateCustomMetadataFieldOptions(userId, body);
    // TODO: Handle 'response' of type CustomMetadataSettings
}
catch (SdkException<UpdateCustomMetadataFieldOptionsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UpdateCustomMetadataFieldOptionsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the team owner. |
| <code>body</code> | <code>[TeamsCustomMetadataOptionsRequest](Models/TeamsCustomMetadataOptionsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CustomMetadataSettings](Models/CustomMetadataSettings.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateCustomMetadataFieldOptionsError](Errors/UpdateCustomMetadataFieldOptionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CustomMetadataSettings&gt;&gt; UpsertCustomMetadataSettings(double userId, TeamsCustomMetadataRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates, updates, or deletes custom metadata fields for a team in a single
request. Each entry in the `fields` array is treated independently:

- To **create** a new field, omit `id` and provide `name`, `type`, and `mandatory`.
- To **update** an existing field, provide `id` along with the values you want to change.
  Other values are left untouched.
- To **delete** an existing field, provide `id` and set `delete: true`. Deleting a field
  also removes every value assigned to it across the team's videos.

Some constraints are worth knowing up front:

- A team can have a maximum of 20 custom metadata fields. Requests that would exceed
  that limit after deletes are applied are rejected.
- The `type` of an existing field can't be changed once the field is created.
- A field that was created as optional can't be made `mandatory` later.
- All operations in the request are applied as a single batch; if any one fails the
  whole request is rejected and no changes are saved.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TeamsEssentials.UpsertCustomMetadataSettings(userId, body);
    // TODO: Handle 'response' of type IReadOnlyList<CustomMetadataSettings>
}
catch (SdkException<UpsertCustomMetadataSettingsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UpsertCustomMetadataSettingsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the team owner. |
| <code>body</code> | <code>[TeamsCustomMetadataRequest?](Models/TeamsCustomMetadataRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CustomMetadataSettings](Models/CustomMetadataSettings.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpsertCustomMetadataSettingsError](Errors/UpsertCustomMetadataSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TeamsMembers

> Source: [TeamsMembers](Api/TeamsMembers.cs)

<details>
<summary><code>Task GetTeamInformation(string code, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns information about the membership of the specified team. Usage is currently limited to the team join forms.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TeamsMembers.GetTeamInformation(code);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>code</code> | <code>string</code> | The code corresponding to the desired team. This value appears under `TeamUser` > `code`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetTeamInformation2(double teamUserId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns information about the membership of the specified team. Usage is currently limited to the team join forms.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TeamsMembers.GetTeamInformation2(teamUserId, userId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>teamUserId</code> | <code>double</code> | The ID of the team user. |
| <code>userId</code> | <code>double</code> | The ID of the team owner. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetTeamRoleInformation(double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns information about the authenticated user's role on the specified team owner's team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TeamsMembers.GetTeamRoleInformation(userId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the team owner. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TutorialEssentials

> Source: [TutorialEssentials](Api/TutorialEssentials.cs)

<details>
<summary><code>Task DeveloperTutorial(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method tests whether users who are working through the [Getting Started](https://developer.vimeo.com/api/guides/start) guides have set up their configurations correctly.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TutorialEssentials.DeveloperTutorial();
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersAnalytics

> Source: [UsersAnalytics](Api/UsersAnalytics.cs)

<details>
<summary><code>Task&lt;AnalyticsConnection&gt; GetUserAnalytics(double userId, Dimension dimension, string from, string to, Direction? direction, string? filterContent, IReadOnlyList&lt;string&gt;? filterCountries, string? filterCustomMetadata, IReadOnlyList&lt;string&gt;? filterDeviceTypes, IReadOnlyList&lt;string&gt;? filterEmbedDomains, IReadOnlyList&lt;string&gt;? filterRegions, IReadOnlyList&lt;string&gt;? filterStreamingTypes, string? filterWorkspaces, double? page, double? perPage, Sort22? sort, TimeInterval? timeInterval, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns video analytics for the authenticated user's Vimeo account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersAnalytics.GetUserAnalytics(userId,
        dimension,
        from,
        to,
        direction,
        filterContent,
        filterCountries,
        filterCustomMetadata,
        filterDeviceTypes,
        filterEmbedDomains,
        filterRegions,
        filterStreamingTypes,
        filterWorkspaces,
        page,
        perPage,
        sort,
        timeInterval);
    // TODO: Handle 'response' of type AnalyticsConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>dimension</code> | <code>[Dimension](Models/Enums/Dimension.cs)</code> | The data dimension by which to group the results.<br><br>Option descriptions:<br> * `browser` - Group the results by browser.<br> * `city` - Group the results by city.<br> * `country` - Group the results by country.<br> * `device_type` - Group the results by device type.<br> * `embed_domain` - Group the results by embed domain.<br> * `embed_domain_path` - Group the results by embed domain path.<br> * `os` - Group the results by operating system.<br> * `region` - Group the results by region.<br> * `streaming_type` - Group the results by streaming type.<br> * `total` - Group the results by the time range provided.<br> * `video` - Group the results by video. |
| <code>from</code> | <code>string</code> | The start date of the range of results in ISO 8601 format. |
| <code>to</code> | <code>string</code> | The end date of the range of results in ISO 8601 format. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filterContent</code> | <code>string?</code> | A comma-separated list of video, folder, or event URIs to filter. |
| <code>filterCountries</code> | <code>IReadOnlyList&lt;string&gt;?</code> | A comma-separated list of country codes in ISO-3166 format to filter on. |
| <code>filterCustomMetadata</code> | <code>string?</code> | A JSON-encoded custom-metadata filter. Accepts either a bare list of clauses (combined with `and`) or an envelope `{"logic":"and"\|"or","clauses":[...]}`. Each clause is an object with `field_id` (integer; matches one of the owning team's `CustomMetadataSettings` fields), `operator` (one of `eq`, `ne`, `gt`, `lt`, `contains`, `not_contains`, `empty`, `not_empty`; the allowed operators depend on the field type), and optional `value` (string; required for every operator except `empty`/`not_empty`). The matching videos are resolved via the search index and intersected with `filter_content` before being passed to the analytics service. |
| <code>filterDeviceTypes</code> | <code>IReadOnlyList&lt;string&gt;?</code> | A comma-separated list of device types to filter on. |
| <code>filterEmbedDomains</code> | <code>IReadOnlyList&lt;string&gt;?</code> | A comma-separated list of domain names to filter on. |
| <code>filterRegions</code> | <code>IReadOnlyList&lt;string&gt;?</code> | A comma-separated list of combined country and region codes in ISO-3166 format to filter on. |
| <code>filterStreamingTypes</code> | <code>IReadOnlyList&lt;string&gt;?</code> | A comma-separated list of streaming types to filter on. |
| <code>filterWorkspaces</code> | <code>string?</code> | A comma-separated list of workspace IDs to filter for. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The maximum number of items returned from the request, up to a limit of 1000 items. The default value is `50`. |
| <code>sort</code> | <code>[Sort22?](Models/Enums/Sort22.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `comments` - Sort the results by the number of comments.<br> * `completions` - Sort the results by number of completions.<br> * `country` - Sort the results by country.<br> * `default` - Sort the results by the values of both the **dimension** and **time_interval** fields.<br> * `device_type` - Sort the results by device type.<br> * `downloads` - Sort the results by the number of downloads.<br> * `drm_licenses_used` - Sort the results by the number of DRM licenses used. _This option is available only to users with the DRM feature._<br> * `embed_domain` - Sort the results by embed domain.<br> * `finishes` - Sort the results by the number of complete plays.<br> * `five_star_clicks` - Sort the results by the number of five-star ranking clicks.<br> * `four_star_clicks` - Sort the results by the number of four-star ranking clicks.<br> * `impressions` - Sort the results by the number of impressions.<br> * `like` - Sort the results by the number of likes.<br> * `mean_percent_watched` - Sort the results by mean percentage played.<br> * `mean_seconds_watched` - Sort the results by mean seconds played.<br> * `one_star_clicks` - Sort the results by the number of one-star ranking clicks.<br> * `ranking_widget_average_rating` - Sort the results by the average ranking widget rating.<br> * `ranking_widget_clicks` - Sort the results by the number of ranking widget clicks.<br> * `third_party_impressions` - Sort the results by the number of impressions from all non-Vimeo players.<br> * `three_star_clicks` - Sort the results by the number of three-star ranking clicks.<br> * `thumbs_down_clicks` - Sort the results by the number of thumbs-down clicks.<br> * `thumbs_up_clicks` - Sort the results by the number of thumbs-up clicks.<br> * `thumbs_widget_average_rating` - Sort the results by the average thumbs widget rating.<br> * `thumbs_widget_clicks` - Sort the results by the number of thumbs widget clicks.<br> * `time` - Sort the results by the value of the **start_date** field. This option is available only when the value of **time_interval** isn't `none`.<br> * `total_seconds_watched` - Sort the results by total seconds played.<br> * `two_star_clicks` - Sort the results by the number of two-star ranking clicks.<br> * `unique_impressions` - Sort the results by unique impressions.<br> * `unique_viewers` - Sort the results by unique viewers.<br> * `video` - Sort the results by video ID.<br> * `views` - Sort the results by the number of views. |
| <code>timeInterval</code> | <code>[TimeInterval?](Models/Enums/TimeInterval.cs)</code> | The interval by which to aggregate the data according to the specified data dimension. The default value is `none`. This parameter works only when the value of **dimension** is `video`, `country`, `embed_domain`, `device_type`, or `streaming_type`.<br><br>Option descriptions:<br> * `day` - Aggregate the results by day according to the specified data dimension.<br> * `month` - Aggregate the results by month according to the specified data dimension.<br> * `none` - The results are not aggregated by time interval.<br> * `week` - Aggregate the results by week according to the specified data dimension.<br> * `year` - Aggregate the results by year according to the specified data dimension. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnalyticsConnection](Models/AnalyticsConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnalyticsConnection&gt; GetUserAnalyticsAlt1(Dimension dimension, string from, string to, Direction? direction, string? filterContent, IReadOnlyList&lt;string&gt;? filterCountries, string? filterCustomMetadata, IReadOnlyList&lt;string&gt;? filterDeviceTypes, IReadOnlyList&lt;string&gt;? filterEmbedDomains, IReadOnlyList&lt;string&gt;? filterRegions, IReadOnlyList&lt;string&gt;? filterStreamingTypes, string? filterWorkspaces, double? page, double? perPage, Sort22? sort, TimeInterval? timeInterval, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns video analytics for the authenticated user's Vimeo account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersAnalytics.GetUserAnalyticsAlt1(dimension,
        from,
        to,
        direction,
        filterContent,
        filterCountries,
        filterCustomMetadata,
        filterDeviceTypes,
        filterEmbedDomains,
        filterRegions,
        filterStreamingTypes,
        filterWorkspaces,
        page,
        perPage,
        sort,
        timeInterval);
    // TODO: Handle 'response' of type AnalyticsConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>dimension</code> | <code>[Dimension](Models/Enums/Dimension.cs)</code> | The data dimension by which to group the results.<br><br>Option descriptions:<br> * `browser` - Group the results by browser.<br> * `city` - Group the results by city.<br> * `country` - Group the results by country.<br> * `device_type` - Group the results by device type.<br> * `embed_domain` - Group the results by embed domain.<br> * `embed_domain_path` - Group the results by embed domain path.<br> * `os` - Group the results by operating system.<br> * `region` - Group the results by region.<br> * `streaming_type` - Group the results by streaming type.<br> * `total` - Group the results by the time range provided.<br> * `video` - Group the results by video. |
| <code>from</code> | <code>string</code> | The start date of the range of results in ISO 8601 format. |
| <code>to</code> | <code>string</code> | The end date of the range of results in ISO 8601 format. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filterContent</code> | <code>string?</code> | A comma-separated list of video, folder, or event URIs to filter. |
| <code>filterCountries</code> | <code>IReadOnlyList&lt;string&gt;?</code> | A comma-separated list of country codes in ISO-3166 format to filter on. |
| <code>filterCustomMetadata</code> | <code>string?</code> | A JSON-encoded custom-metadata filter. Accepts either a bare list of clauses (combined with `and`) or an envelope `{"logic":"and"\|"or","clauses":[...]}`. Each clause is an object with `field_id` (integer; matches one of the owning team's `CustomMetadataSettings` fields), `operator` (one of `eq`, `ne`, `gt`, `lt`, `contains`, `not_contains`, `empty`, `not_empty`; the allowed operators depend on the field type), and optional `value` (string; required for every operator except `empty`/`not_empty`). The matching videos are resolved via the search index and intersected with `filter_content` before being passed to the analytics service. |
| <code>filterDeviceTypes</code> | <code>IReadOnlyList&lt;string&gt;?</code> | A comma-separated list of device types to filter on. |
| <code>filterEmbedDomains</code> | <code>IReadOnlyList&lt;string&gt;?</code> | A comma-separated list of domain names to filter on. |
| <code>filterRegions</code> | <code>IReadOnlyList&lt;string&gt;?</code> | A comma-separated list of combined country and region codes in ISO-3166 format to filter on. |
| <code>filterStreamingTypes</code> | <code>IReadOnlyList&lt;string&gt;?</code> | A comma-separated list of streaming types to filter on. |
| <code>filterWorkspaces</code> | <code>string?</code> | A comma-separated list of workspace IDs to filter for. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The maximum number of items returned from the request, up to a limit of 1000 items. The default value is `50`. |
| <code>sort</code> | <code>[Sort22?](Models/Enums/Sort22.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `comments` - Sort the results by the number of comments.<br> * `completions` - Sort the results by number of completions.<br> * `country` - Sort the results by country.<br> * `default` - Sort the results by the values of both the **dimension** and **time_interval** fields.<br> * `device_type` - Sort the results by device type.<br> * `downloads` - Sort the results by the number of downloads.<br> * `drm_licenses_used` - Sort the results by the number of DRM licenses used. _This option is available only to users with the DRM feature._<br> * `embed_domain` - Sort the results by embed domain.<br> * `finishes` - Sort the results by the number of complete plays.<br> * `five_star_clicks` - Sort the results by the number of five-star ranking clicks.<br> * `four_star_clicks` - Sort the results by the number of four-star ranking clicks.<br> * `impressions` - Sort the results by the number of impressions.<br> * `like` - Sort the results by the number of likes.<br> * `mean_percent_watched` - Sort the results by mean percentage played.<br> * `mean_seconds_watched` - Sort the results by mean seconds played.<br> * `one_star_clicks` - Sort the results by the number of one-star ranking clicks.<br> * `ranking_widget_average_rating` - Sort the results by the average ranking widget rating.<br> * `ranking_widget_clicks` - Sort the results by the number of ranking widget clicks.<br> * `third_party_impressions` - Sort the results by the number of impressions from all non-Vimeo players.<br> * `three_star_clicks` - Sort the results by the number of three-star ranking clicks.<br> * `thumbs_down_clicks` - Sort the results by the number of thumbs-down clicks.<br> * `thumbs_up_clicks` - Sort the results by the number of thumbs-up clicks.<br> * `thumbs_widget_average_rating` - Sort the results by the average thumbs widget rating.<br> * `thumbs_widget_clicks` - Sort the results by the number of thumbs widget clicks.<br> * `time` - Sort the results by the value of the **start_date** field. This option is available only when the value of **time_interval** isn't `none`.<br> * `total_seconds_watched` - Sort the results by total seconds played.<br> * `two_star_clicks` - Sort the results by the number of two-star ranking clicks.<br> * `unique_impressions` - Sort the results by unique impressions.<br> * `unique_viewers` - Sort the results by unique viewers.<br> * `video` - Sort the results by video ID.<br> * `views` - Sort the results by the number of views. |
| <code>timeInterval</code> | <code>[TimeInterval?](Models/Enums/TimeInterval.cs)</code> | The interval by which to aggregate the data according to the specified data dimension. The default value is `none`. This parameter works only when the value of **dimension** is `video`, `country`, `embed_domain`, `device_type`, or `streaming_type`.<br><br>Option descriptions:<br> * `day` - Aggregate the results by day according to the specified data dimension.<br> * `month` - Aggregate the results by month according to the specified data dimension.<br> * `none` - The results are not aggregated by time interval.<br> * `week` - Aggregate the results by week according to the specified data dimension.<br> * `year` - Aggregate the results by year according to the specified data dimension. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnalyticsConnection](Models/AnalyticsConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersEssentials

> Source: [UsersEssentials](Api/UsersEssentials.cs)

<details>
<summary><code>Task&lt;User&gt; EditUser(double userId, UsersRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the Vimeo account of the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersEssentials.EditUser(userId, body);
    // TODO: Handle 'response' of type User
}
catch (SdkException<EditUserError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditUserError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersRequest?](Models/UsersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](Models/User.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditUserError](Errors/EditUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; EditUserAlt1(MeRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the Vimeo account of the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersEssentials.EditUserAlt1(body);
    // TODO: Handle 'response' of type User
}
catch (SdkException<EditUserAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditUserAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[MeRequest?](Models/MeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](Models/User.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditUserAlt1Error](Errors/EditUserAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; GetUser(double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersEssentials.GetUser(userId);
    // TODO: Handle 'response' of type User
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](Models/User.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;User&gt; GetUserAlt1(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersEssentials.GetUserAlt1();
    // TODO: Handle 'response' of type User
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](Models/User.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersFeeds

> Source: [UsersFeeds](Api/UsersFeeds.cs)

<details>
<summary><code>Task&lt;Activity31Connection&gt; GetFeed(double userId, string? offset, double? page, double? perPage, Type33? type, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video in the authenticated user's feed.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersFeeds.GetFeed(userId, offset, page, perPage, type);
    // TODO: Handle 'response' of type Activity31Connection
}
catch (SdkException<GetFeedError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetFeedError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>offset</code> | <code>string?</code> | The pagination offset. We recommend that you use the pagination links in the feed response instead of working with this value directly. For more details, see our [pagination documentation](https://developer.vimeo.com/api/common-formats#using-the-pagination-parameter). |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>type</code> | <code>[Type33?](Models/Enums/Type33.cs)</code> | The feed type.<br><br>Option descriptions:<br> * `appears` - Videos in which the user appears.<br> * `category_featured` - Featured videos.<br> * `channel` - Channel videos.<br> * `facebook_feed` - Videos from the user's Facebook feed.<br> * `following` - Videos from accounts that the user follows.<br> * `group` - Group videos.<br> * `likes` - Liked videos.<br> * `ondemand_publish` - On Demand videos.<br> * `share` - Shared videos.<br> * `tagged_with` - Tagged videos.<br> * `twitter_timeline` - Videos from the user's Twitter timeline.<br> * `uploads` - Uploaded videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Activity31Connection](Models/Activity31Connection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFeedError](Errors/GetFeedError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Activity31Connection&gt; GetFeedAlt1(string? offset, double? page, double? perPage, Type33? type, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video in the authenticated user's feed.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersFeeds.GetFeedAlt1(offset, page, perPage, type);
    // TODO: Handle 'response' of type Activity31Connection
}
catch (SdkException<GetFeedAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetFeedAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>offset</code> | <code>string?</code> | The pagination offset. We recommend that you use the pagination links in the feed response instead of working with this value directly. For more details, see our [pagination documentation](https://developer.vimeo.com/api/common-formats#using-the-pagination-parameter). |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>type</code> | <code>[Type33?](Models/Enums/Type33.cs)</code> | The feed type.<br><br>Option descriptions:<br> * `appears` - Videos in which the user appears.<br> * `category_featured` - Featured videos.<br> * `channel` - Channel videos.<br> * `facebook_feed` - Videos from the user's Facebook feed.<br> * `following` - Videos from accounts that the user follows.<br> * `group` - Group videos.<br> * `likes` - Liked videos.<br> * `ondemand_publish` - On Demand videos.<br> * `share` - Shared videos.<br> * `tagged_with` - Tagged videos.<br> * `twitter_timeline` - Videos from the user's Twitter timeline.<br> * `uploads` - Uploaded videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Activity31Connection](Models/Activity31Connection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFeedAlt1Error](Errors/GetFeedAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersFollowers

> Source: [UsersFollowers](Api/UsersFollowers.cs)

<details>
<summary><code>Task CheckIfUserIsFollowing(double followUserId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the authenticated user is a follower of the specified user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersFollowers.CheckIfUserIsFollowing(followUserId, userId);
}
catch (SdkException<CheckIfUserIsFollowingError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfUserIsFollowingError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>followUserId</code> | <code>double</code> | The ID of the user to follow. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfUserIsFollowingError](Errors/CheckIfUserIsFollowingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CheckIfUserIsFollowingAlt1(double followUserId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the authenticated user is a follower of the specified user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersFollowers.CheckIfUserIsFollowingAlt1(followUserId);
}
catch (SdkException<CheckIfUserIsFollowingAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfUserIsFollowingAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>followUserId</code> | <code>double</code> | The ID of the user to follow. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfUserIsFollowingAlt1Error](Errors/CheckIfUserIsFollowingAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task FollowUser(double followUserId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to become the follower of the specified user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersFollowers.FollowUser(followUserId, userId);
}
catch (SdkException<FollowUserError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type FollowUserError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>followUserId</code> | <code>double</code> | The ID of the user to follow. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FollowUserError](Errors/FollowUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task FollowUserAlt1(double followUserId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to become the follower of the specified user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersFollowers.FollowUserAlt1(followUserId);
}
catch (SdkException<FollowUserAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type FollowUserAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>followUserId</code> | <code>double</code> | The ID of the user to follow. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FollowUserAlt1Error](Errors/FollowUserAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task FollowUsers(double userId, UsersFollowingRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to become a follower of multiple users. In the body of the request, specify the list of users to follow as
an array of URIs, where `user01_id`, `user02_id`, `user03_id`, and so on, are the user IDs of the users in question:

```
{
 [
     {"uri" : "/users/{user01_id}"},
     {"uri" : "/users/{user02_id}"},
     {"uri" : "/users/{user03_id}"}
 ]
}
```

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersFollowers.FollowUsers(userId, body);
}
catch (SdkException<FollowUsersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type FollowUsersError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersFollowingRequest](Models/UsersFollowingRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FollowUsersError](Errors/FollowUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task FollowUsersAlt1(MeFollowingRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to become a follower of multiple users. In the body of the request, specify the list of users to follow as
an array of URIs, where `user01_id`, `user02_id`, `user03_id`, and so on, are the user IDs of the users in question:

```
{
 [
     {"uri" : "/users/{user01_id}"},
     {"uri" : "/users/{user02_id}"},
     {"uri" : "/users/{user03_id}"}
 ]
}
```

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersFollowers.FollowUsersAlt1(body);
}
catch (SdkException<FollowUsersAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type FollowUsersAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[MeFollowingRequest](Models/MeFollowingRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FollowUsersAlt1Error](Errors/FollowUsersAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetFollowers(double userId, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every follower of the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersFollowers.GetFollowers(userId, direction, page, perPage, query, sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date followed. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetFollowersAlt1(Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every follower of the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersFollowers.GetFollowersAlt1(direction, page, perPage, query, sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date followed. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetUserFollowing(double userId, Direction? direction, Filter13? filter, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every user who is followed by the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersFollowers.GetUserFollowing(userId, direction, filter, page, perPage, query, sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter13?](Models/Enums/Filter13.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `online` - Return users who are currently online. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date followed. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetUserFollowingAlt1(Direction? direction, Filter13? filter, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every user who is followed by the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersFollowers.GetUserFollowingAlt1(direction, filter, page, perPage, query, sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter13?](Models/Enums/Filter13.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `online` - Return users who are currently online. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date followed. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UnfollowUser(double followUserId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to stop following another user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersFollowers.UnfollowUser(followUserId, userId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>followUserId</code> | <code>double</code> | The ID of the user to unfollow. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UnfollowUserAlt1(double followUserId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method causes the authenticated user to stop following another user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersFollowers.UnfollowUserAlt1(followUserId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>followUserId</code> | <code>double</code> | The ID of the user to unfollow. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersLms

> Source: [UsersLms](Api/UsersLms.cs)

<details>
<summary><code>Task DownloadLmsPackage(double userId, double videoId, double? completionThreshold, string? courseTitle, double? passingScore, ScoringAlgorithm? scoringAlgorithm, Standard? standard, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates and returns a zipped proxy package of the course associated with the specified video. This package is suitable for direct upload to a learning management system.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersLms.DownloadLmsPackage(userId,
        videoId,
        completionThreshold,
        courseTitle,
        passingScore,
        scoringAlgorithm,
        standard);
}
catch (SdkException<DownloadLmsPackageError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DownloadLmsPackageError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the team owner. |
| <code>videoId</code> | <code>double</code> | The ID of the course video. |
| <code>completionThreshold</code> | <code>double?</code> | The completion threshold for the course. |
| <code>courseTitle</code> | <code>string?</code> | The title of the course. |
| <code>passingScore</code> | <code>double?</code> | The passing score for the course. |
| <code>scoringAlgorithm</code> | <code>[ScoringAlgorithm?](Models/Enums/ScoringAlgorithm.cs)</code> | The scoring algorithm for the course.<br><br>Option descriptions:<br> * `passfail` - The score is based on a pass or fail.<br> * `percentage` - The score is based on a percentage.<br> * `quiz` - The score is based on the course quiz. |
| <code>standard</code> | <code>[Standard?](Models/Enums/Standard.cs)</code> | The learning management system standard used to create the proxy package.<br><br>Option descriptions:<br> * `aicc` - The standard is AICC.<br> * `cmi5` - The standard is cmi5.<br> * `scorm12` - The standard is SCORM 1.2.<br> * `scorm2004_3rd` - The standard is SCORM 2004 3rd Edition.<br> * `tincan` - The standard is Tin Can or xAPI. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DownloadLmsPackageError](Errors/DownloadLmsPackageError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersPictures

> Source: [UsersPictures](Api/UsersPictures.cs)

<details>
<summary><code>Task&lt;Picture&gt; CreatePicture(double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a portrait image to the authenticated user's Vimeo account. Send the binary data of the image file to the location that you receive
from the **link** field in the response. For step-by-step instructions, see
[Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails#uploading-a-thumbnail-step-3).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersPictures.CreatePicture(userId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; CreatePictureAlt1(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a portrait image to the authenticated user's Vimeo account. Send the binary data of the image file to the location that you receive
from the **link** field in the response. For step-by-step instructions, see
[Working with Thumbnail Uploads](https://developer.vimeo.com/api/upload/thumbnails#uploading-a-thumbnail-step-3).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersPictures.CreatePictureAlt1();
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeletePicture(double portraitsetId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the specified portrait image from the authenticated user's Vimeo account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersPictures.DeletePicture(portraitsetId, userId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portraitsetId</code> | <code>double</code> | The ID of the picture. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeletePictureAlt1(double portraitsetId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the specified portrait image from the authenticated user's Vimeo account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersPictures.DeletePictureAlt1(portraitsetId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portraitsetId</code> | <code>double</code> | The ID of the picture. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; EditPicture(double portraitsetId, double userId, UsersPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified portrait image belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersPictures.EditPicture(portraitsetId, userId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portraitsetId</code> | <code>double</code> | The ID of the picture. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersPicturesRequest?](Models/UsersPicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; EditPictureAlt1(double portraitsetId, MePicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified portrait image belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersPictures.EditPictureAlt1(portraitsetId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portraitsetId</code> | <code>double</code> | The ID of the picture. |
| <code>body</code> | <code>[MePicturesRequest?](Models/MePicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetPicture(double portraitsetId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single portrait image belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersPictures.GetPicture(portraitsetId, userId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portraitsetId</code> | <code>double</code> | The ID of the picture. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetPictureAlt1(double portraitsetId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single portrait image belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersPictures.GetPictureAlt1(portraitsetId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>portraitsetId</code> | <code>double</code> | The ID of the picture. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetPictures(double userId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every portrait image belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersPictures.GetPictures(userId, page, perPage);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetPicturesAlt1(double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every portrait image belonging to the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersPictures.GetPicturesAlt1(page, perPage);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersSearch

> Source: [UsersSearch](Api/UsersSearch.cs)

<details>
<summary><code>Task&lt;UserConnection&gt; SearchUsers(Direction? direction, double? page, double? perPage, string? query, Sort13? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns user search results.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersSearch.SearchUsers(direction, page, perPage, query, sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<SearchUsersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SearchUsersError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort13?](Models/Enums/Sort13.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by creation date.<br> * `followers` - Sort the results by number of followers.<br> * `relevant` - Sort the results by relevance.<br> * `videos` - Sort the results by number of videos. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SearchUsersError](Errors/SearchUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UsersWatchHistory

> Source: [UsersWatchHistory](Api/UsersWatchHistory.cs)

<details>
<summary><code>Task DeleteFromWatchHistory(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified video from the authenticated user's watch history.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersWatchHistory.DeleteFromWatchHistory(videoId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteWatchHistory(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the entire watch history of the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.UsersWatchHistory.DeleteWatchHistory();
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetWatchHistory(double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video on the authenticated user's watch history. _This endpoint is deprecated. Any request to it returns empty data with HTTP status code 200._

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UsersWatchHistory.GetWatchHistory(page, perPage);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetWatchHistoryError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetWatchHistoryError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetWatchHistoryError](Errors/GetWatchHistoryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosAi

> Source: [VideosAi](Api/VideosAi.cs)

<details>
<summary><code>Task AskAiQuestion(double videoId, VideosAiAskRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method asks a question about a video and returns an AI-generated answer with relevant
quotes and timecodes. Answering questions requires generating artifacts from the video, so
the first request for a new video may return a `202` response — simply retry until a `200`
is returned with the answer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAi.AskAiQuestion(videoId, body);
}
catch (SdkException<AskAiQuestionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AskAiQuestionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosAiAskRequest?](Models/VideosAiAskRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AskAiQuestionError](Errors/AskAiQuestionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task EditAiTexttrack(double texttrackId, double videoId, VideosAiTexttracksRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits transcript segments on the specified text track and automatically
triggers the appropriate downstream actions based on the track type:

- **Source transcript**: saves edits, then re-translates all subtitle children
  for the edited text segments. Timestamp and speaker changes are synced to children
  directly (no re-translation for speaker-only edits).
- **Dubbed track**: saves edits and triggers audio re-synthesis for the edited segments.
  Re-synthesis fires on text edits and on speaker reassignment (the dub is regenerated
  under the new speaker's voice).
- **Subtitle child**: saves text edits to this track only. Timestamp and speaker changes
  are synced to the parent track and all sibling subtitle tracks.

To retrieve the `texttrack_id`, use the GET endpoints for
[transcription](#get_ai_transcribe_status),
[subtitle translation](#get_ai_translate_subtitles_status), or
[dubbing](#get_ai_translate_dubbing_status).
To retrieve segment UUIDs and their current text and timecodes, use
`GET /videos/{video_id}/transcripts/{texttrack_id}`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAi.EditAiTexttrack(texttrackId, videoId, body);
}
catch (SdkException<EditAiTexttrackError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditAiTexttrackError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>texttrackId</code> | <code>double</code> | The ID of the text track. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosAiTexttracksRequest?](Models/VideosAiTexttracksRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditAiTexttrackError](Errors/EditAiTexttrackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetAiLanguages(Type52? type, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the list of supported languages for AI features. Use the `type` query parameter to
filter by feature: `transcription` for speech-to-text languages, `subtitling` for subtitle translation
languages, or `dubbing` for audio dubbing languages (includes available accents per language).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAi.GetAiLanguages(type);
}
catch (SdkException<GetAiLanguagesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAiLanguagesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>type</code> | <code>[Type52?](Models/Enums/Type52.cs)</code> | The AI feature type to list languages for.<br><br>Option descriptions:<br> * `dubbing` - Languages supported for AI audio dubbing. Includes available accents per language.<br> * `subtitling` - Languages supported for AI subtitle translation.<br> * `transcription` - Languages supported for AI transcription (speech-to-text). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAiLanguagesError](Errors/GetAiLanguagesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetAiMetadata(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns AI-generated metadata for the specified video, including a suggested
title, description, and tags based on the video's content. The first request for a new
video may return a `202` response while the video is being processed — retry until ready.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAi.GetAiMetadata(videoId);
}
catch (SdkException<GetAiMetadataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAiMetadataError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAiMetadataError](Errors/GetAiMetadataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetAiQuestions(double videoId, string? language, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns pre-generated questions and answers about a video. These are
automatically created when the video is processed and provide a starting point for
exploring the video's content. The first request for a new video may return a `202`
response while artifacts are being generated — retry until ready.

Questions are available in `en`, `fr`, `es`, `de`, `it`, `pt`, `ja`, and `ko`.
English is returned by default.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAi.GetAiQuestions(videoId, language);
}
catch (SdkException<GetAiQuestionsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAiQuestionsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>language</code> | <code>string?</code> | The language for suggested questions. Defaults to `en`. Available: `en`, `fr`, `es`, `de`, `it`, `pt`, `ja`, `ko`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAiQuestionsError](Errors/GetAiQuestionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetAiTranscribeStatus(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the current transcription status for a video. The response includes the `video_id`,
`status`, and `language`. When the status is `completed`, the response also includes the `texttrack_id`
which can be used to read the transcript via `GET /videos/{video_id}/transcripts/{texttrack_id}`.

Possible status values: `none` (no transcription requested), `not_started` (queued, awaiting processing),
`in_progress`, `completed`, `failed`, `language_not_supported`, `no_speech`, `exceeds_maximum_duration`,
`blocked`, `unknown`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAi.GetAiTranscribeStatus(videoId);
}
catch (SdkException<GetAiTranscribeStatusError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAiTranscribeStatusError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAiTranscribeStatusError](Errors/GetAiTranscribeStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetAiTranslateDubbingStatus(double videoId, string? language, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the audio dubbing jobs for a video. Each entry includes the language, current status,
and — when completed — the `texttrack_id` of the dubbed subtitles and the `audiotrack_uri` of the dubbed
audio. Only completed jobs whose text track still exists are included; deleted tracks are omitted.

Possible status values: `processing`, `completed`, `completed_with_deleted_texttrack`, `completed_with_deleted_audiotrack`, `failed`, `invalid_input` (the source content was not suitable for dubbing), `not_found`, `unknown`. Jobs where both the text track and audio track have been deleted are omitted entirely.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAi.GetAiTranslateDubbingStatus(videoId, language);
}
catch (SdkException<GetAiTranslateDubbingStatusError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAiTranslateDubbingStatusError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>language</code> | <code>string?</code> | Filter results to a specific target language code. When omitted, all dubbing jobs are returned. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAiTranslateDubbingStatusError](Errors/GetAiTranslateDubbingStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetAiTranslateSubtitlesStatus(double videoId, string? language, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the subtitle translation jobs for a video. Each entry includes the language,
current status, and — when completed — the `texttrack_id` of the resulting text track. Only completed
translations whose text track still exists are included; deleted tracks are omitted.

Possible status values: `processing`, `completed`, `failed`, `invalid_input` (the source content was not suitable for translation), `not_found`, `unknown`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAi.GetAiTranslateSubtitlesStatus(videoId, language);
}
catch (SdkException<GetAiTranslateSubtitlesStatusError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAiTranslateSubtitlesStatusError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>language</code> | <code>string?</code> | Filter results to a specific target language code. When omitted, all subtitle translation jobs are returned. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAiTranslateSubtitlesStatusError](Errors/GetAiTranslateSubtitlesStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task StartAiTranscribe(double videoId, VideosAiTranscribeRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method generates a transcript from the video's audio using AI speech-to-text. The video must not already
have a transcript — delete the existing one first if you need to regenerate. Transcription is asynchronous;
use `GET /videos/{video_id}/ai/transcribe` to poll for completion. Once complete, read the transcript via
`GET /videos/{video_id}/transcripts/{texttrack_id}`.

When no language is provided, the system attempts to auto-detect the spoken language from the video's audio.
If detection fails or confidence is too low, it falls back to the video's locale, then the user's locale
preference, then English (`en`).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAi.StartAiTranscribe(videoId, body);
}
catch (SdkException<StartAiTranscribeError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type StartAiTranscribeError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosAiTranscribeRequest?](Models/VideosAiTranscribeRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[StartAiTranscribeError](Errors/StartAiTranscribeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task StartAiTranslateDubbing(double videoId, VideosAiTranslateDubbingRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method starts an audio dubbing job for a video. By calling this endpoint, you confirm that you, and
your end users, have met all legal requirements to use the voices of the people in the source video to
create synthetic audio. This may include obtaining written consent.

The video must have finished transcoding, have a completed transcript, and be under 150 minutes in
duration. Dubbing is asynchronous; use `GET /videos/{video_id}/ai/translate/dubbing` to poll for
completion. Once complete, the dubbed audio appears as an alternate audio track and translated subtitles
appear as a new text track.

AI credits are deducted from the enterprise account's balance. Dubbing costs more credits than subtitling.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAi.StartAiTranslateDubbing(videoId, body);
}
catch (SdkException<StartAiTranslateDubbingError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type StartAiTranslateDubbingError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosAiTranslateDubbingRequest?](Models/VideosAiTranslateDubbingRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[StartAiTranslateDubbingError](Errors/StartAiTranslateDubbingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task StartAiTranslateSubtitles(double videoId, VideosAiTranslateSubtitlesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method starts a subtitle translation job for a video. The video must have finished transcoding and have
a completed transcript. Translation is asynchronous; use `GET /videos/{video_id}/ai/translate/subtitles` to
poll for completion. Once complete, the translated subtitles appear as a new text track accessible via
`GET /videos/{video_id}/texttracks`.

AI credits are deducted from the enterprise account's balance.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAi.StartAiTranslateSubtitles(videoId, body);
}
catch (SdkException<StartAiTranslateSubtitlesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type StartAiTranslateSubtitlesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosAiTranslateSubtitlesRequest?](Models/VideosAiTranslateSubtitlesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[StartAiTranslateSubtitlesError](Errors/StartAiTranslateSubtitlesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosAnimatedThumbnails

> Source: [VideosAnimatedThumbnails](Api/VideosAnimatedThumbnails.cs)

<details>
<summary><code>Task&lt;AnimatedThumbset&gt; CreateAnimatedThumbset(double videoId, VideosAnimatedThumbsetsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a set of animated thumbnails for the specified video. Please note that you can't create more than four sets of animated thumbnails for the same video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosAnimatedThumbnails.CreateAnimatedThumbset(videoId, body);
    // TODO: Handle 'response' of type AnimatedThumbset
}
catch (SdkException<CreateAnimatedThumbsetError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateAnimatedThumbsetError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosAnimatedThumbsetsRequest](Models/VideosAnimatedThumbsetsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnimatedThumbset](Models/AnimatedThumbset.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateAnimatedThumbsetError](Errors/CreateAnimatedThumbsetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteAnimatedThumbset(string pictureId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes a set of animated thumbnails for the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosAnimatedThumbnails.DeleteAnimatedThumbset(pictureId, videoId);
}
catch (SdkException<DeleteAnimatedThumbsetError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteAnimatedThumbsetError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>pictureId</code> | <code>string</code> | The UUID of the set of animated thumbnails. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteAnimatedThumbsetError](Errors/DeleteAnimatedThumbsetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnimatedThumbsetConnection&gt; GetAllAnimatedThumbset(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the sets of animated thumbnails associated with the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosAnimatedThumbnails.GetAllAnimatedThumbset(videoId, page, perPage);
    // TODO: Handle 'response' of type AnimatedThumbsetConnection
}
catch (SdkException<GetAllAnimatedThumbsetError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAllAnimatedThumbsetError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnimatedThumbsetConnection](Models/AnimatedThumbsetConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAllAnimatedThumbsetError](Errors/GetAllAnimatedThumbsetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnimatedThumbset&gt; GetAnimatedThumbset(string pictureId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a particular set of animated thumbnails associated with the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosAnimatedThumbnails.GetAnimatedThumbset(pictureId, videoId);
    // TODO: Handle 'response' of type AnimatedThumbset
}
catch (SdkException<GetAnimatedThumbsetError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAnimatedThumbsetError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>pictureId</code> | <code>string</code> | The UUID of the set of animated thumbnails. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnimatedThumbset](Models/AnimatedThumbset.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAnimatedThumbsetError](Errors/GetAnimatedThumbsetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AnimatedThumbset&gt; GetAnimatedThumbsetStatus(string pictureId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the status of a particular set of animated thumbnails associated with the specified video. The status indicates whether the thumbnails are ready to use. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosAnimatedThumbnails.GetAnimatedThumbsetStatus(pictureId, videoId);
    // TODO: Handle 'response' of type AnimatedThumbset
}
catch (SdkException<GetAnimatedThumbsetStatusError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAnimatedThumbsetStatusError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>pictureId</code> | <code>string</code> | The UUID of the set of animated thumbnails. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AnimatedThumbset](Models/AnimatedThumbset.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAnimatedThumbsetStatusError](Errors/GetAnimatedThumbsetStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosChapters

> Source: [VideosChapters](Api/VideosChapters.cs)

<details>
<summary><code>Task&lt;Chapter&gt; CreateChapter(double videoId, VideosChaptersRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a chapter to the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosChapters.CreateChapter(videoId, body);
    // TODO: Handle 'response' of type Chapter
}
catch (SdkException<CreateChapterError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateChapterError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosChaptersRequest?](Models/VideosChaptersRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Chapter](Models/Chapter.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateChapterError](Errors/CreateChapterError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; CreateChapterThumbnailOrUploadLink(double chapterId, double videoId, VideosChaptersPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method generates either an upload link or a timecode-based thumbnail for the specified saved video chapter. To generate the upload link, which enables the authenticated user to upload a chapter thumbnail image manually, leave the body of the request empty. To generate an automatic timecode-based thumbnail, include the **timecode** parameter in the body of the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosChapters.CreateChapterThumbnailOrUploadLink(chapterId, videoId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<CreateChapterThumbnailOrUploadLinkError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateChapterThumbnailOrUploadLinkError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>chapterId</code> | <code>double</code> | The ID of the chapter. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosChaptersPicturesRequest?](Models/VideosChaptersPicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateChapterThumbnailOrUploadLinkError](Errors/CreateChapterThumbnailOrUploadLinkError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; CreateUnsavedChapterThumbnailOrUploadLink(double videoId, VideosChaptersTemporaryPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method generates either an upload link or a timecode-based thumbnail for an unsaved video chapter. To generate the upload link, which enables the authenticated user to upload a chapter thumbnail image manually, leave the body of the request empty. To generate an automatic timecode-based thumbnail, specify the **timecode** parameter in the body of the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosChapters.CreateUnsavedChapterThumbnailOrUploadLink(videoId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<CreateUnsavedChapterThumbnailOrUploadLinkError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateUnsavedChapterThumbnailOrUploadLinkError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosChaptersTemporaryPicturesRequest?](Models/VideosChaptersTemporaryPicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateUnsavedChapterThumbnailOrUploadLinkError](Errors/CreateUnsavedChapterThumbnailOrUploadLinkError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteChapter(double chapterId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified chapter from a video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosChapters.DeleteChapter(chapterId, videoId);
}
catch (SdkException<DeleteChapterError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteChapterError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>chapterId</code> | <code>double</code> | The ID of the chapter. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteChapterError](Errors/DeleteChapterError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteChapterThumbnail(double chapterId, string uid, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified chapter thumbnail from a video.

The authenticated user must be the owner of the video that the chapter belongs to.
This method deletes both timecode-generated and custom-uploaded thumbnails.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosChapters.DeleteChapterThumbnail(chapterId, uid, videoId);
}
catch (SdkException<DeleteChapterThumbnailError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteChapterThumbnailError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>chapterId</code> | <code>double</code> | The ID of the chapter. |
| <code>uid</code> | <code>string</code> | The unique ID of the thumbnail. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteChapterThumbnailError](Errors/DeleteChapterThumbnailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Chapter&gt; EditChapter(double chapterId, double videoId, VideosChaptersRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified chapter of a video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosChapters.EditChapter(chapterId, videoId, body);
    // TODO: Handle 'response' of type Chapter
}
catch (SdkException<EditChapterError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditChapterError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>chapterId</code> | <code>double</code> | The ID of the chapter. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosChaptersRequest1?](Models/VideosChaptersRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Chapter](Models/Chapter.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditChapterError](Errors/EditChapterError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Chapter&gt; GetChapter(double chapterId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single chapter of the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosChapters.GetChapter(chapterId, videoId);
    // TODO: Handle 'response' of type Chapter
}
catch (SdkException<GetChapterError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChapterError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>chapterId</code> | <code>double</code> | The ID of the chapter. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Chapter](Models/Chapter.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChapterError](Errors/GetChapterError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetChapterThumbnail(double chapterId, double videoId, string uid, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified thumbnail associated with a saved video chapter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosChapters.GetChapterThumbnail(chapterId, videoId, uid);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetChapterThumbnailError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChapterThumbnailError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>chapterId</code> | <code>double</code> | The ID of the chapter. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>uid</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChapterThumbnailError](Errors/GetChapterThumbnailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetChapterThumbnails(double chapterId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every thumbnail associated with the specified saved video chapter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosChapters.GetChapterThumbnails(chapterId, videoId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetChapterThumbnailsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChapterThumbnailsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>chapterId</code> | <code>double</code> | The ID of the chapter. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChapterThumbnailsError](Errors/GetChapterThumbnailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ChapterConnection&gt; GetChapters(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every chapter of the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosChapters.GetChapters(videoId, page, perPage);
    // TODO: Handle 'response' of type ChapterConnection
}
catch (SdkException<GetChaptersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetChaptersError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ChapterConnection](Models/ChapterConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetChaptersError](Errors/GetChaptersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetUnsavedChapterThumbnail(double videoId, string uid, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified thumbnail associated with an unsaved video chapter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosChapters.GetUnsavedChapterThumbnail(videoId, uid);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<GetUnsavedChapterThumbnailError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetUnsavedChapterThumbnailError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>uid</code> | <code>string</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetUnsavedChapterThumbnailError](Errors/GetUnsavedChapterThumbnailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; SetChapterThumbnailActive(double chapterId, double videoId, string uid, VideosChaptersPicturesUidRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method sets the specified chapter thumbnail for a video as active.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosChapters.SetChapterThumbnailActive(chapterId, videoId, uid, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<SetChapterThumbnailActiveError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SetChapterThumbnailActiveError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>chapterId</code> | <code>double</code> | The ID of the chapter. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>uid</code> | <code>string</code> | - |
| <code>body</code> | <code>[VideosChaptersPicturesUidRequest?](Models/VideosChaptersPicturesUidRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SetChapterThumbnailActiveError](Errors/SetChapterThumbnailActiveError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosContentRatings

> Source: [VideosContentRatings](Api/VideosContentRatings.cs)

<details>
<summary><code>Task&lt;ContentRatingConnection&gt; GetContentRatings(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all available content ratings.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosContentRatings.GetContentRatings();
    // TODO: Handle 'response' of type ContentRatingConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ContentRatingConnection](Models/ContentRatingConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosCreativeCommons

> Source: [VideosCreativeCommons](Api/VideosCreativeCommons.cs)

<details>
<summary><code>Task&lt;CreativeCommonsConnection&gt; GetCcLicenses(double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all available Creative Commons licenses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosCreativeCommons.GetCcLicenses(page, perPage);
    // TODO: Handle 'response' of type CreativeCommonsConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreativeCommonsConnection](Models/CreativeCommonsConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosCredits

> Source: [VideosCredits](Api/VideosCredits.cs)

<details>
<summary><code>Task&lt;Credit&gt; AddVideoCredit(double videoId, VideosCreditsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a user credit to the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosCredits.AddVideoCredit(videoId, body);
    // TODO: Handle 'response' of type Credit
}
catch (SdkException<AddVideoCreditError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoCreditError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosCreditsRequest](Models/VideosCreditsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Credit](Models/Credit.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoCreditError](Errors/AddVideoCreditError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Credit&gt; AddVideoCreditAlt1(double channelId, double videoId, ChannelsVideosCreditsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a user credit to the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosCredits.AddVideoCreditAlt1(channelId, videoId, body);
    // TODO: Handle 'response' of type Credit
}
catch (SdkException<AddVideoCreditAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoCreditAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[ChannelsVideosCreditsRequest](Models/ChannelsVideosCreditsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Credit](Models/Credit.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoCreditAlt1Error](Errors/AddVideoCreditAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; AvailableUsers(double videoId, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the users who can be credited on the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosCredits.AvailableUsers(videoId, direction, page, perPage, query, sort);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date followed. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoCredit(double creditId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified user credit from a video. The authenticated user must be the creator of the credit or the credited user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosCredits.DeleteVideoCredit(creditId, videoId);
}
catch (SdkException<DeleteVideoCreditError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoCreditError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>creditId</code> | <code>double</code> | The ID of the credit. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoCreditError](Errors/DeleteVideoCreditError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Credit&gt; EditVideoCredit(double creditId, double videoId, VideosCreditsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified user credit in a video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosCredits.EditVideoCredit(creditId, videoId, body);
    // TODO: Handle 'response' of type Credit
}
catch (SdkException<EditVideoCreditError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditVideoCreditError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>creditId</code> | <code>double</code> | The ID of the credit. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosCreditsRequest1?](Models/VideosCreditsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Credit](Models/Credit.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditVideoCreditError](Errors/EditVideoCreditError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Credit&gt; GetVideoCredit(double creditId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single credited user in a video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosCredits.GetVideoCredit(creditId, videoId);
    // TODO: Handle 'response' of type Credit
}
catch (SdkException<GetVideoCreditError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoCreditError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>creditId</code> | <code>double</code> | The ID of the credit. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Credit](Models/Credit.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoCreditError](Errors/GetVideoCreditError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditConnection&gt; GetVideoCredits(double videoId, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every credited user in a video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosCredits.GetVideoCredits(videoId, direction, page, perPage, query, sort);
    // TODO: Handle 'response' of type CreditConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditConnection](Models/CreditConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditConnection&gt; GetVideoCreditsAlt1(double channelId, double videoId, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every credited user in a video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosCredits.GetVideoCreditsAlt1(channelId,
        videoId,
        direction,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type CreditConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort8?](Models/Enums/Sort8.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `date` - Sort the results by date. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditConnection](Models/CreditConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosEmbedPrivacy

> Source: [VideosEmbedPrivacy](Api/VideosEmbedPrivacy.cs)

<details>
<summary><code>Task AddVideoPrivacyDomain(string domain, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds the specified domain to a video's allowlist.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosEmbedPrivacy.AddVideoPrivacyDomain(domain, videoId);
}
catch (SdkException<AddVideoPrivacyDomainError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoPrivacyDomainError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>domain</code> | <code>string</code> | The domain name. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoPrivacyDomainError](Errors/AddVideoPrivacyDomainError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoPrivacyDomain(string domain, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the specified domain from a video's allowlist.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosEmbedPrivacy.DeleteVideoPrivacyDomain(domain, videoId);
}
catch (SdkException<DeleteVideoPrivacyDomainError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoPrivacyDomainError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>domain</code> | <code>string</code> | The domain name. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoPrivacyDomainError](Errors/DeleteVideoPrivacyDomainError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DomainConnection&gt; GetVideoPrivacyDomains(double videoId, Direction? direction, double? page, double? perPage, Sort78? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every domain on the specified video's allowlist.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEmbedPrivacy.GetVideoPrivacyDomains(videoId, direction, page, perPage, sort);
    // TODO: Handle 'response' of type DomainConnection
}
catch (SdkException<GetVideoPrivacyDomainsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoPrivacyDomainsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort78?](Models/Enums/Sort78.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `default` - Sort the results by the video's allowlist ID. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DomainConnection](Models/DomainConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoPrivacyDomainsError](Errors/GetVideoPrivacyDomainsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosEssentials

> Source: [VideosEssentials](Api/VideosEssentials.cs)

<details>
<summary><code>Task&lt;Video&gt; CheckIfUserOwnsVideo(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the authenticated user is the owner of the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.CheckIfUserOwnsVideo(userId, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<CheckIfUserOwnsVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfUserOwnsVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfUserOwnsVideoError](Errors/CheckIfUserOwnsVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; CheckIfUserOwnsVideoAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the authenticated user is the owner of the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.CheckIfUserOwnsVideoAlt1(videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<CheckIfUserOwnsVideoAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckIfUserOwnsVideoAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckIfUserOwnsVideoAlt1Error](Errors/CheckIfUserOwnsVideoAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; CopyVideo(double userId, double videoId, UsersVideosCopyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a copy of the specified video. Only the source's
current version is copied; prior version history is not carried over.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.CopyVideo(userId, videoId, body);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<CopyVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CopyVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[UsersVideosCopyRequest?](Models/UsersVideosCopyRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CopyVideoError](Errors/CopyVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; CopyVideoAlt2(double videoId, MeVideosCopyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a copy of the specified video. Only the source's
current version is copied; prior version history is not carried over.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.CopyVideoAlt2(videoId, body);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<CopyVideoAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CopyVideoAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[MeVideosCopyRequest?](Models/MeVideosCopyRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CopyVideoAlt2Error](Errors/CopyVideoAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideo(double videoId, VideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosEssentials.DeleteVideo(videoId, body);
}
catch (SdkException<DeleteVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosRequest?](Models/VideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoError](Errors/DeleteVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideos(double userId, string uris, UsersVideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes one or more videos belonging to the specified user. The authenticated user must have permission to delete the videos.

Specify the videos to delete in a comma-separated list by URI using the **uris** query parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosEssentials.DeleteVideos(userId, uris, body);
}
catch (SdkException<DeleteVideosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>uris</code> | <code>string</code> | A comma-separated list of the video URIs to delete. |
| <code>body</code> | <code>[UsersVideosRequest?](Models/UsersVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideosError](Errors/DeleteVideosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideosAlt1(string uris, MeVideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes one or more videos belonging to the specified user. The authenticated user must have permission to delete the videos.

Specify the videos to delete in a comma-separated list by URI using the **uris** query parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosEssentials.DeleteVideosAlt1(uris, body);
}
catch (SdkException<DeleteVideosAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideosAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>uris</code> | <code>string</code> | A comma-separated list of the video URIs to delete. |
| <code>body</code> | <code>[MeVideosRequest?](Models/MeVideosRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideosAlt1Error](Errors/DeleteVideosAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; EditVideo(double videoId, VideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.EditVideo(videoId, body);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<EditVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosRequest1](Models/VideosRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditVideoError](Errors/EditVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetAppearances(double userId, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the videos in which the authenticated user has a credited appearance.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.GetAppearances(userId,
        direction,
        filter,
        filterEmbeddable,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetAppearancesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAppearancesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort15?](Models/Enums/Sort15.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by date.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAppearancesError](Errors/GetAppearancesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetAppearancesAlt1(Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the videos in which the authenticated user has a credited appearance.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.GetAppearancesAlt1(direction,
        filter,
        filterEmbeddable,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetAppearancesAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAppearancesAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort15?](Models/Enums/Sort15.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by date.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAppearancesAlt1Error](Errors/GetAppearancesAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; GetVideo(double videoId, bool? timeLinks, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.GetVideo(videoId, timeLinks);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<GetVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>timeLinks</code> | <code>bool?</code> | Whether to return timestamps in the description as links. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoError](Errors/GetVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetVideos(double userId, string? containingUri, Direction? direction, Filter22? filter, bool? filterEmbeddable, bool? filterPlayable, bool? filterScreenRecorded, string? filterTag, string? filterTagAllOf, string? filterTagExclude, double? filterUploader, double? page, double? perPage, string? query, QueryFields? queryFields, Sort39? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the videos that the authenticated user has uploaded.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.GetVideos(userId,
        containingUri,
        direction,
        filter,
        filterEmbeddable,
        filterPlayable,
        filterScreenRecorded,
        filterTag,
        filterTagAllOf,
        filterTagExclude,
        filterUploader,
        page,
        perPage,
        query,
        queryFields,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>containingUri</code> | <code>string?</code> | The page that contains the video URI. The field is available only when not paired with **query**. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter22?](Models/Enums/Filter22.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `app_only` - Return app-only videos.<br> * `cold_privacy` - Return the owner's active videos whose privacy is suppressed because their plan no longer supports it (cold privacy).<br> * `cold_storage` - Return cold storage videos.<br> * `embeddable` - Return embeddable videos.<br> * `featured` - Return featured videos.<br> * `live` - Return only live videos.<br> * `no_placeholder` - Return no placeholder videos.<br> * `nolive` - Return no live videos.<br> * `playable` - Return playable videos.<br> * `screen_recorded` - Return screen-recorded videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>filterPlayable</code> | <code>bool?</code> | Whether to filter the results by playable videos (`true`) or non-playable videos (`false`). |
| <code>filterScreenRecorded</code> | <code>bool?</code> | Whether to filter the results by screen-recorded videos (`true`) or non-screen-recorded videos (`false`). |
| <code>filterTag</code> | <code>string?</code> | A comma-separated list of tags to filter on. All results must include at least one of these tags. |
| <code>filterTagAllOf</code> | <code>string?</code> | A comma-separated list of tags to filter on. All results must include all of these tags. |
| <code>filterTagExclude</code> | <code>string?</code> | A comma-separated list of tags to exclude. All results must exclude all of these tags. |
| <code>filterUploader</code> | <code>double?</code> | The ID of the team member or team owner uploader to filter for. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>queryFields</code> | <code>[QueryFields?](Models/Enums/QueryFields.cs)</code> | A comma-separated list of fields to query over. The default value is `title,description,chapters,tags`.<br><br>Option descriptions:<br> * `chapters` - Query by chapter titles that have been added to the video.<br> * `description` - Query by the description of the video.<br> * `tags` - Query by tag names that have been added to the video.<br> * `title` - Query by the title of the video. |
| <code>sort</code> | <code>[Sort39?](Models/Enums/Sort39.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically by title.<br> * `date` - Sort the results by date.<br> * `default` - Use the default sorting method.<br> * `duration` - Sort the results by duration.<br> * `last_user_action_event_date` - Sort the results by last user interaction. If a result hasn't had an interaction, the upload date is used instead.<br> * `likes` - Sort the results by number of likes. To use this option, **direction** must be `desc`.<br> * `modified_time` - Sort the results by last modification.<br> * `plays` - Sort the results by number of plays. To use this option, **direction** must be `desc`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetVideosAlt1(string? containingUri, Direction? direction, Filter22? filter, bool? filterEmbeddable, bool? filterPlayable, bool? filterScreenRecorded, string? filterTag, string? filterTagAllOf, string? filterTagExclude, double? filterUploader, double? page, double? perPage, string? query, QueryFields? queryFields, Sort39? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the videos that the authenticated user has uploaded.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.GetVideosAlt1(containingUri,
        direction,
        filter,
        filterEmbeddable,
        filterPlayable,
        filterScreenRecorded,
        filterTag,
        filterTagAllOf,
        filterTagExclude,
        filterUploader,
        page,
        perPage,
        query,
        queryFields,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>containingUri</code> | <code>string?</code> | The page that contains the video URI. The field is available only when not paired with **query**. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter22?](Models/Enums/Filter22.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `app_only` - Return app-only videos.<br> * `cold_privacy` - Return the owner's active videos whose privacy is suppressed because their plan no longer supports it (cold privacy).<br> * `cold_storage` - Return cold storage videos.<br> * `embeddable` - Return embeddable videos.<br> * `featured` - Return featured videos.<br> * `live` - Return only live videos.<br> * `no_placeholder` - Return no placeholder videos.<br> * `nolive` - Return no live videos.<br> * `playable` - Return playable videos.<br> * `screen_recorded` - Return screen-recorded videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>filterPlayable</code> | <code>bool?</code> | Whether to filter the results by playable videos (`true`) or non-playable videos (`false`). |
| <code>filterScreenRecorded</code> | <code>bool?</code> | Whether to filter the results by screen-recorded videos (`true`) or non-screen-recorded videos (`false`). |
| <code>filterTag</code> | <code>string?</code> | A comma-separated list of tags to filter on. All results must include at least one of these tags. |
| <code>filterTagAllOf</code> | <code>string?</code> | A comma-separated list of tags to filter on. All results must include all of these tags. |
| <code>filterTagExclude</code> | <code>string?</code> | A comma-separated list of tags to exclude. All results must exclude all of these tags. |
| <code>filterUploader</code> | <code>double?</code> | The ID of the team member or team owner uploader to filter for. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>queryFields</code> | <code>[QueryFields?](Models/Enums/QueryFields.cs)</code> | A comma-separated list of fields to query over. The default value is `title,description,chapters,tags`.<br><br>Option descriptions:<br> * `chapters` - Query by chapter titles that have been added to the video.<br> * `description` - Query by the description of the video.<br> * `tags` - Query by tag names that have been added to the video.<br> * `title` - Query by the title of the video. |
| <code>sort</code> | <code>[Sort39?](Models/Enums/Sort39.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically by title.<br> * `date` - Sort the results by date.<br> * `default` - Use the default sorting method.<br> * `duration` - Sort the results by duration.<br> * `last_user_action_event_date` - Sort the results by last user interaction. If a result hasn't had an interaction, the upload date is used instead.<br> * `likes` - Sort the results by number of likes. To use this option, **direction** must be `desc`.<br> * `modified_time` - Sort the results by last modification.<br> * `plays` - Sort the results by number of plays. To use this option, **direction** must be `desc`. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; SearchVideos(Direction? direction, Filter45? filter, string? links, double? page, double? perPage, string? query, Sort73? sort, string? uris, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the videos that match custom search criteria.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.SearchVideos(direction,
        filter,
        links,
        page,
        perPage,
        query,
        sort,
        uris);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<SearchVideosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type SearchVideosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter45?](Models/Enums/Filter45.cs)</code> | The attribute by which to filter the results. `CC` and related filters target videos with the corresponding Creative Commons licenses. For more information, see our [Creative Commons](https://vimeo.com/creativecommons) page.<br><br>Option descriptions:<br> * `CC` - Return videos under any Creative Commons license.<br> * `CC-BY` - Return CC BY, or attribution-only, videos.<br> * `CC-BY-NC` - Return CC BY-NC, or Attribution-NonCommercial, videos.<br> * `CC-BY-NC-ND` - Return CC BY-NC-ND, or Attribution-NonCommercial-NoDerivs, videos.<br> * `CC-BY-NC-SA` - Return CC BY-NC-SA, or Attribution-NonCommercial-ShareAlike, videos.<br> * `CC-BY-ND` - Return CC BY-ND, or Attribution-NoDerivs, videos.<br> * `CC-BY-SA` - Return CC BY-SA, or Attribution-ShareAlike, videos.<br> * `CC0` - Return CC0, or public domain, videos.<br> * `categories` - Filter by categories.<br> * `duration` - Filter by duration.<br> * `in-progress` - Return in-progress videos.<br> * `minimum_likes` - Filter by minimum likes.<br> * `trending` - Return trending videos.<br> * `upload_date` - Filter by upload date. |
| <code>links</code> | <code>string?</code> | A comma-separated list of video URLs to find. Querying, filtering, and sorting aren't supported when using this field. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query. |
| <code>sort</code> | <code>[Sort73?](Models/Enums/Sort73.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by date.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays.<br> * `relevant` - Sort the results by relevance. |
| <code>uris</code> | <code>string?</code> | A comma-separated list of video URIs to find. Querying, filtering, and sorting aren't supported when using this field. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SearchVideosError](Errors/SearchVideosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CustomMetadataValues&gt;&gt; UpdateVideoCustomMetadata(double videoId, VideosCustomMetadataRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method sets, updates, or clears custom metadata values on a single video.

The authenticated user must own the video or have team permission to edit it.

Send each value as a `{field_id, field_value}` pair under the `fields` array.
The value's data type is validated against the field's definition (set via
`POST /teams/{user_id}/custom_metadata`):

| Type           | Accepted format                                         |
| -------------- | ------------------------------------------------------- |
| `str`          | A non-empty string of up to 50 characters               |
| `int`          | An integer, optionally negative (for example, `42`)     |
| `date`         | `YYYY-MM-DD`                                            |
| `bool`         | `"true"`, `"false"`, `"1"`, or `"0"`                    |
| `select`       | One of the values defined for the field                 |
| `multi-select` | A JSON-encoded array of allowed values                  |

To clear an existing value, send `field_value: null`. The field will return to
its default value (if one is defined) or become unset.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosEssentials.UpdateVideoCustomMetadata(videoId, body);
    // TODO: Handle 'response' of type IReadOnlyList<CustomMetadataValues>
}
catch (SdkException<UpdateVideoCustomMetadataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UpdateVideoCustomMetadataError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosCustomMetadataRequest?](Models/VideosCustomMetadataRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CustomMetadataValues](Models/CustomMetadataValues.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateVideoCustomMetadataError](Errors/UpdateVideoCustomMetadataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosFragments

> Source: [VideosFragments](Api/VideosFragments.cs)

<details>
<summary><code>Task DeleteFragments(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes all fragments for the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosFragments.DeleteFragments(videoId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Fragments&gt; GetFragments(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all of the fragments associated with the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosFragments.GetFragments(videoId);
    // TODO: Handle 'response' of type Fragments
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Fragments](Models/Fragments.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PutFragments(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method updates the specified video with new fragments.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosFragments.PutFragments(videoId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosLanguages

> Source: [VideosLanguages](Api/VideosLanguages.cs)

<details>
<summary><code>Task&lt;LanguageConnection&gt; GetLanguages(Filter7? filter, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all available video languages.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosLanguages.GetLanguages(filter, page, perPage);
    // TODO: Handle 'response' of type LanguageConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>filter</code> | <code>[Filter7?](Models/Enums/Filter7.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `audiotracks` - Return languages that can be used for audio tracks.<br> * `texttracks` - Return languages that can be used for text tracks. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LanguageConnection](Models/LanguageConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosLiveM3U8Playback

> Source: [VideosLiveM3U8Playback](Api/VideosLiveM3U8Playback.cs)

<details>
<summary><code>Task GetOneTimeEventM3U8Playback(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns an M3U8 playback URL for the specified event stream. You should use this endpoint only in conjunction with our recommended procedure for playing events via HLS. For more information, see our [HLS guide](https://developer.vimeo.com/api/live/playback).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosLiveM3U8Playback.GetOneTimeEventM3U8Playback(userId, videoId);
}
catch (SdkException<GetOneTimeEventM3U8PlaybackError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetOneTimeEventM3U8PlaybackError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetOneTimeEventM3U8PlaybackError](Errors/GetOneTimeEventM3U8PlaybackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetOneTimeEventM3U8PlaybackAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns an M3U8 playback URL for the specified event stream. You should use this endpoint only in conjunction with our recommended procedure for playing events via HLS. For more information, see our [HLS guide](https://developer.vimeo.com/api/live/playback).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosLiveM3U8Playback.GetOneTimeEventM3U8PlaybackAlt1(videoId);
}
catch (SdkException<GetOneTimeEventM3U8PlaybackAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetOneTimeEventM3U8PlaybackAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetOneTimeEventM3U8PlaybackAlt1Error](Errors/GetOneTimeEventM3U8PlaybackAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosModeration

> Source: [VideosModeration](Api/VideosModeration.cs)

<details>
<summary><code>Task&lt;VideoReportReason&gt; GetVideoReportingReasons(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a list of valid reasons for reporting inappropriate videos on Vimeo.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosModeration.GetVideoReportingReasons();
    // TODO: Handle 'response' of type VideoReportReason
}
catch (SdkException<GetVideoReportingReasonsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoReportingReasonsError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoReportReason](Models/VideoReportReason.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoReportingReasonsError](Errors/GetVideoReportingReasonsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosNondestructiveTrimming

> Source: [VideosNondestructiveTrimming](Api/VideosNondestructiveTrimming.cs)

<details>
<summary><code>Task&lt;TrimmedVideo&gt; ClipTrim(double videoId, VideosTrimRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method starts a trim operation for the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosNondestructiveTrimming.ClipTrim(videoId, body);
    // TODO: Handle 'response' of type TrimmedVideo
}
catch (SdkException<ClipTrimError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type ClipTrimError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosTrimRequest?](Models/VideosTrimRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TrimmedVideo](Models/TrimmedVideo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClipTrimError](Errors/ClipTrimError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosRecommendations

> Source: [VideosRecommendations](Api/VideosRecommendations.cs)

<details>
<summary><code>Task&lt;VideoConnection&gt; GetRelatedVideos(double videoId, Filter46? filter, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every related video of the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosRecommendations.GetRelatedVideos(videoId, filter, page, perPage);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetRelatedVideosError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetRelatedVideosError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>filter</code> | <code>[Filter46?](Models/Enums/Filter46.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `related` - Return related videos. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetRelatedVideosError](Errors/GetRelatedVideosError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosShowcases

> Source: [VideosShowcases](Api/VideosShowcases.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Album&gt;&gt; AddOrRemoveMultipleAlbums(double videoId, VideosAlbumsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds or removes the specified video to or from multiple showcases.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosShowcases.AddOrRemoveMultipleAlbums(videoId, body);
    // TODO: Handle 'response' of type IReadOnlyList<Album>
}
catch (SdkException<AddOrRemoveMultipleAlbumsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddOrRemoveMultipleAlbumsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosAlbumsRequest?](Models/VideosAlbumsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Album](Models/Album.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddOrRemoveMultipleAlbumsError](Errors/AddOrRemoveMultipleAlbumsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlbumConnection&gt; GetVideoAlbums(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the showcases that contain the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosShowcases.GetVideoAlbums(videoId, page, perPage);
    // TODO: Handle 'response' of type AlbumConnection
}
catch (SdkException<GetVideoAlbumsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoAlbumsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlbumConnection](Models/AlbumConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoAlbumsError](Errors/GetVideoAlbumsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosTags

> Source: [VideosTags](Api/VideosTags.cs)

<details>
<summary><code>Task&lt;Tag&gt; AddVideoTag(double videoId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a single tag to the specified video. The authenticated user must have edit access to the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTags.AddVideoTag(videoId, word);
    // TODO: Handle 'response' of type Tag
}
catch (SdkException<AddVideoTagError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoTagError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>word</code> | <code>string</code> | The tag word. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Tag](Models/Tag.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoTagError](Errors/AddVideoTagError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Tag&gt;&gt; AddVideoTags(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds multiple tags to the specified video. Include the tags as a JSON array  as the body of the request with the  **name** field, like this: `[{ "name": "funny"}, {"name": "concert" }]`. The authenticated user must have edit access to the video. For more information on batch requests like this one, see [Using Common Formats and Parameters](https://developer.vimeo.com/api/common-formats#working-with-batch-requests).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTags.AddVideoTags(videoId, page, perPage);
    // TODO: Handle 'response' of type IReadOnlyList<Tag>
}
catch (SdkException<AddVideoTagsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoTagsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Tag](Models/Tag.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoTagsError](Errors/AddVideoTagsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Tag&gt; CheckVideoForTag(double videoId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method determines whether the specified tag has been added to a video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTags.CheckVideoForTag(videoId, word);
    // TODO: Handle 'response' of type Tag
}
catch (SdkException<CheckVideoForTagError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckVideoForTagError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>word</code> | <code>string</code> | The tag word. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Tag](Models/Tag.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckVideoForTagError](Errors/CheckVideoForTagError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoTag(double videoId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the specified tag from a video. The authenticated user must have edit access to the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosTags.DeleteVideoTag(videoId, word);
}
catch (SdkException<DeleteVideoTagError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoTagError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>word</code> | <code>string</code> | The tag word. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoTagError](Errors/DeleteVideoTagError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TagConnection&gt; GetVideoTags(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the tags associated with the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTags.GetVideoTags(videoId, page, perPage);
    // TODO: Handle 'response' of type TagConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TagConnection](Models/TagConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetVideosWithTag(string word, Direction? direction, double? page, double? perPage, Sort47? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all the public videos associated with the specified tag.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTags.GetVideosWithTag(word, direction, page, perPage, sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<GetVideosWithTagError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideosWithTagError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>word</code> | <code>string</code> | The tag word. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>sort</code> | <code>[Sort47?](Models/Enums/Sort47.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `created_time` - Sort the results by creation time.<br> * `duration` - Sort the results by duration.<br> * `name` - Sort the results by name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideosWithTagError](Errors/GetVideosWithTagError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosTextTracks

> Source: [VideosTextTracks](Api/VideosTextTracks.cs)

<details>
<summary><code>Task&lt;TextTrack&gt; CreateTextTrack(double videoId, VideosTexttracksRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a text track to the specified video. For more information, see [Working with Text Track Uploads](https://developer.vimeo.com/api/upload/texttracks).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTextTracks.CreateTextTrack(videoId, body);
    // TODO: Handle 'response' of type TextTrack
}
catch (SdkException<CreateTextTrackError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateTextTrackError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosTexttracksRequest](Models/VideosTexttracksRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TextTrack](Models/TextTrack.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateTextTrackError](Errors/CreateTextTrackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TextTrack&gt; CreateTextTrackAlt1(double channelId, double videoId, ChannelsVideosTexttracksRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a text track to the specified video. For more information, see [Working with Text Track Uploads](https://developer.vimeo.com/api/upload/texttracks).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTextTracks.CreateTextTrackAlt1(channelId, videoId, body);
    // TODO: Handle 'response' of type TextTrack
}
catch (SdkException<CreateTextTrackAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateTextTrackAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[ChannelsVideosTexttracksRequest](Models/ChannelsVideosTexttracksRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TextTrack](Models/TextTrack.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateTextTrackAlt1Error](Errors/CreateTextTrackAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteTextTrack(double texttrackId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified text track from a video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosTextTracks.DeleteTextTrack(texttrackId, videoId);
}
catch (SdkException<DeleteTextTrackError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteTextTrackError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>texttrackId</code> | <code>double</code> | The ID of the text track. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteTextTrackError](Errors/DeleteTextTrackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TextTrack&gt; EditTextTrack(double texttrackId, double videoId, VideosTexttracksRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified text track of a video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTextTracks.EditTextTrack(texttrackId, videoId, body);
    // TODO: Handle 'response' of type TextTrack
}
catch (SdkException<EditTextTrackError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditTextTrackError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>texttrackId</code> | <code>double</code> | The ID of the text track. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosTexttracksRequest1?](Models/VideosTexttracksRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TextTrack](Models/TextTrack.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditTextTrackError](Errors/EditTextTrackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TextTrack&gt; GetTextTrack(double texttrackId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single text track of the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTextTracks.GetTextTrack(texttrackId, videoId);
    // TODO: Handle 'response' of type TextTrack
}
catch (SdkException<GetTextTrackError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetTextTrackError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>texttrackId</code> | <code>double</code> | The ID of the text track. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TextTrack](Models/TextTrack.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTextTrackError](Errors/GetTextTrackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TextTrackConnection&gt; GetTextTracks(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every text track of the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTextTracks.GetTextTracks(videoId, page, perPage);
    // TODO: Handle 'response' of type TextTrackConnection
}
catch (SdkException<GetTextTracksError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetTextTracksError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TextTrackConnection](Models/TextTrackConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTextTracksError](Errors/GetTextTracksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TextTrackConnection&gt; GetTextTracksAlt1(double videoId, string versionId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every text track of the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTextTracks.GetTextTracksAlt1(videoId, versionId, page, perPage);
    // TODO: Handle 'response' of type TextTrackConnection
}
catch (SdkException<GetTextTracksAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetTextTracksAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>versionId</code> | <code>string</code> | - |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TextTrackConnection](Models/TextTrackConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTextTracksAlt1Error](Errors/GetTextTracksAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TextTrackConnection&gt; GetTextTracksAlt2(double channelId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every text track of the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTextTracks.GetTextTracksAlt2(channelId, videoId, page, perPage);
    // TODO: Handle 'response' of type TextTrackConnection
}
catch (SdkException<GetTextTracksAlt2Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetTextTracksAlt2Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TextTrackConnection](Models/TextTrackConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTextTracksAlt2Error](Errors/GetTextTracksAlt2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TextTrackConnection&gt; GetTextTracksAlt3(double albumId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every text track of the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTextTracks.GetTextTracksAlt3(albumId, videoId, page, perPage);
    // TODO: Handle 'response' of type TextTrackConnection
}
catch (SdkException<GetTextTracksAlt3Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetTextTracksAlt3Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>albumId</code> | <code>double</code> | The ID of the showcase. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TextTrackConnection](Models/TextTrackConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTextTracksAlt3Error](Errors/GetTextTracksAlt3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosThumbnails

> Source: [VideosThumbnails](Api/VideosThumbnails.cs)

<details>
<summary><code>Task&lt;Picture&gt; CreateVideoThumbnail(double videoId, VideosPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a thumbnail image to the specified video. The authenticated user must have team permissions for the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosThumbnails.CreateVideoThumbnail(videoId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosPicturesRequest?](Models/VideosPicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; CreateVideoThumbnailAlt1(double channelId, double videoId, ChannelsVideosPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a thumbnail image to the specified video. The authenticated user must have team permissions for the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosThumbnails.CreateVideoThumbnailAlt1(channelId, videoId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[ChannelsVideosPicturesRequest?](Models/ChannelsVideosPicturesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoThumbnail(double pictureId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified thumbnail image from a video. The authenticated user must have team permissions for the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosThumbnails.DeleteVideoThumbnail(pictureId, videoId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>pictureId</code> | <code>double</code> | The ID of the thumbnail. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; EditVideoThumbnail(double pictureId, double videoId, VideosPicturesRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified video thumbnail image. The authenticated user must be the owner of the thumbnail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosThumbnails.EditVideoThumbnail(pictureId, videoId, body);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>pictureId</code> | <code>double</code> | The ID of the thumbnail. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosPicturesRequest1?](Models/VideosPicturesRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetVideoThumbnail(double pictureId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single thumbnail image from the specified video. The authenticated user must have team permissions for the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosThumbnails.GetVideoThumbnail(pictureId, videoId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>pictureId</code> | <code>double</code> | The ID of the thumbnail. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetVideoThumbnails(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all thumbnail images of the specified video. The authenticated user must have team permissions for the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosThumbnails.GetVideoThumbnails(videoId, page, perPage);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PictureConnection&gt; GetVideoThumbnailsAlt1(double channelId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all thumbnail images of the specified video. The authenticated user must have team permissions for the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosThumbnails.GetVideoThumbnailsAlt1(channelId, videoId, page, perPage);
    // TODO: Handle 'response' of type PictureConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PictureConnection](Models/PictureConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosTranscripts

> Source: [VideosTranscripts](Api/VideosTranscripts.cs)

<details>
<summary><code>Task&lt;SegmentConnection&gt; GetTranscript(double texttrackId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the transcript segments of the specified text track.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTranscripts.GetTranscript(texttrackId, videoId);
    // TODO: Handle 'response' of type SegmentConnection
}
catch (SdkException<GetTranscriptError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetTranscriptError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>texttrackId</code> | <code>double</code> | The ID of the text track. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SegmentConnection](Models/SegmentConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTranscriptError](Errors/GetTranscriptError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TranscriptMetadata&gt; GetTranscriptMetadata(string containerUuid, double texttrackId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the transcript metadata of the specified text track.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosTranscripts.GetTranscriptMetadata(containerUuid, texttrackId);
    // TODO: Handle 'response' of type TranscriptMetadata
}
catch (SdkException<GetTranscriptMetadataError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetTranscriptMetadataError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>containerUuid</code> | <code>string</code> | The UUID of the video container. |
| <code>texttrackId</code> | <code>double</code> | The ID of the text track. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TranscriptMetadata](Models/TranscriptMetadata.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTranscriptMetadataError](Errors/GetTranscriptMetadataError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosUnlistedVideos

> Source: [VideosUnlistedVideos](Api/VideosUnlistedVideos.cs)

<details>
<summary><code>Task&lt;User&gt; AddVideoPrivacyUser(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method gives a single user permission to access the specified unlisted video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosUnlistedVideos.AddVideoPrivacyUser(userId, videoId);
    // TODO: Handle 'response' of type User
}
catch (SdkException<AddVideoPrivacyUserError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type AddVideoPrivacyUserError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[User](Models/User.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddVideoPrivacyUserError](Errors/AddVideoPrivacyUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;User&gt;&gt; AddVideoPrivacyUsers(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method gives multiple users permission to access the specified unlisted video. The authenticated user must be the owner of the video. The body of the request should follow our [batch request format](https://developer.vimeo.com/api/common-formats#working-with-batch-requests): each object must contain a single **uri** field whose value is the URI of the user who can access the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosUnlistedVideos.AddVideoPrivacyUsers(videoId);
    // TODO: Handle 'response' of type IReadOnlyList<User>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[User](Models/User.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;User&gt;&gt; AddVideoPrivacyUsersAlt1(double channelId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method gives multiple users permission to access the specified unlisted video. The authenticated user must be the owner of the video. The body of the request should follow our [batch request format](https://developer.vimeo.com/api/common-formats#working-with-batch-requests): each object must contain a single **uri** field whose value is the URI of the user who can access the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosUnlistedVideos.AddVideoPrivacyUsersAlt1(channelId, videoId);
    // TODO: Handle 'response' of type IReadOnlyList<User>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[User](Models/User.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoPrivacyUser(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method prevents a user from being able to view the specified unlisted video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosUnlistedVideos.DeleteVideoPrivacyUser(userId, videoId);
}
catch (SdkException<DeleteVideoPrivacyUserError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoPrivacyUserError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoPrivacyUserError](Errors/DeleteVideoPrivacyUserError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetVideoPrivacyUsers(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every user who has access to the specified unlisted video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosUnlistedVideos.GetVideoPrivacyUsers(videoId, page, perPage);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<GetVideoPrivacyUsersError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoPrivacyUsersError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoPrivacyUsersError](Errors/GetVideoPrivacyUsersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserConnection&gt; GetVideoPrivacyUsersAlt1(double channelId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every user who has access to the specified unlisted video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosUnlistedVideos.GetVideoPrivacyUsersAlt1(channelId, videoId, page, perPage);
    // TODO: Handle 'response' of type UserConnection
}
catch (SdkException<GetVideoPrivacyUsersAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoPrivacyUsersAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserConnection](Models/UserConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoPrivacyUsersAlt1Error](Errors/GetVideoPrivacyUsersAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosUploads

> Source: [VideosUploads](Api/VideosUploads.cs)

<details>
<summary><code>Task CompleteStreamingUpload(double uploadId, double userId, string signature, double videoFileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method completes the specified streaming upload of the authenticated user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosUploads.CompleteStreamingUpload(uploadId, userId, signature, videoFileId);
}
catch (SdkException<CompleteStreamingUploadError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CompleteStreamingUploadError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>uploadId</code> | <code>double</code> | The ID of the streaming upload. |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>signature</code> | <code>string</code> | The crypto signature of the completed upload. |
| <code>videoFileId</code> | <code>double</code> | The ID of the uploaded file. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CompleteStreamingUploadError](Errors/CompleteStreamingUploadError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UploadAttempt&gt; GetUploadAttempt(double uploadId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified upload attempt of the authenticated user. _This method has been deprecated. For information on our currently supported upload approaches, see our [Working with Video Uploads](https://developer.vimeo.com/api/upload/videos) guide._

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosUploads.GetUploadAttempt(uploadId, userId);
    // TODO: Handle 'response' of type UploadAttempt
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>uploadId</code> | <code>double</code> | The ID of the upload attempt. |
| <code>userId</code> | <code>double</code> | The ID of the user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UploadAttempt](Models/UploadAttempt.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; UploadVideo(double userId, UsersVideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method begins the video upload process for the authenticated user. For more information, see our [upload documentation](https://developer.vimeo.com/api/upload/videos).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosUploads.UploadVideo(userId, body);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<UploadVideoError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UploadVideoError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>body</code> | <code>[UsersVideosRequest1](Models/UsersVideosRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UploadVideoError](Errors/UploadVideoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; UploadVideoAlt1(MeVideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method begins the video upload process for the authenticated user. For more information, see our [upload documentation](https://developer.vimeo.com/api/upload/videos).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosUploads.UploadVideoAlt1(body);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<UploadVideoAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type UploadVideoAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[MeVideosRequest1](Models/MeVideosRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UploadVideoAlt1Error](Errors/UploadVideoAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosVersions

> Source: [VideosVersions](Api/VideosVersions.cs)

<details>
<summary><code>Task&lt;AlternateAudioTrack&gt; CreateAudioTrack(double versionId, double videoId, VideosVersionsAudiotracksRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method creates a new audio track for a video version.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVersions.CreateAudioTrack(versionId, videoId, body);
    // TODO: Handle 'response' of type AlternateAudioTrack
}
catch (SdkException<CreateAudioTrackError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateAudioTrackError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>versionId</code> | <code>double</code> | The ID of the video version. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosVersionsAudiotracksRequest](Models/VideosVersionsAudiotracksRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlternateAudioTrack](Models/AlternateAudioTrack.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateAudioTrackError](Errors/CreateAudioTrackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoVersion&gt; CreateVideoVersion(double videoId, VideosVersionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a version to the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVersions.CreateVideoVersion(videoId, body);
    // TODO: Handle 'response' of type VideoVersion
}
catch (SdkException<CreateVideoVersionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateVideoVersionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosVersionsRequest](Models/VideosVersionsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoVersion](Models/VideoVersion.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateVideoVersionError](Errors/CreateVideoVersionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteAudioTrack(string audiotrackId, double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes an audio track from the specified video version.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosVersions.DeleteAudioTrack(audiotrackId, versionId, videoId);
}
catch (SdkException<DeleteAudioTrackError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteAudioTrackError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>audiotrackId</code> | <code>string</code> | The ID of the audio track. |
| <code>versionId</code> | <code>double</code> | The ID of the video version. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteAudioTrackError](Errors/DeleteAudioTrackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoVersion(double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified version from a video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosVersions.DeleteVideoVersion(versionId, videoId);
}
catch (SdkException<DeleteVideoVersionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteVideoVersionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>versionId</code> | <code>double</code> | The ID of the video version. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteVideoVersionError](Errors/DeleteVideoVersionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlternateAudioTrack&gt; EditAudioTrack(string audiotrackId, double versionId, double videoId, VideosVersionsAudiotracksAudiotrackIdRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the metadata for the specified audio track.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVersions.EditAudioTrack(audiotrackId, versionId, videoId, body);
    // TODO: Handle 'response' of type AlternateAudioTrack
}
catch (SdkException<EditAudioTrackError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditAudioTrackError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>audiotrackId</code> | <code>string</code> | The ID of the audio track. |
| <code>versionId</code> | <code>double</code> | The ID of the video version. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosVersionsAudiotracksAudiotrackIdRequest?](Models/VideosVersionsAudiotracksAudiotrackIdRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlternateAudioTrack](Models/AlternateAudioTrack.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditAudioTrackError](Errors/EditAudioTrackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoVersion&gt; EditVideoVersion(double versionId, double videoId, VideosVersionsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified version of a video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVersions.EditVideoVersion(versionId, videoId, body);
    // TODO: Handle 'response' of type VideoVersion
}
catch (SdkException<EditVideoVersionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditVideoVersionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>versionId</code> | <code>double</code> | The ID of the video version. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosVersionsRequest1?](Models/VideosVersionsRequest1.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoVersion](Models/VideoVersion.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditVideoVersionError](Errors/EditVideoVersionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlternateAudioTrack&gt; GetAudioTrack(string audiotrackId, double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified audio track that is associated with a video version.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVersions.GetAudioTrack(audiotrackId, versionId, videoId);
    // TODO: Handle 'response' of type AlternateAudioTrack
}
catch (SdkException<GetAudioTrackError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAudioTrackError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>audiotrackId</code> | <code>string</code> | The ID of the audio track. |
| <code>versionId</code> | <code>double</code> | The ID of the video version. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlternateAudioTrack](Models/AlternateAudioTrack.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAudioTrackError](Errors/GetAudioTrackError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AlternateAudioTrackConnection&gt; GetAudioTracks(double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns all audio tracks that are associated with the specified video version.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVersions.GetAudioTracks(versionId, videoId);
    // TODO: Handle 'response' of type AlternateAudioTrackConnection
}
catch (SdkException<GetAudioTracksError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetAudioTracksError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>versionId</code> | <code>double</code> | The ID of the video version. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AlternateAudioTrackConnection](Models/AlternateAudioTrackConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAudioTracksError](Errors/GetAudioTracksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetAudiotrackDownloads(double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a list of downloadable file links for a version of a video that contains the specified alternate audio track.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosVersions.GetAudiotrackDownloads(versionId, videoId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>versionId</code> | <code>double</code> | The ID of the video version. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Picture&gt; GetVersionThumbnail(double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the thumbnail associated with the specified version of a video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVersions.GetVersionThumbnail(versionId, videoId);
    // TODO: Handle 'response' of type Picture
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>versionId</code> | <code>double</code> | The ID of the version. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Picture](Models/Picture.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoVersion&gt; GetVideoVersion(double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns a single version of the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVersions.GetVideoVersion(versionId, videoId);
    // TODO: Handle 'response' of type VideoVersion
}
catch (SdkException<GetVideoVersionError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoVersionError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>versionId</code> | <code>double</code> | The ID of the video version. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoVersion](Models/VideoVersion.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoVersionError](Errors/GetVideoVersionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoVersionConnection&gt; GetVideoVersions(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every version of the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVersions.GetVideoVersions(videoId, page, perPage);
    // TODO: Handle 'response' of type VideoVersionConnection
}
catch (SdkException<GetVideoVersionsError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoVersionsError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoVersionConnection](Models/VideoVersionConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoVersionsError](Errors/GetVideoVersionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoVersionConnection&gt; GetVideoVersionsAlt1(double channelId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every version of the specified video. The authenticated user must be the owner of the video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVersions.GetVideoVersionsAlt1(channelId, videoId, page, perPage);
    // TODO: Handle 'response' of type VideoVersionConnection
}
catch (SdkException<GetVideoVersionsAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetVideoVersionsAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoVersionConnection](Models/VideoVersionConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetVideoVersionsAlt1Error](Errors/GetVideoVersionsAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VideosVideoComments

> Source: [VideosVideoComments](Api/VideosVideoComments.cs)

<details>
<summary><code>Task&lt;Comment&gt; CreateComment(double videoId, VideosCommentsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a video comment to the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVideoComments.CreateComment(videoId, body);
    // TODO: Handle 'response' of type Comment
}
catch (SdkException<CreateCommentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateCommentError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosCommentsRequest?](Models/VideosCommentsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Comment](Models/Comment.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateCommentError](Errors/CreateCommentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Comment&gt; CreateCommentAlt1(double channelId, double videoId, ChannelsVideosCommentsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a video comment to the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVideoComments.CreateCommentAlt1(channelId, videoId, body);
    // TODO: Handle 'response' of type Comment
}
catch (SdkException<CreateCommentAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateCommentAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[ChannelsVideosCommentsRequest?](Models/ChannelsVideosCommentsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Comment](Models/Comment.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateCommentAlt1Error](Errors/CreateCommentAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Comment&gt; CreateCommentReply(double commentId, double videoId, VideosCommentsRepliesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds a reply to the specified video comment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVideoComments.CreateCommentReply(commentId, videoId, body);
    // TODO: Handle 'response' of type Comment
}
catch (SdkException<CreateCommentReplyError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CreateCommentReplyError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>commentId</code> | <code>double</code> | The ID of the comment. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosCommentsRepliesRequest](Models/VideosCommentsRepliesRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Comment](Models/Comment.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateCommentReplyError](Errors/CreateCommentReplyError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteComment(double commentId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method deletes the specified video comment. The authenticated user must be the owner of the comment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VideosVideoComments.DeleteComment(commentId, videoId);
}
catch (SdkException<DeleteCommentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type DeleteCommentError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>commentId</code> | <code>double</code> | The ID of the comment. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteCommentError](Errors/DeleteCommentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Comment&gt; EditComment(double commentId, double videoId, VideosCommentsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method edits the specified video comment. The authenticated user must be the owner of the comment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVideoComments.EditComment(commentId, videoId, body);
    // TODO: Handle 'response' of type Comment
}
catch (SdkException<EditCommentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type EditCommentError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>commentId</code> | <code>double</code> | The ID of the comment. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>body</code> | <code>[VideosCommentsRequest?](Models/VideosCommentsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Comment](Models/Comment.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[EditCommentError](Errors/EditCommentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Comment&gt; GetComment(double commentId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns the specified video comment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVideoComments.GetComment(commentId, videoId);
    // TODO: Handle 'response' of type Comment
}
catch (SdkException<GetCommentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCommentError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>commentId</code> | <code>double</code> | The ID of the comment. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Comment](Models/Comment.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCommentError](Errors/GetCommentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommentConnection&gt; GetCommentReplies(double commentId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every reply to the specified video comment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVideoComments.GetCommentReplies(commentId, videoId, page, perPage);
    // TODO: Handle 'response' of type CommentConnection
}
catch (SdkException<GetCommentRepliesError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type GetCommentRepliesError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>commentId</code> | <code>double</code> | The ID of the comment. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommentConnection](Models/CommentConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCommentRepliesError](Errors/GetCommentRepliesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommentConnection&gt; GetComments(double videoId, Direction? direction, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video comment on the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVideoComments.GetComments(videoId, direction, page, perPage);
    // TODO: Handle 'response' of type CommentConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommentConnection](Models/CommentConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommentConnection&gt; GetCommentsAlt1(double channelId, double videoId, Direction? direction, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video comment on the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.VideosVideoComments.GetCommentsAlt1(channelId, videoId, direction, page, perPage);
    // TODO: Handle 'response' of type CommentConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>channelId</code> | <code>double</code> | The ID of the channel. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommentConnection](Models/CommentConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## WatchLaterQueueEssentials

> Source: [WatchLaterQueueEssentials](Api/WatchLaterQueueEssentials.cs)

<details>
<summary><code>Task AddVideoToWatchLater(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds the specified video to the authenticated user's Watch Later queue.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.WatchLaterQueueEssentials.AddVideoToWatchLater(userId, videoId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AddVideoToWatchLaterAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method adds the specified video to the authenticated user's Watch Later queue.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.WatchLaterQueueEssentials.AddVideoToWatchLaterAlt1(videoId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; CheckWatchLaterQueue(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method checks the authenticated user's Watch Later queue for the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchLaterQueueEssentials.CheckWatchLaterQueue(userId, videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<CheckWatchLaterQueueError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckWatchLaterQueueError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckWatchLaterQueueError](Errors/CheckWatchLaterQueueError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Video&gt; CheckWatchLaterQueueAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method checks the authenticated user's Watch Later queue for the specified video.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchLaterQueueEssentials.CheckWatchLaterQueueAlt1(videoId);
    // TODO: Handle 'response' of type Video
}
catch (SdkException<CheckWatchLaterQueueAlt1Error> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type CheckWatchLaterQueueAlt1Error
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Video](Models/Video.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckWatchLaterQueueAlt1Error](Errors/CheckWatchLaterQueueAlt1Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoFromWatchLater(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the specified video from the authenticated user's Watch Later queue.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.WatchLaterQueueEssentials.DeleteVideoFromWatchLater(userId, videoId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteVideoFromWatchLaterAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method removes the specified video from the authenticated user's Watch Later queue.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.WatchLaterQueueEssentials.DeleteVideoFromWatchLaterAlt1(videoId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>videoId</code> | <code>double</code> | The ID of the video. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetWatchLaterQueue(double userId, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video from the authenticated user's Watch Later queue.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchLaterQueueEssentials.GetWatchLaterQueue(userId,
        direction,
        filter,
        filterEmbeddable,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>userId</code> | <code>double</code> | The ID of the user. |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort15?](Models/Enums/Sort15.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by date added.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;VideoConnection&gt; GetWatchLaterQueueAlt1(Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This method returns every video from the authenticated user's Watch Later queue.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchLaterQueueEssentials.GetWatchLaterQueueAlt1(direction,
        filter,
        filterEmbeddable,
        page,
        perPage,
        query,
        sort);
    // TODO: Handle 'response' of type VideoConnection
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The sort direction of the results.<br><br>Option descriptions:<br> * `asc` - Sort the results in ascending order.<br> * `desc` - Sort the results in descending order. |
| <code>filter</code> | <code>[Filter3?](Models/Enums/Filter3.cs)</code> | The attribute by which to filter the results.<br><br>Option descriptions:<br> * `embeddable` - Return embeddable videos. |
| <code>filterEmbeddable</code> | <code>bool?</code> | Whether to filter the results by embeddable videos (`true`) or non-embeddable videos (`false`). This parameter is required only when **filter** is `embeddable`. |
| <code>page</code> | <code>double?</code> | The page number of the results to show. |
| <code>perPage</code> | <code>double?</code> | The number of items to show on each page of results, up to a maximum of 100. |
| <code>query</code> | <code>string?</code> | The search query to use to filter the results. |
| <code>sort</code> | <code>[Sort15?](Models/Enums/Sort15.cs)</code> | The way to sort the results.<br><br>Option descriptions:<br> * `alphabetical` - Sort the results alphabetically.<br> * `comments` - Sort the results by number of comments.<br> * `date` - Sort the results by date added.<br> * `duration` - Sort the results by duration.<br> * `likes` - Sort the results by number of likes.<br> * `plays` - Sort the results by number of plays. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[VideoConnection](Models/VideoConnection.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

