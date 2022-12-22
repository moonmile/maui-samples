using Microsoft.EntityFrameworkCore;

namespace MauiSQLite;

public partial class FisheriesListPage : ContentPage
{
	public FisheriesListPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
        // SQLiteから読み込み
        var context = new FisheriesDbContext();

		var q = from oroshi in context.T卸売
				join subject in context.T品名 on oroshi.品名Id equals subject.Id
				join market in context.T市場 on oroshi.市場Id equals market.Id
				join sale in context.T販売方法 on oroshi.販売方法Id equals sale.Id
				orderby oroshi.日付 descending
				select new T卸売()
				{
					Id = oroshi.Id,
					品名Id = oroshi.品名Id,
					販売方法Id = oroshi.販売方法Id,
					市場Id = oroshi.市場Id,
					卸売数 = oroshi.卸売数,
					日付 = oroshi.日付,
					品名 = subject,
					市場 = market,
					販売方法 = sale,
				};
        var items = await q.Take(100).ToListAsync();
        coll.ItemsSource = items;

    }
}