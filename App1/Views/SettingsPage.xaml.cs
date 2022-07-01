using System.Windows.Controls;

using ObfuscateCORE.ViewModels;

namespace ObfuscateCORE.Views
{
    public partial class SettingsPage : Page
    {
        public SettingsPage(SettingsViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
