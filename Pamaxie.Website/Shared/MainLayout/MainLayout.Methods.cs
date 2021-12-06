﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace Pamaxie.Website.Shared
{
    // ReSharper disable once ClassNeverInstantiated.Global
    /// <summary>
    /// Class for the main layout design
    /// </summary>
    public partial class MainLayout
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            try
            {
                ProtectedBrowserStorageResult<bool> result = await ProtectedLocalStorage.GetAsync<bool>("useCookies");
                bool currentValue = result.Success && result.Value;
                _showCookieDialog = !currentValue;
                StateHasChanged();
            }
            catch
            {
                await ProtectedLocalStorage.DeleteAsync("useCookies");
                _showCookieDialog = false;
            }
        }

        private async Task Save()
        {
            await ProtectedLocalStorage.SetAsync("useCookies", true);
        }
    }
}