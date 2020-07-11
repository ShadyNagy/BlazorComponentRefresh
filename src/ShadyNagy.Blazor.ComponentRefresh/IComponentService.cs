using System;

namespace ShadyNagy.Blazor.ComponentRefresh
{
    public interface IComponentService
    {
        event Action RefreshRequested;
        void CallRequestRefresh();
    }
}