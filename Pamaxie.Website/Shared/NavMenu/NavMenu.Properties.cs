﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using MudBlazor;
using Pamaxie.Data;
using Pamaxie.Website.Services;

#pragma warning disable 8618

namespace Pamaxie.Website.Shared
{
    // ReSharper disable once ClassNeverInstantiated.Global
    /// <summary>
    /// <inheritdoc cref="NavMenu"/>
    /// </summary>
    public partial class NavMenu
    {
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject] private IHttpContextAccessor HttpContextAccessor { get; set; }
        [Inject] private IDialogService DialogService { get; set; }
        [Inject] private EmailSender EmailSender { get; set; }

        /// <summary>
        /// Render Frag for rendering the child content of the Website
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        private PamaxieUser? User { get; set; }
        private bool UserHasAccount { get; set; } = true;
        private bool ShowCreateAccount { get; set; }
    }
}