using MvvmMultiPage.ViewModels;

namespace MvvmMultiPage;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
		this.Loaded += (s, e) =>
		{
			this.BindingContext = _vm;
		};
	}
	FirstViewModel _vm = new FirstViewModel();
}