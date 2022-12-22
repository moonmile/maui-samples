namespace ReactiveCollectionView;
using Reactive.Bindings;
using System.Collections.ObjectModel;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        this.Loaded += MainPage_Loaded;
	}

    private ViewModel _vm;
    private void MainPage_Loaded(object sender, EventArgs e)
    {
        _vm = new ViewModel();
        this.BindingContext = _vm;
    }

}

public class Card
{
    public string ImageUrl { get; set; } = "";
    public string Name { get; set; } = "";
    public string Location { get; set; } = "";
}

public class ViewModel 
{
    public ReactiveCollection<Card> Items { get; set; }
    public ReactiveProperty<Card> SelectedItem { get; }
    public ReactiveProperty<string> SelectedName { get; }

    public ViewModel()
    {
        this.SelectedName = new ReactiveProperty<string>("");
        this.SelectedItem = new ReactiveProperty<Card>();
        this.SelectedItem.Subscribe((o) => {
            this.SelectedName.Value = o?.Name;
        });

        Items = new ReactiveCollection<Card>();
        Items.Add(new Card() { ImageUrl = "cock.jpg", Name = "Cooking", Location = "Japan" });
        Items.Add(new Card() { ImageUrl = "book.jpg", Name = "Book Boy", Location = "Japan" });
        Items.Add(new Card() { ImageUrl = "dotnet_bot.png", Name = ".NET", Location = "USA" });
    }
}


