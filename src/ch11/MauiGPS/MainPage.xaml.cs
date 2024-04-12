using Prism.Commands;
using System.Windows.Input;

namespace MauiGPS;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += (_, _) =>
		{
			_vm = new ViewModel();
			this.BindingContext = _vm;
		};
	}
	ViewModel _vm;
}

public class ViewModel : Prism.Mvvm.BindableBase
{
	string _message = "";
	public string Message
	{
		get => _message;
		set => SetProperty(ref _message, value, nameof(Message));
	}

	public ICommand OnClicked { get; private set; }
	public ViewModel()
	{
		this.OnClicked = new DelegateCommand(async () =>
		{

			GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
			var loc = await Geolocation.Default.GetLocationAsync(request);
			this.Message = $"緯度 {loc.Latitude:#.000} 経度 {loc.Longitude:#.000}";
		});
	}
}

