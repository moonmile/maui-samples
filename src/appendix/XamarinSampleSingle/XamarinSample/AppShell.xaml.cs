using System;
using System.Collections.Generic;
using XamarinSample.ViewModels;
using XamarinSample.Views;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace XamarinSample
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }
        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
