using Microsoft.VisualBasic;
using System.Diagnostics;

namespace MauiFile;

public partial class LogDataPage : ContentPage
{
	public LogDataPage()
	{
		InitializeComponent();
        this.Loaded += (_, _) =>
        {
        };
	}


    string _outpath;
    FileStream _fs;

    private void StartTraceClicked(object sender, EventArgs e)
    {
#if ANDROID
        var activity = Microsoft.Maui.ApplicationModel.Platform.CurrentActivity;
        var dir = activity.ApplicationContext.GetExternalFilesDir(null).AbsolutePath;
        var outpath = System.IO.Path.Combine(dir, $"trace-{DateTime.Now.ToString("yyyyMMdd-HHmm")}.log");
#elif IOS || WINDOWS || MACCATALYST
        var dir = Environment.GetFolderPath(
Environment.SpecialFolder.MyDocuments);
        var outpath = Path.Combine( dir, 
$"trace-{DateTime.Now.ToString("yyyyMMdd-HHmm")}.log");
#else
        var outpath = "";
#endif
        var tw = System.IO.File.OpenWrite(outpath);
        var tr1 = new TextWriterTraceListener(tw);
        System.Diagnostics.Trace.AutoFlush = true;
        System.Diagnostics.Trace.Listeners.Add(tr1);

        _fs = tw;
        _outpath = outpath;
    }

    private void EndTraceClicked(object sender, EventArgs e)
    {
        if ( _fs != null ) 
            _fs.Close();
    }


    private void Button_Clicked(object sender, EventArgs e)
    {
        // ÉçÉOèoóÕ
        System.Diagnostics.Trace.WriteLine("sample log " + DateTime.Now.ToString() + "\n");
    }

    private void LogCheckClicked(object sender, EventArgs e)
    {
        string text = System.IO.File.ReadAllText(_outpath);
        message.Text = text;
    }
}