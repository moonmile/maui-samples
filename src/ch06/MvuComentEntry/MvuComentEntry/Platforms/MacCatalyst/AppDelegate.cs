using Foundation;
using Microsoft.Maui.Hosting;

namespace MvuComentEntry;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => App.CreateMauiApp();
}