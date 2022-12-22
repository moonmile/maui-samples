namespace MvuEntry;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += MainPage_Loaded;
	}

	private void MainPage_Loaded(object sender, EventArgs e)
	{
        var textName = new Entry { FontSize = 18 };
        var textAddress = new Entry { FontSize = 18 };
        var btnCommit = new Button { Text= "送信", HorizontalOptions = LayoutOptions.Center, };
        var labelMessage = new Label { FontSize = 18 };


        btnCommit.Clicked += (_,_) => {
            string name = textName.Text;
            string addr = textAddress.Text;
            labelMessage.Text = $"{name} in {addr}";
        };

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
                        FontSize = 18,
                        HorizontalOptions = LayoutOptions.Center,
                        Text = "テキスト入力"},
                    new Label {
                        FontSize = 18,
                        HorizontalOptions = LayoutOptions.Center,
                        Text = "名前"},
                    textName,
                    new Label {
                        FontSize = 18,
                        HorizontalOptions = LayoutOptions.Center,
                        Text = "住所"},
                    textAddress,
                    btnCommit,
                    labelMessage,
                }
            }
        };
	}
}

