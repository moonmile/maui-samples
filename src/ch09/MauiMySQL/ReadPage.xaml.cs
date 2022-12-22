using MauiMySQL.Models;
using Microsoft.EntityFrameworkCore;

namespace MauiMySQL;

public partial class ReadPage : ContentPage
{
	public ReadPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		var context = new wpdbContext();
		coll.ItemsSource = await context.WpPosts.ToListAsync();
    }
}