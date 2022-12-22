namespace UiButton;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private int _count = 0;

	/// <summary>
	/// カウンターボタンをクリック
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void OnCounterClicked(object sender, EventArgs e)
	{
		_count++;
		btnCounter.Text = $"Count: {_count}";
	}

	/// <summary>
	/// 現在時刻を表示
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void OnDateTimeClicked(object sender, EventArgs e)
	{
		textNow.Text = DateTime.Now.ToString();
	}
}

