using FSH.BlazorWebAssembly.Client.Infrastructure.Preference;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace FSH.BlazorWebAssembly.Client.Components.ThemeManager
{
    public partial class DarkModePanel
    {
        private bool _isDarkMode = false;
        protected override async Task OnInitializedAsync()
        {
            if (await _clientPreferenceManager.GetPreference() is not ClientPreference themePreference) themePreference = new ClientPreference();
            _isDarkMode = themePreference.IsDarkMode;
        }

        [Parameter]
        public EventCallback<bool> OnIconClicked { get; set; }
        private async Task ToggleDarkMode()
        {
            _isDarkMode = !_isDarkMode;
            await OnIconClicked.InvokeAsync(_isDarkMode);
        }
    }
}