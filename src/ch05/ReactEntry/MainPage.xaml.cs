using Reactive.Bindings;
using System.Windows.Input;

namespace ReactEntry;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
		InitializeComponent();
        this.Loaded += MainPage_Loaded;
	}

    ViewModel _vm;
    private void MainPage_Loaded(object sender, EventArgs e)
    {
        _vm = new ViewModel();
        this.BindingContext = _vm;
    }
}

public class ViewModel 
{
    public ReactiveProperty<string> Name { get; } = new ReactiveProperty<string>("");
    public ReactiveProperty<string> Address { get; } = new ReactiveProperty<string>("");
    public ReactiveProperty<string> Message { get; } = new ReactiveProperty<string>("");
    public ReactiveCommand OnCommitClicked { get; }

    public ICommand OnClickCommit { get; private set; } 
    public ViewModel()
    {
        this.OnCommitClicked = new ReactiveCommand().WithSubscribe(() => {
            Message.Value = $"{Name.Value} in {Address.Value}";
        });
    }
}


