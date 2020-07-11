using System;

namespace ShadyNagy.Blazor.ComponentRefresh
{
    public class ComponentService : IComponentService
    {
        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
