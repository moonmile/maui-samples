
namespace MauiQR;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += (_, _) =>
		{
			_vm = new MainViewModel();
			this.BindingContext = _vm;
		};
	}
    MainViewModel _vm;
    private async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new QRCodePage() { BindingContext = _vm });
	}
}

public class MainViewModel : Prism.Mvvm.BindableBase
{
	private string _qrcode;
	public string QRCode
	{
		get => _qrcode;
		set => SetProperty(ref _qrcode, value, nameof(QRCode));
	}
}

