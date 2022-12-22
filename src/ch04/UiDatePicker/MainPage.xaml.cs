namespace UiDatePicker;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void pick_DateSelected(object sender, DateChangedEventArgs e)
	{
		labelResult.Text = pick.Date.ToString();
	}
}

