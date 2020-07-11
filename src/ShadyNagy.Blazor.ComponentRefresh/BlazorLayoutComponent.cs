using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace ShadyNagy.Blazor.ComponentRefresh
{
    public class BlazorLayoutComponent : LayoutComponentBase
    {
        [Inject] private ComponentService Refresh { get; set; }

        protected override Task OnInitializedAsync()
        {
            Refresh.RefreshRequested += DoRefresh;
            return base.OnInitializedAsync();
        }

        public void CallRequestRefresh()
        {
            Refresh.CallRequestRefresh();
        }

        private void DoRefresh()
        {
            StateHasChanged();
        }
    }
}
