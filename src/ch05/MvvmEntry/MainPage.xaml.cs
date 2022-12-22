using Prism.Commands;
using System.Windows.Input;

namespace MvvmEntry;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += (_, _) =>
		{
			this.BindingContext = _vm;
		};
	}
	ViewModel _vm = new ViewModel();
}

public class ViewModel : Prism.Mvvm.BindableBase
{
	private string _message = "";
	/*
	 * 変更通知をチェックする
	private string _name = "";
    public string Name
	{
		get => _name;
		set
		{
			System.Diagnostics.Debug.WriteLine("change Name property");
            SetProperty(ref _name, value, nameof(Name));
        }
	}
	*/
	public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string Message
	{
		get => _message;
		set => SetProperty(ref _message, value, nameof(Message));
	}

	public ICommand OnClickCommit { get; private set; }
    public ViewModel()
	{
		OnClickCommit = new DelegateCommand(() => {
            Message = $"{Name} in {Address}";
        });
	}
}

