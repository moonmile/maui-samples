namespace UiTheme;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnWhiteClicked(object sender, EventArgs e)
	{
		Application.Current.UserAppTheme = AppTheme.Light;
    }

	private void OnDarkClicked(object sender, EventArgs e)
	{
        Application.Current.UserAppTheme = AppTheme.Dark;
    }
}

