﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FpPS4_Garden.Pages
{
    /// <summary>
    /// Interaction logic for FreshInstall.xaml
    /// </summary>
    public partial class FreshInstall : Page
    {
        public FreshInstall()
        {
            InitializeComponent();
        }

        private void NextButtonClick(object sender, RoutedEventArgs e)
        {
            // Navigate to another page (e.g., SecondPage)
            NavigationService?.Navigate(new Uri("SecondPage.xaml", UriKind.Relative));
        }
    }
}
