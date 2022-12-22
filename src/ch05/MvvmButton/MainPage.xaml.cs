using Prism.Commands;
using System.Windows.Input;

namespace MvvmButton;

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
    private string _name = "";
    private string _address = "";
    private string _message = "";

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value, nameof(Name));
    }
    public string Address
    {
        get => _address;
        set => SetProperty(ref _address, value, nameof(Address));
    }
    public string Message
    {
        get => _message;
        set => SetProperty(ref _message, value, nameof(Message));
    }

    public ICommand OnCommitClicked { get; private set; }
    public ICommand OnClearClicked { get; private set; }

    public ViewModel()
    {
        OnCommitClicked = new DelegateCommand(() => {
            Message = $"{Name} in {Address}";
        });
        OnClearClicked = new DelegateCommand(() =>
        {
            Name = "";
            Address = "";
            Message = "";
        });
    }
}


