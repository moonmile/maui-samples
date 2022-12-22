using Prism.Commands;
using System.Windows.Input;
namespace MauiCamera;

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

public class ViewModel : Prism.Mvvm.BindableBase
{
    private string _message = "";
    public string Message
    {
        get => _message;
        set => SetProperty(ref _message, value, nameof(Message));
    }
    public ICommand OnClicked { get; private set; }
    public ViewModel()
    {
        this.OnClicked = new DelegateCommand(async () => {

            if (MediaPicker.Default.IsCaptureSupported)
            {
                var photo = await MediaPicker.Default.CapturePhotoAsync();

                if (photo != null)
                {
                    // ローカルに保存する
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), photo.FileName);
                    using var st = await photo.OpenReadAsync();
                    using var fs = File.OpenWrite(path);
                    await st.CopyToAsync(fs);
                    this.Message = "撮影しました " + DateTime.Now.ToString();
                }
            }
        });
    }

}

