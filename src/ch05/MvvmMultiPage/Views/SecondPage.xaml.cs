using MvvmMultiPage.ViewModels;

namespace MvvmMultiPage;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
        InitializeComponent();
        this.Loaded += (s, e) =>
        {
            this.BindingContext = _vm;
        };
    }
    SecondViewModel _vm = new SecondViewModel();
}