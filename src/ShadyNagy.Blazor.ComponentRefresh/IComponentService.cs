using System;

namespace ShadyNagy.Blazor.ComponentRefresh
{
    internal interface IComponentService
    {
        event Action RefreshRequested;
        void CallRequestRefresh();
    }
}