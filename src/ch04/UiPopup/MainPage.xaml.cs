using System.Linq.Expressions;

namespace UiPopup;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// ポップアップ形式で表示
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void OnPopupClicked(object sender, EventArgs e)
	{
		await DisplayAlert(".NET MAUI サンプル", "メッセージを表示します", "CLOSE");
	}

	/// <summary>
	/// YES/NOの選択
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void OnYesNoClicked(object sender, EventArgs e)
	{
        bool answer =  await DisplayAlert(".NET MAUI サンプル", "あなたはC#が得意ですか？", "はい", "いいえ");
		labelResult.Text = $"結果: {answer}";
    }

    /// <summary>
    /// プロンプトで表示
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnPromptClicked(object sender, EventArgs e)
	{
        string result = await DisplayPromptAsync(".NET MAUI サンプル", "好きなプログラム言語？");
		labelResult.Text = $"結果: {result}";
    }
}

