using System;
using System.IO;
using System.Windows.Controls;
using Microsoft.Win32;
using ObfuscateCORE.ViewModels;

namespace ObfuscateCORE.Views
{
    public partial class BatchPage : Page
    {
        public BatchPage(BatchViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void select_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog saver = new OpenFileDialog();
            saver.InitialDirectory = "C:\\Users\\" + Environment.UserName;
            saver.RestoreDirectory = true;
            saver.ShowDialog();
            string _path = Path.GetFullPath(saver.FileName);
            batchPath.Text = _path;
        }

        private void encrypt_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Helpers.Batch.EncryptBatch(batchPath.Text);
        }
    }
}
