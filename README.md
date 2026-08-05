# Vimeo API

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The Vimeo API SDK for .NET provides access to the Vimeo API REST APIs from .NET applications.

Build something great. Vimeo's API supports flexible, high-quality video integration with your custom apps.

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/VimeoApi.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [VimeoApiClientOptions](VimeoApiClientOptions.cs).

```csharp
services.AddVimeoApiClient(options =>
    {
        options.Bearer = "YOUR_BEARER_TOKEN";
        options.Oauth2ClientCredentials =
            new OAuth2ClientCredentials
            {
                ClientId = "YOUR_CLIENT_ID",
                ClientSecret = "YOUR_CLIENT_SECRET",
            };
        options.Oauth2AuthorizationCode =
            new OAuth2AuthorizationCodeCredentials
            {
                ClientId = "YOUR_CLIENT_ID",
                RedirectUri = "YOUR_REDIRECT_URI",
                PromptForAuthorizationCode = authUrl => Task.FromResult(""),
            };
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [VimeoApiClientOptions](VimeoApiClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new VimeoApiClientOptions
    {
        Bearer = "YOUR_BEARER_TOKEN",
        Oauth2ClientCredentials = new OAuth2ClientCredentials
        {
            ClientId = "YOUR_CLIENT_ID",
            ClientSecret = "YOUR_CLIENT_SECRET",
        },
        Oauth2AuthorizationCode = new OAuth2AuthorizationCodeCredentials
        {
            ClientId = "YOUR_CLIENT_ID",
            RedirectUri = "YOUR_REDIRECT_URI",
            PromptForAuthorizationCode = authUrl => Task.FromResult(""),
        },
        Environment = ServerEnvironment.Production,
    };
var client = new VimeoApiClient(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## Best Practices

> [!TIP]
> Use a **single `VimeoApiClient` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
