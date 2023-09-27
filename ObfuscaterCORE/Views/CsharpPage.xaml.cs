using System;
using System.IO;
using System.Windows.Controls;
using Microsoft.Win32;
using ObfuscateCORE.ViewModels;

namespace ObfuscateCORE.Views
{
    public partial class CsharpPage : Page
    {
        public CsharpPage(CsharpViewModel viewModel)
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
            filePath.Text = _path;
        }

        private void encrypt_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Helpers.CSharp.EncryptCsharp(filePath.Text);
        }
    }
}
