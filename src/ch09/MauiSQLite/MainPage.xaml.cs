using System.IO;
using System.Text;

namespace MauiSQLite;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += MainPage_Loaded;
	}

	private async void MainPage_Loaded(object sender, EventArgs e)
	{
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/sample.db";
        System.Diagnostics.Debug.WriteLine($"path: {path}");
        using var stream = await FileSystem.OpenAppPackageFileAsync("sample.db");
        using var reader = new BinaryReader(stream);
        using var fs = System.IO.File.OpenWrite(path);
        using var writer = new BinaryWriter(fs);

		long size = 0;
		while ( true )
		{
            var data = reader.ReadBytes(1024 * 1024);
			writer.Write(data);
			size += data.Length;
			if (data.Length < 1024 * 1024) break;
        }
		System.Diagnostics.Debug.WriteLine($"total: {size}");
    }
}

