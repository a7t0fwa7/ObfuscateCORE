using System.Windows.Controls;

using ObfuscateCORE.ViewModels;

namespace ObfuscateCORE.Views
{
    public partial class PHPPage : Page
    {
        public PHPPage(PHPViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
