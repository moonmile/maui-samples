namespace NaviPopup;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += (_, _) =>
		{
			_vm = new MainViewModel();
			_vm.Message = "ようこそ .NET MAUI の世界へ";
			this.BindingContext = _vm;
		};
	}
	MainViewModel _vm;

	private async void OnFirstClicked(object sender, EventArgs e)
	{
        // 一部のデータのみ渡す
        await this.Navigation.PushAsync(new FirstPage(_vm.Count));
    }
    private async void OnSecondClicked(object sender, EventArgs e)
    {
		// 親の ViewModel を引き継ぐ
        await this.Navigation.PushAsync(new SecondPage() {  BindingContext = _vm });
    }

	private void OnCountClicked(object sender, EventArgs e)
	{
		_vm.Count++;
	}
}

public class MainViewModel : Prism.Mvvm.BindableBase
{
	private int _count = 0;
	private string _message = "";

	public string Title { get; set; } = "MainPage";
	public int Count { 
		get => _count; 
		set => SetProperty( ref _count, value, nameof(Count)); 
	}
	public string Message { 
		get => _message; 
		set => SetProperty( ref _message, value, nameof(Message)); 
	}
}
