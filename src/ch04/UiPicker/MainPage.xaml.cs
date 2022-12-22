namespace UiPicker;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += MainPage_Loaded;
	}

	private void MainPage_Loaded(object sender, EventArgs e)
	{
		var lst = new List<string>();
		lst.Add("選択してください");
		lst.Add("C#");
        lst.Add("Visual Basic");
        lst.Add("F#");
        lst.Add("Kotlin");
        lst.Add("Swift");
        lst.Add("Java");
        lst.Add("Objective-C");

		pick.ItemsSource = lst;
		pick.SelectedIndex = 0;
	}

	private void PickSelectedIndexChanged(object sender, EventArgs e)
	{
		if ( pick.SelectedIndex != -1 )
		{
			labelResult.Text = pick.SelectedItem as string;
        }
    }
}

