namespace NaviPopup;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void OnCountClicked(object sender, EventArgs e)
    {
        var vm = this.BindingContext as MainViewModel;
        vm.Count++;
    }
}

