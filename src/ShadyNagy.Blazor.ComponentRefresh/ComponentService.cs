using System;

namespace ShadyNagy.Blazor.ComponentRefresh
{
    internal sealed class ComponentService : IComponentService
    {
        private static readonly Lazy<ComponentService>
            Lazy =
                new Lazy<ComponentService>
                    (() => new ComponentService());

        public static ComponentService Instance => Lazy.Value;

        private ComponentService()
        {
        }

        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
