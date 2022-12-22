namespace MvuComentEntry;
public class MainPage : View
{

	[State]
	readonly CometRide comet = new();

	[Body]
	View body()
		=> new VStack {
		};

	public class CometRide : BindingObject
	{
	}
}


