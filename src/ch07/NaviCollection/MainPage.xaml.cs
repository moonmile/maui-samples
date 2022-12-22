namespace NaviCollection;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += MainPage_Loaded;
	}

	ViewModel _vm;
	private void MainPage_Loaded(object sender, EventArgs e)
	{
		_vm =	new ViewModel();
		this.BindingContext =	_vm;
	}

	private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var item = e.CurrentSelection.First() as Book;
		if (item == null) return;

		var page = new DetailPage(item);
		await Navigation.PushAsync(page);
	}
}

public class ViewModel: Prism.Mvvm.BindableBase
{
	public List<Book> Items { get; set; }
	public ViewModel()
	{
		Items = new List<Book>();
		Items.Add(new Book { Id = 1, Title = ".NET MAUI入門", Price = 2000 });
        Items.Add(new Book { Id = 2, Title = "Blazor入門", Price = 2000 });
        Items.Add(new Book { Id = 3, Title = "ASP.NET入門", Price = 2000 });
        Items.Add(new Book { Id = 4, Title = "やさしいC#", Price = 1000 });
        Items.Add(new Book { Id = 5, Title = "やさしいVisual Basic", Price = 1000 });
        Items.Add(new Book { Id = 6, Title = "やさしいF#", Price = 1000 });
    }
}

public class Book
{
	public int Id { get; set; }
	public string Title { get; set; }
	public int Price { get; set; }
}
