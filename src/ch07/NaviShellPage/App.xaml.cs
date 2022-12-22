namespace NaviShellPage;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

	public MainViewModel MainViewModel { get; set; }
}
