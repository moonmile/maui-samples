namespace NaviCollection;

public partial class DetailPage : ContentPage
{
	public DetailPage(Book item)
	{
		InitializeComponent();
		this._vm = new DetailViewModel() { Item = item };
		this.Loaded += DetailPage_Loaded;
	}

	DetailViewModel _vm;

	private void DetailPage_Loaded(object sender, EventArgs e)
	{
		this.BindingContext = _vm;
	}
}

public class DetailViewModel : Prism.Mvvm.BindableBase
{
	public Book Item { get; set; }
}