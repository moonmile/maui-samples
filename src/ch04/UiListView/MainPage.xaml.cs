namespace UiListView;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += MainPage_Loaded;
	}

	private void MainPage_Loaded(object sender, EventArgs e)
	{
        var lst = new List<Card>();
        lst.Add(new Card() { Name = "C#" });
        lst.Add(new Card() { Name = "Visual Basic" });
        lst.Add(new Card() { Name = "F#" });
        lst.Add(new Card() { Name = "Java" });
        lst.Add(new Card() { Name = "Kotlin" });
        lst.Add(new Card() { Name = "Objective-C" });
        lst.Add(new Card() { Name = "Swift" });
        lst.Add(new Card() { Name = "C++" });
        lst.Add(new Card() { Name = "Rust" });
        this.lv.ItemsSource = lst;
    }
}
public class Card
{
    public string ImageUrl { get; set; } = "";
    public string Name { get; set; } = "";
    public string Location { get; set; } = "";

}

