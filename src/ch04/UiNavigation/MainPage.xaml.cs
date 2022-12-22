namespace UiNavigation;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnNextClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new NextPage());
	}
}

