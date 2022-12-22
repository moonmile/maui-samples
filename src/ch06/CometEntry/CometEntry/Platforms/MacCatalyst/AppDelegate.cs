using Foundation;
using Microsoft.Maui.Hosting;

namespace CometEntry;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => App.CreateMauiApp();
}