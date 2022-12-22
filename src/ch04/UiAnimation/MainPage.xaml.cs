namespace UiAnimation;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnClicked(object sender, EventArgs e)
	{
		await imageNet.RotateTo(360, 2000);
        imageNet.Rotation = 45;
    }
}

