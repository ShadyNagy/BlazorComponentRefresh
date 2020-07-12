<p align="center">
    <a href="https://www.nuget.org/packages/ShadyNagy.Blazor.ComponentRefresh" alt="NuGet">
        <img src="https://img.shields.io/nuget/v/ShadyNagy.Blazor.ComponentRefresh" />
    </a>
    <a href="https://www.nuget.org/packages/ShadyNagy.Blazor.ComponentRefresh" alt="NuGet">
        <img src="https://img.shields.io/nuget/dt/ShadyNagy.Blazor.ComponentRefresh" />
    </a>
    <a href="https://github.com/shadynagy/BlazorComponentRefresh/workflows/publish%20ShadyNagy.Blazor.ComponentRefresh%20to%20nuget/badge.svg" alt="Workflows">
        <img src="https://github.com/shadynagy/BlazorComponentRefresh/workflows/publish%20ShadyNagy.Blazor.ComponentRefresh%20to%20nuget/badge.svg" />
    </a>
    <a href="https://github.com/ShadyNagy/Utilities/graphs/contributors" alt="Contributors">
        <img src="https://img.shields.io/github/contributors/ShadyNagy/BlazorComponentRefresh" />
    </a>
    <a href="https://github.com/ShadyNagy/BlazorComponentRefresh/blob/master/LICENSE" alt="license">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" />
    </a>
</p>

# Blazor Component Refresh
Call refresh for all pages, Components and, layouts by call one function.

## Give a Star! :star:

If you like or are using this project please give it a star. Thanks!

## How To Use
- After install from Nuget
```powershell
Install-Package ShadyNagy.Blazor.ComponentRefresh
```
- Add this line to programe.cs in Main Function
```csharp
builder.Services.AddSingleton<ComponentService>();
```

- You have to inherit all LayoutComponent like "MainLayout.razor" from ShadyNagy.Blazor.BlazorLayoutComponent
```csharp
@inherits ShadyNagy.Blazor.BlazorLayoutComponent
```

- You have to inherit all Component or page like "Counter.razor" from ShadyNagy.Blazor.BlazorComponent
```csharp
@inherits ShadyNagy.Blazor.BlazorComponent
```

- When need to refresh all the components and layouts call this function CallRequestRefresh from component or layout
```csharp
CallRequestRefresh();
```
