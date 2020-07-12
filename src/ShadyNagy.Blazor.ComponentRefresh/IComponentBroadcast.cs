using System;

namespace ShadyNagy.Blazor.ComponentRefresh
{
    internal interface IComponentBroadcast
    {
        event Action RefreshRequested;
        void CallRequestRefresh();
    }
}