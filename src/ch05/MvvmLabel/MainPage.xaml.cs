namespace MvvmLabel;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += MainPage_Loaded;
	
	}

	private void MainPage_Loaded(object sender, EventArgs e)
	{
		_vm = new ViewModel();
		_vm.Title = "坊っちゃん";
		_vm.Author = "夏目漱石";
		_vm.Content = "親譲の無鉄砲小供の時から損ばかりしている。小学校に居る時分学校の二階から飛び降りて一週間ほど腰を抜かした事がある。なぜそんな無闇をしたと聞く人があるかも知れぬ。別段深い理由でもない。新築の二階から首を出していたら、同級生の一人が冗談に、いくら威張っても、そこから飛び降りる事は出来まい。弱虫やーい。と囃したからである。小使に負ぶさって帰って来た時、おやじが大きな眼をして二階ぐらいから飛び降りて腰を抜かす奴があるかと云ったから、この次は抜かさずに飛んで見せますと答えた。";
		this.BindingContext = _vm;

		_vm = new ViewModel
		{
			Title = "",
		};
    }

	ViewModel _vm;

}

public class ViewModel : Prism.Mvvm.BindableBase
{
	public string Hello { get; set; } = "ようこそ .NET MAUI の世界へ";
	public string Title { get; set; } = "";
	public string Author { get; set; } = "";
	public string Content { get; set; } = "";
	public int Price { get; set; } = 1000000;
}

