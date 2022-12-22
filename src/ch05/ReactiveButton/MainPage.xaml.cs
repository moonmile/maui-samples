using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System.ComponentModel;
using System.Reactive.Concurrency;
using System.Runtime.CompilerServices;

namespace ReactiveButton;

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
	public ReactiveProperty<string> Name { get; }
    public ReactiveProperty<string> Address { get; } 
    public ReactiveProperty<string> Message { get; } 
    public ReactiveCommand OnCommitClicked { get; }
    public ReactiveCommand OnClearClicked { get; }

    public ViewModel ()
	{
        this.Name = new ReactiveProperty<string>();
        this.Address = new ReactiveProperty<string> ();
		this.Message = new ReactiveProperty<string> ();

        this.OnCommitClicked = new ReactiveCommand().WithSubscribe(() => {
            Message.Value = $"{Name.Value} in {Address.Value}";
        });
        this.OnClearClicked = new ReactiveCommand().WithSubscribe(() => {
			Name.Value = "";
			Address.Value = "";
			Message.Value = "";
        });
    }
}

