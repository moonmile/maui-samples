namespace MvuLabel;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += MainPage_Loaded;
	}

	private void MainPage_Loaded(object sender, EventArgs e)
	{
		this.Content = new ScrollView
		{
			Content = new VerticalStackLayout
			{
				Spacing = 25,
				Padding = new Thickness(30, 0),
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					new Label { 
						FontSize = 32, 
						HorizontalOptions = LayoutOptions.Center, 
						Text = "Hello, World!"},
                    new Label { FontSize = 18, HorizontalOptions = LayoutOptions.Center,  Text = "ようこそ .NET MAUI の世界へ"},
                    new Label { FontSize = 24,Text = "坊っちゃん"},
                    new Label { FontSize = 18,Text = "夏目漱石"},
                    new Label { Text = @"親譲の無鉄砲小供の時から損ばかりしている。小学校に居る時分学校の二階から飛び降りて一週間ほど腰を抜かした事がある。なぜそんな無闇をしたと聞く人があるかも知れぬ。別段深い理由でもない。新築の二階から首を出していたら、同級生の一人が冗談に、いくら威張っても、そこから飛び降りる事は出来まい。弱虫やーい。と囃したからである。小使に負ぶさって帰って来た時、おやじが大きな眼をして二階ぐらいから飛び降りて腰を抜かす奴があるかと云ったから、この次は抜かさずに飛んで見せますと答えた。" },
                }
            }
		};
    }
}

