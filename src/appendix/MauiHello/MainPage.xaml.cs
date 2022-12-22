namespace MauiHello;

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

	private void OnCounterClicked(object sender, EventArgs e)
	{
		_vm.Count++;
	}
}

public class MainViewModel : Prism.Mvvm.BindableBase
{
	private int _count = 0;
	private string _name = "";
	public int Count
	{
		get => _count;
		set => SetProperty(ref _count, value, nameof(Count));
	}
	public string Name
	{
		get => _name;
		set
		{
			SetProperty(ref _name, value, nameof(Name));
			OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Message"));
		}
	}
	public string Message
	{
		get => $"Name is {_name}";
	}
}

