namespace UiSwitch;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += MainPage_Loaded;
	}

	private void MainPage_Loaded(object sender, EventArgs e)
	{
		sw.IsToggled = true;
		image.IsVisible = true;
	}

	private void Switch_Toggled(object sender, ToggledEventArgs e)
	{
		if ( sw.IsToggled == true )
		{
			image.IsVisible = true;
		}
		else
		{
			image.IsVisible = false;
		}
	}
}

