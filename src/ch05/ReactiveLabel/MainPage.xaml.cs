using Reactive.Bindings;
using System.Windows.Input;

namespace ReactiveLabel;

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
        _vm = new ViewModel();
        _vm.Title.Value = "坊っちゃん";
        _vm.Author.Value = "夏目漱石";
        _vm.Content.Value = "親譲の無鉄砲小供の時から損ばかりしている。小学校に居る時分学校の二階から飛び降りて一週間ほど腰を抜かした事がある。なぜそんな無闇をしたと聞く人があるかも知れぬ。別段深い理由でもない。新築の二階から首を出していたら、同級生の一人が冗談に、いくら威張っても、そこから飛び降りる事は出来まい。弱虫やーい。と囃したからである。小使に負ぶさって帰って来た時、おやじが大きな眼をして二階ぐらいから飛び降りて腰を抜かす奴があるかと云ったから、この次は抜かさずに飛んで見せますと答えた。";
        this.BindingContext = _vm;
    }
}

public class ViewModel 
{
    public ReactiveProperty<string> Hello { get; } = new ReactiveProperty<string>("ようこそ .NET MAUI の世界へ");
    public ReactiveProperty<string> Title { get; } = new ReactiveProperty<string>("");
    public ReactiveProperty<string> Author { get; } = new ReactiveProperty<string>("");
    public ReactiveProperty<string> Content { get; } = new ReactiveProperty<string>("");
}
