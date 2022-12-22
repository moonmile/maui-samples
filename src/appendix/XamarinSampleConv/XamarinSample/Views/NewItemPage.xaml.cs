using System;
using System.Collections.Generic;
using System.ComponentModel;

using XamarinSample.Models;
using XamarinSample.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace XamarinSample.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}