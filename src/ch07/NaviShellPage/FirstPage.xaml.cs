namespace NaviShellPage;

public partial class FirstPage : ContentPage
{
    public FirstPage()
    {
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new FirstViewModel();
            _vm.Message = "ここは新しいページです";
            this.BindingContext = _vm;
        };
    }
    FirstViewModel _vm;

    private void OnCountClicked(object sender, EventArgs e)
    {
        _vm.Count++;
    }
}

public class FirstViewModel : Prism.Mvvm.BindableBase
{
    private int _count = 0;
    private string _message = "";

    public string Title { get; set; } = "FirstPage";
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
