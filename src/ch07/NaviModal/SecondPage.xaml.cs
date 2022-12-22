namespace NaviModal;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

	private async void OnCloseClicked(object sender, EventArgs e)
	{
        await Navigation.PopModalAsync();
    }
}