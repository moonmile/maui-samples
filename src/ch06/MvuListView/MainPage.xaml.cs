namespace MvuListView;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += MainPage_Loaded;
	}

	private void MainPage_Loaded(object sender, EventArgs e)
	{
		var items = new List<string>()
		{
			"C#","Visual Basic", "F#", "Java", "Kotlin", "Objective-C", "Swift"
		};
		this.Content = new ScrollView
		{
			Margin = new Thickness(10),
			Content = new ListView
			{
				ItemsSource = items
			}
		};
	}
}

