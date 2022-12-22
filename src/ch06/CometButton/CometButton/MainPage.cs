namespace CometButton;
public class MainPage : View
{


	[State]
	readonly CometRide comet = new();

	[Body]
	View body()
		=> new VStack {
			new Text("Hello, World!")
				.FontSize(32)
				.HorizontalTextAlignment(TextAlignment.Center),
			new Text("ボタンを配置")
				.FontSize(18)
                .HorizontalTextAlignment(TextAlignment.Center),
            new Button( comet.ButtonText ,()=>{ comet.Count++; })
				.Margin(8)
				.HorizontalLayoutAlignment(LayoutAlignment.Center),
			new Button("現在時刻", ()=>{ comet.Now = DateTime.Now; })
                .Margin(8)
                .HorizontalLayoutAlignment(LayoutAlignment.Center),
			new Text( () => comet.Now.ToString() ),
        }
        .Padding(new Thickness(30,0))
		.VerticalLayoutAlignment(LayoutAlignment.Center)
		;

	public class CometRide : BindingObject
	{
		public int Count 
		{
			get => GetProperty<int>();
			set => SetProperty(value);
		}
		public string ButtonText 
			=> Count == 0 ? "Click me" : $"Count: {Count}";
		public DateTime Now
		{
			get => GetProperty<DateTime>();
			set => SetProperty(value);
		}
	}
}


