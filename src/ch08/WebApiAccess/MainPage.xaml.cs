namespace WebApiAccess;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private async void OnGetMethodClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//HttpGetPage");
    }

	private async void OnPostMethodClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//HttpPostPage");
    }

    private async void OnGetJsonClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//GetJsonPage");
    }

    private async void OnSendJsonClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//SendJsonPage");
    }

    private async void OnJsonListClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//JsonListPage");
    }
}

