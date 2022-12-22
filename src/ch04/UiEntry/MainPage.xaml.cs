namespace UiEntry;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	
	/// <summary>
	/// 送信ボタンをクリック
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void OnClickCommit(object sender, EventArgs e)
	{
		string name = textName.Text;
		string addr = textAddress.Text;
		labelMessage.Text = $"{name} in {addr}";
	}
}

