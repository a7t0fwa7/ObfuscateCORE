using System.Windows.Controls;

using ObfuscateCORE.Contracts.Views;
using ObfuscateCORE.ViewModels;

using MahApps.Metro.Controls;

namespace ObfuscateCORE.Views
{
    public partial class ShellWindow : MetroWindow, IShellWindow
    {
        public ShellWindow(ShellViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        public Frame GetNavigationFrame()
            => shellFrame;

        public void ShowWindow()
            => Show();

        public void CloseWindow()
            => Close();
    }
}
