namespace MauiSQLite;

public partial class BackupPage : ContentPage
{
	public BackupPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
#if ANDROID
        var activity = Microsoft.Maui.ApplicationModel.Platform.CurrentActivity;
        var dir = activity.ApplicationContext.GetExternalFilesDir(null).AbsolutePath;
        var outpath = System.IO.Path.Combine(dir, $"sample-{DateTime.Now.ToString("yyyyMMdd-HHmm")}.db");
#elif IOS || WINDOWS || MACCATALYST
        var dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        var outpath = Path.Combine(dir, $"sample-{DateTime.Now.ToString("yyyyMMdd-HHmm")}.db.txt");
#else
        var outpath = "";
#endif

        System.Diagnostics.Debug.WriteLine(outpath);
        string dbpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/sample.db";
        System.Diagnostics.Debug.WriteLine(dbpath);
        using (var fs = File.OpenRead(dbpath))
        {
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);
            File.WriteAllBytes(outpath, data);
        }
        DisplayAlert(".NET MAUI", $"•Û‘¶‚µ‚Ü‚µ‚½ {outpath}", "OK");
    }
}