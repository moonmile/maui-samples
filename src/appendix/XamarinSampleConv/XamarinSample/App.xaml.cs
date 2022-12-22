using System;
using XamarinSample.Services;
using XamarinSample.Views;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace XamarinSample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
