using System.Collections.Generic;

namespace CometListView;
public class MainPage : View
{
	[State]
	readonly List<string> Items = new List<string>()
        {
            "C#","Visual Basic", "F#", "Java", "Kotlin", "Objective-C", "Swift"
        };


	[Body]
	View body()
		=> new VStack {
			new ListView<string>(Items)
			{
				ViewFor = (s) => 
					new Text( s )
					.FontSize(24)
			}
		};
}


