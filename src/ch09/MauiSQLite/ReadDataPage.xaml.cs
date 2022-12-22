using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;
using System.Linq;

namespace MauiSQLite;

public partial class ReadDataPage : ContentPage
{
	public ReadDataPage()
	{
		InitializeComponent();
	
	}
	FisheriesDbContext context;

    private async void Button_Clicked(object sender, EventArgs e)
	{
		// SQLiteから読み込み
		context = new FisheriesDbContext();
		var items = await context.Users.ToListAsync();
		coll.ItemsSource = items;
    }

	private Users _item;

	/// <summary>
	/// 新規作成
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void NewItemClicked(object sender, EventArgs e)
	{
		_item = new Users();
        await this.Navigation.PushAsync(new NewItemPage() { BindingContext = _item });
    }
	// 新規/更新画面から戻った時
	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		if (_item == null) return;
		if (_item.Id == 0 )
		{
            context.Users.Add(_item);
        }
        await context.SaveChangesAsync();
        var items = await context.Users.ToListAsync();
		coll.ItemsSource = items;
    }

    /// <summary>
    /// 更新
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void UpdateItemClicked(object sender, EventArgs e)
	{
		if (coll.SelectedItem == null) return;
		var item = coll.SelectedItem;
        await this.Navigation.PushAsync(new UpdateItemPage() {  BindingContext = item });
    }
}

