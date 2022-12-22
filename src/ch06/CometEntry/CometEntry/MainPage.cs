namespace CometEntry;
public class MainPage : View
{

	[State]
	readonly CometRide comet = new();

	[Body]
	View body()
		=> new VStack {
			new Text("テキスト入力").FontSize(32)
			.HorizontalTextAlignment(TextAlignment.Center),
            new Text(()=> "名前")
				.FontSize(18)
				.HorizontalLayoutAlignment(LayoutAlignment.Fill)
                .HorizontalTextAlignment(TextAlignment.Start),
            new TextField(comet.Name)
                .HorizontalLayoutAlignment(LayoutAlignment.Fill),
            new Text("住所").FontSize(18)
                .HorizontalLayoutAlignment(LayoutAlignment.Fill)
                .HorizontalTextAlignment(TextAlignment.Start),
            new TextField(comet.Address)
                .HorizontalLayoutAlignment(LayoutAlignment.Fill),
            new Button("送信", () => {
				comet.Message = $"{comet.Name} in {comet.Address}"; 
			})
                .Margin(8)
                .HorizontalLayoutAlignment(LayoutAlignment.Fill),
            new Text(() => comet.Message )
				.FontSize(18)
                .HorizontalTextAlignment(TextAlignment.Center),
        }
        .Padding(new Thickness(30, 0))
		;

	public class CometRide : BindingObject
	{
		public string Name
		{
			get => GetProperty<string>();
			set => SetProperty(value);
		}
		public string	Address
		{
			get => GetProperty<string>();
			set => SetProperty(value);
		}
		public string Message
		{
            get => GetProperty<string>();
            set => SetProperty(value);
        }
    }
}


