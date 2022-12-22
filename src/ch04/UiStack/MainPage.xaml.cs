namespace UiStack;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
        string name = textName.Text;
        int age = int.Parse(textAge.Text);
        string addr = textAddress.Text;
        await DisplayAlert(".NET MAUI", $"{name} ({age}) in {addr}", "OK");

    }
}

