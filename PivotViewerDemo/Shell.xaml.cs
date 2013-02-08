using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace PivotViewerDemo
{
    public partial class Shell : Page
    {
        public Shell()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void NavigatePivotButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainPageItem.Visibility = Visibility.Visible;
            this.DummyPageItem.Visibility = Visibility.Collapsed;
        }

        private void NavigateDummyButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainPageItem.Visibility = Visibility.Collapsed;
            this.DummyPageItem.Visibility = Visibility.Visible;
        }
    }
}