using System;

namespace ShadyNagy.Blazor.ComponentRefresh
{
    internal class ComponentService : IComponentService
    {
        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
