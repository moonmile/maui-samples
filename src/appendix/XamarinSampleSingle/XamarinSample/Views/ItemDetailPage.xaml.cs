using System.ComponentModel;
using XamarinSample.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace XamarinSample.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}