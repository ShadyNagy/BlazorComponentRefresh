<p align="center">
    <a href="https://www.nuget.org/packages/ShadyNagy.Blazor.ComponentRefresh" alt="NuGet">
        <img src="https://img.shields.io/nuget/v/ShadyNagy.Blazor.ComponentRefresh" />
    </a>
    <a href="https://www.nuget.org/packages/ShadyNagy.Blazor.ComponentRefresh" alt="NuGet">
        <img src="https://img.shields.io/nuget/dt/ShadyNagy.Blazor.ComponentRefresh" />
    </a>
    <a href="https://github.com/ShadyNagy/BlazorComponentRefresh/actions?query=workflow%3A%22publish+ShadyNagy.Blazor.ComponentRefresh+to+nuget%22" alt="Workflows">
        <img src="https://github.com/shadynagy/BlazorComponentRefresh/workflows/publish%20ShadyNagy.Blazor.ComponentRefresh%20to%20nuget/badge.svg" />
    </a>
    <a href="https://github.com/ShadyNagy/BlazorComponentRefresh/graphs/contributors" alt="Contributors">
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

- You have to inherit all LayoutComponent like "MainLayout.razor" from ShadyNagy.Blazor.BlazorLayoutComponent

Change this
```csharp
@inherits LayoutComponentBase
```
to
```csharp
@inherits ShadyNagy.Blazor.ComponentRefresh.BlazorLayoutComponent
```

- You have to inherit all Component or page like "Counter.razor" from ShadyNagy.Blazor.BlazorComponent

Change this
```csharp
@inherits ComponentBase
```
to
```csharp
@inherits ShadyNagy.Blazor.ComponentRefresh.BlazorComponent
```

- If you need to refresh all the components and layouts call this function CallRequestRefresh from any component or layout.
```csharp
CallRequestRefresh();
```

## Samples
You can find samples here https://github.com/ShadyNagy/BlazorComponentRefresh/tree/master/samples/SampleBlazorComponentRefresh

Sample applied to the counter page "Counter.razor" and NavMenu "NavMenu.razor" so when you click "Click me" in the counter page it will increment the value in counter and in nav menu.

NavMenu.razor
```csharp
@inherits ShadyNagy.Blazor.ComponentRefresh.BlazorComponent

<div class="top-row pl-4 navbar navbar-dark">
    <a class="navbar-brand" href="">SampleBlazorComponentRefresh</a>
    <button class="navbar-toggler" @onclick="ToggleNavMenu">
        <span class="navbar-toggler-icon"></span>
    </button>
</div>

<div class="@NavMenuCssClass" @onclick="ToggleNavMenu">
    <ul class="nav flex-column">
        <li class="nav-item px-3">
            <NavLink class="nav-link" href="" Match="NavLinkMatch.All">
                <span class="oi oi-home" aria-hidden="true"></span> Home
            </NavLink>
        </li>
        <li class="nav-item px-3">
            <NavLink class="nav-link" href="counter">
                <span class="oi oi-plus" aria-hidden="true"></span> Counter @SomethingShared.CurrentCount
            </NavLink>
        </li>
        <li class="nav-item px-3">
            <NavLink class="nav-link" href="fetchdata">
                <span class="oi oi-list-rich" aria-hidden="true"></span> Fetch data
            </NavLink>
        </li>
    </ul>
</div>

@code {
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
}

```

Counter.razor
```csharp
@page "/counter"

@inherits ShadyNagy.Blazor.ComponentRefresh.BlazorComponent

<h1>Counter</h1>

<p>Current count: @SomethingShared.CurrentCount</p>

<button class="btn btn-primary" @onclick="IncrementCount">Click me</button>

@code {

    private void IncrementCount()
    {
        SomethingShared.CurrentCount++;
        CallRequestRefresh();
    }
}
```
## Animated Screenshots
![component-refresh](https://user-images.githubusercontent.com/6225593/87247411-ffbb0e00-c453-11ea-97f7-ad80a6120258.gif)
