using Microsoft.EntityFrameworkCore;

namespace MauiSQLite;

public partial class MakeNewTablePage : ContentPage
{
	public MakeNewTablePage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        var SQL = @"
CREATE TABLE RPI (
    Id INTEGER NOT NULL CONSTRAINT PK_RPI PRIMARY KEY AUTOINCREMENT,
    Key BLOB NULL,
    Metadata BLOB NULL,
    StartTime TEXT NOT NULL,
    EndTime TEXT NOT NULL,
    RssiMin INTEGER NOT NULL,
    RssiMax INTEGER NOT NULL,
    MAC INTEGER NOT NULL
);"
        ;
        var context = new FisheriesDbContext();
        context.Database.ExecuteSqlRaw(SQL);
        DisplayAlert(".NET MAUI", "ÉeÅ[ÉuÉãÇçÏê¨ÇµÇ‹ÇµÇΩ", "OK");
    }
}