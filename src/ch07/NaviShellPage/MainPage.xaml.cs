namespace NaviShellPage;

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
            // Appクラスに保存しておく
            (App.Current as App).MainViewModel = _vm;
        };
    }
    MainViewModel _vm;

    private async void OnFirstClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//first");
    }
    private async void OnSecondClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//second");
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
    public int Count
    {
        get => _count;
        set => SetProperty(ref _count, value, nameof(Count));
    }
    public string Message
    {
        get => _message;
        set => SetProperty(ref _message, value, nameof(Message));
    }
}

