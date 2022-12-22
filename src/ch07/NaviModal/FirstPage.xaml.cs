namespace NaviModal;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}

	private async void OnCloseClicked(object sender, EventArgs e)
	{
        await Navigation.PopModalAsync();
	}
}