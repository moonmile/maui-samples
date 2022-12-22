namespace MauiSQLite;

public partial class NewItemPage : ContentPage
{
	public NewItemPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await this.Navigation.PopAsync();
	}
}