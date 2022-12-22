namespace NaviModal;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnFirstClicked(object sender, EventArgs e)
	{
        await Navigation.PushModalAsync(new FirstPage());
	}


	private async void OnSecondClicked(object sender, EventArgs e)
	{
        await Navigation.PushModalAsync(new SecondPage());
    }
}

