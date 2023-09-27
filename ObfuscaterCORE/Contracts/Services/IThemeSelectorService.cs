using System;

using ObfuscateCORE.Models;

namespace ObfuscateCORE.Contracts.Services
{
    public interface IThemeSelectorService
    {
        void InitializeTheme();

        void SetTheme(AppTheme theme);

        AppTheme GetCurrentTheme();
    }
}
