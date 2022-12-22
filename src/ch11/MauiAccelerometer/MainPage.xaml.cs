namespace MauiAccelerometer;

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
    private System.Numerics.Vector3 _acce;
    public System.Numerics.Vector3 Acce
    {
        get => _acce;
        set => SetProperty(ref _acce, value, nameof(Acce));
    }
    private bool _toggle = false;
    public bool Toggle
    {
        get => _toggle;
        set
        {
            if (Accelerometer.Default.IsSupported)
            {
                SetProperty(ref _toggle, value, nameof(Toggle));
                if (value)
                {
                    Accelerometer.Default.Start(SensorSpeed.Default);
                    Accelerometer.Default.ReadingChanged += Default_ReadingChanged;
                }
                else
                {
                    Accelerometer.Default.Stop();
                    Accelerometer.Default.ReadingChanged -= Default_ReadingChanged;
                }
            }
        }
    }

    private void Default_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
    {
        this.Acce = e.Reading.Acceleration;
        
    }
}
