namespace UiNavigation;

public partial class NextPage : ContentPage
{
	public NextPage()
	{
		InitializeComponent();
	}

	private async void OnBackClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}