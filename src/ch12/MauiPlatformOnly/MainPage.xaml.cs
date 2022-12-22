using MauiPlatformOnly.Platforms;

namespace MauiPlatformOnly;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += (_, _) =>
		{
			var setting = new MySetting();
			message.Text = setting.Name;
		};
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		// ビルド時に分岐する
#if ANDROID
		DisplayAlert(".NET MAUI", "これはAndroidです", "OK");
#endif
#if IOS
        DisplayAlert(".NET MAUI", "これはiPhoneです", "OK");
#endif
#if WINDOWS
        DisplayAlert(".NET MAUI", "これはWindowsです", "OK");
#endif
#if MACCATALYST
        DisplayAlert(".NET MAUI", "これからが.NET MAUIのスタートです", "OK");
#endif

    }
}

