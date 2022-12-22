using Comet;

namespace CometLabel;
public class MainPage : View
{
	void test()
	{
		var t = new Text();
		t.Frame = new Rect(0, 0, 100, 100);
		
	}


	[Body]
	View body()
		=> new ScrollView
		{
			new VStack
			{
				new Text(()=>"Hello, World!")
					.FontSize(32)
					.HorizontalLayoutAlignment(LayoutAlignment.Center),
				new Text(()=>"ようこそ .NET MAUI の世界へ")                 
					.HorizontalLayoutAlignment(LayoutAlignment.Center),
                new Text("坊っちゃん")
                    .FontSize(24)
                    .HorizontalLayoutAlignment(LayoutAlignment.Center),
                new Text("夏目漱石")
                    .FontSize(18)
                    .HorizontalLayoutAlignment(LayoutAlignment.Center),
                new Text(@"親譲の無鉄砲小供の時から損ばかりしている...
xxxxxxxxxxxxxxxxxxxxxxxxxxx
xxxxxxxxxxxxxxxxxxxxxxxxxxx
xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx")
				.Frame(width : 300, height: 400)
				.FitHorizontal()
				.FitVertical()
				
				,
            }
			.Margin(25)
			.Padding(new Thickness(30,0))
			.VerticalLayoutAlignment(LayoutAlignment.Center)
        };
}


