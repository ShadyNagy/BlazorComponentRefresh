using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace ShadyNagy.Blazor.ComponentRefresh
{
    public class BlazorComponent : ComponentBase
    {
        private readonly ComponentService _refresh = ComponentService.Instance;

        protected override Task OnInitializedAsync()
        {
            _refresh.RefreshRequested += DoRefresh;
            return base.OnInitializedAsync();
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
