using Prism.Commands;
using System.Windows.Input;

namespace MvvmCommand;

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
    private Color _imageBgColor;
    
    public Color ImageBgColor
    {
        get => _imageBgColor;
        set => SetProperty(ref _imageBgColor, value, nameof(ImageBgColor));
    }

    public ICommand OnButtonClicked { get; private set; }

    public ViewModel()
    {
        OnButtonClicked = new DelegateCommand<object>((obj) => {
            // ボタンを判別する
            var color = obj as string;
            switch ( color )
            {
                case "Red": this.ImageBgColor = Colors.Red; break;
                case "Blue": this.ImageBgColor = Colors.Blue; break;
                case "Yellow": this.ImageBgColor = Colors.Yellow; break;
            }
        });
    }
}


