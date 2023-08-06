﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FpPS4_Garden.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class FreshInstall2 : Page
    {
        public FreshInstall2()
        {
            InitializeComponent();
        }

        private void BrowseInstallFolder_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog installFolderDialog = new FolderBrowserDialog();

            DialogResult result = installFolderDialog.ShowDialog();

            var installFolder = installFolderDialog.SelectedPath;

            if(result == DialogResult.OK)
            {
                FolderPathTextBox.Text = installFolder;
            }
        }
    }
}
