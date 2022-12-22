namespace NaviSetting;

public partial class SettingPage : ContentPage
{
	public SettingPage()
	{
		InitializeComponent();
		this.Loaded += (_, _) =>
		{
			_vm = new SettingViewModel
			{
				AirplaneMode = false,
				Notifications = true,
			};
			this.BindingContext = _vm;
		};
	}
	SettingViewModel _vm;
}

public class SettingViewModel : Prism.Mvvm.BindableBase
{
	public bool AirplaneMode { get; set; }
	public bool Notifications { get; set; }	
	public string Username { get; set; }
	public string Password { get; set; }
}