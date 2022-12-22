namespace MvvmPrismBasic;

using Prism.Commands;
using Prism.Mvvm;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

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


public class ViewModel : BindableBase
{
    private string _hello = "Hello, world!";
    public string Hello
    {
        get => _hello;
        set => SetProperty(ref _hello, value, nameof(Hello));
    }

    public ICommand OnHelloClicked { get; private set; }
    public ViewModel()
    {
        OnHelloClicked = new DelegateCommand(() => {
            this.Hello = "ようこそ .NET MAUIの世界へ";
        });
    }
}

