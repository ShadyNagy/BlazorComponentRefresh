using Microsoft.AspNetCore.Components;

namespace ShadyNagy.Blazor.ComponentRefresh
{
    public class BlazorLayoutComponent : LayoutComponentBase
    {
        private readonly ComponentBroadcast _refresh = ComponentBroadcast.Instance;

        protected override void OnInitialized()
        {
            _refresh.RefreshRequested += DoRefresh;
            base.OnInitialized();
        }

        public void CallRequestRefresh()
        {
            _refresh.CallRequestRefresh();
        }

        private void DoRefresh()
        {
            StateHasChanged();
        }
    }
}
