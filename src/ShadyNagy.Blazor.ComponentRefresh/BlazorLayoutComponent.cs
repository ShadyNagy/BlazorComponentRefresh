﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace ShadyNagy.Blazor.ComponentRefresh
{
    public class BlazorLayoutComponent : LayoutComponentBase
    {
        private readonly ComponentBroadcast _refresh = ComponentBroadcast.Instance;

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
