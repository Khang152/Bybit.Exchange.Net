 [nuget-url]: https://www.nuget.org/packages/Bybit.Exchange.Net
 [source-url]: https://github.com/Khang152/Bybit.Exchange.Net
 [license-url]: https://raw.githubusercontent.com/Khang152/Bybit.Exchange.Net/develop/LICENSE
 [logo-url]: https://raw.githubusercontent.com/Khang152/Bybit.Exchange.Net/develop/Bybit.Exchange.Net/Bybit.Exchange.Net/Images/icon.png
 [nuget-version-url]: https://img.shields.io/nuget/v/Bybit.Exchange.Net.svg?style=for-the-badge&logo=nuget
 [nuget-download-url]: https://img.shields.io/nuget/dt/Bybit.Exchange.Net?style=for-the-badge&logo=nuget&color=red
 [azure-deployment-url]: https://img.shields.io/azure-devops/release/khang152/c60f8db4-4f52-4514-ac54-145047d74cca/3/3?style=for-the-badge&logo=azuredevops&label=Azure%20Deployment
 [features-wiki-url]: https://github.com/Khang152/Bybit.Exchange.Net/wiki/Features
 [api-support-wiki-url]: https://github.com/Khang152/Bybit.Exchange.Net/wiki/API-Support-Reference
 [release-note-wiki-url]: https://github.com/Khang152/Bybit.Exchange.Net/wiki/Release-Notes
 [issues-url]: https://github.com/Khang152/Bybit.Exchange.Net/issues

 ![logo][logo-url]
# Bybit.Exchange.Net
[![NuGet Version (Bybit.Exchange.Net)][nuget-version-url]][nuget-url]&nbsp;[![NuGet Download (Bybit.Exchange.Net)][nuget-download-url]][nuget-url]
![Azure DevOps Releases][azure-deployment-url]

**Bybit.Exchange.Net** is a library designed for .NET projects, tailored for seamless interaction with the Bybit crypto exchange API. With a structure closely aligned with Bybit's API documentation, it prioritizes simplicity, offering rich models, enums, and convenient logging for easy integration into .NET projects. Ideal for developers building crypto trading applications on the Bybit.
## Prerequisites
 - **Windows:** .NET 8

## Installation and sources
 - [NuGet package][nuget-url]
 - [Source code][source-url]

## Features
The [Features][features-wiki-url] documentation provides an in-depth look at the functionalities and capabilities of our project. Understanding the available features.

## Key Features
- Built with full compatibility for .NET 8, ensuring smooth execution on the latest .NET applications and projects.

- Designed with a structure closest to Bybit's API documentation, ensuring consistency and ease of understanding during integration.

- Focuses on providing models and enums that accurately reflect the key concepts from Bybit's API, simplifying the creation and handling of API requests.

- The library is designed to simplify the process of interacting with the Bybit API, with logically organized methods and classes, saving developers time and effort during integration.

- Effortlessly log API responses, including raw data from Bybit, to enhance tracking and facilitate effective debugging throughout the development and deployment phases of your application.

With flexibility, user-friendliness, and seamless integration into .NET projects, **Bybit.Exchange.Net** is a valuable resource for developers looking to build crypto trading applications on the Bybit exchange.

## Release Notes

Explore the [Release Notes][release-note-wiki-url] to stay up-to-date with the latest changes, improvements, and bug fixes. We regularly update this section to provide transparency and highlight the evolution of the project.

## API Support

Refer to the [API Documentation][api-support-wiki-url] for details on the current APIs supported by our project. If you have suggestions for new APIs, feel free to [open a request][issues-url].


## Quick Setup
### Program.cs
```csharp
using Bybit.Exchange.Net.Extensions;
using Bybit.Exchange.Net.Models.Common;

builder.Services.AddBybitExchange(
    new BybitRestOptions()
    {
        Credentials = new ByBitCredentials()
        {
            Key = "key",
            Secret = "secret",
        }
    });
```

### Blazor Pages
```csharp
@using Bybit.Exchange.Net.Library.Interface
@using Bybit.Exchange.Net.Models.V5.Account
@using static Bybit.Exchange.Net.Data.Enums
@inject IBybitRestClient client

protected override async Task OnInitializedAsync()
{
    var response = await client.V5.Account.GetWalletBalanceAsync(new GetWalletBalanceRequest()
    {
        accountType = AccountType.UNIFIED,
    });
}
```
### Others
```csharp
using Bybit.Exchange.Net.Library
using Bybit.Exchange.Net.Models.Common
using Bybit.Exchange.Net.Models.V5.Market
using static Bybit.Exchange.Net.Data.Enums

var client = new BybitRestClient(new BybitRestOptions()
    {
        Credentials = new ByBitCredentials(key, secret),
        Environment = BybitEnvironment.Live
    });

var response = await client.V5.Market.GetTickersAsync(new GetTickersRequest() { 
    category = Category.Spot 
});
```

## Contributing Guide
 
We welcome contributions to our project! 
Before getting started, please take a moment to read through the following guidelines:

### Submitting Changes
1. Clone "contributors" branch.
2. Add some nice features.
3. Create a Pull Request to "develop" branch.

### Reporting Bugs
If you have found a bug in our project, please open an issue on GitHub. When reporting a bug, please include as much detail as possible about the issue and steps to reproduce it.

## Support Us with a Donation
Consider making a donation in your preferred cryptocurrency to support our project. If the cryptocurrency you want to donate is not listed here, please reach out to us.

- **USDT:** `TG8dYGsFU3euoMcjaMGq7whpFKMFh8J6u7`
- **USDC:** `0x273b11e05862ee18a6dec243cbdbd0c12132da5d`

Your contribution helps us continue our work and is greatly appreciated!

## License
By contributing to our project, you agree that your contributions will be licensed under the [LICENSE][license-url]