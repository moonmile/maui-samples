using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MvvmCollectionView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new ViewModel();
            this.BindingContext = _vm;
        };
    }
    ViewModel _vm;

}

public class Card
{
    public string ImageUrl { get; set; } = "";
    public string Name { get; set; } = "";
    public string Location { get; set; } = "";
}

public class ViewModel : BindableBase
{
    public List<Card> Items { get; set; }
    private Card _selectedItem = null;
    public Card SelectedItem
    {
        get => _selectedItem;
        set
        {
            SetProperty(ref _selectedItem, value, nameof(SelectedItem));
            SelectedName = value?.Name;
        }
    }

    private string _selectedName = "";
    public string SelectedName
    {
        get => _selectedName;
        set => SetProperty(ref _selectedName, value, nameof(SelectedName));
    }
    public ViewModel()
    {
        var lst = new List<Card>();
        lst.Add(new Card() { ImageUrl = "cock.jpg", Name = "Cooking", Location = "Japan" });
        lst.Add(new Card() { ImageUrl = "book.jpg", Name = "Book Boy", Location = "Japan" });
        lst.Add(new Card() { ImageUrl = "dotnet_bot.png", Name = ".NET", Location = "USA" });
        Items = lst;
    }
}


