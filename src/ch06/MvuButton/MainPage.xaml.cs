namespace MvuButton;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.Loaded += MainPage_Loaded;	
	}

    private int _count = 0;
    private DateTime now = DateTime.Now;

	private void MainPage_Loaded(object sender, EventArgs e)
	{
        Button btnCount = new Button()
        {
            Text = "Click me",
            HorizontalOptions = LayoutOptions.Center,
        };
        btnCount.Clicked += (_, _) => {
            _count++;
            btnCount.Text = $"Count: {_count}";
        };
        Label labelNow = new Label
        {
            FontSize = 18,
            HorizontalOptions = LayoutOptions.Center,
        };
        Button btnNow = new Button()
        {
            Text = "現在時刻",
            HorizontalOptions = LayoutOptions.Center,
        };
        btnNow.Clicked += (_, _) =>
        {
            labelNow.Text = DateTime.Now.ToString();
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
                        FontSize = 32,
                        HorizontalOptions = LayoutOptions.Center,
                        Text = "Hello, World!"},
                    new Label
                    {
                        FontSize = 18,
                        Text = "ボタンを配置",
                        HorizontalOptions = LayoutOptions.Center,
                    },
                    btnCount,
                    btnNow,
                    labelNow,
                }
            }
        };
    }
}

