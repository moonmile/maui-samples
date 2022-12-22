namespace MauiFile;

public partial class CreateFilePage : ContentPage
{
	public CreateFilePage()
	{
		InitializeComponent();
        this.Loaded += (_, _) =>
        {
            string text = @$"
MyDocuments: 
  {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}
MyMusic: 
  {Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)}
MyPictures: 
  {Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}
Desktop: 
  {Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}
ApplicationData: 
  {Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}
CommonDocuments: 
  {Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments)}
CommonPictures: 
  {Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures)}
";
            this.Message.Text = text;
        };
	}


    /// <summary>
    /// ファイル作成
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
	{
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/sample.txt";
		string text = $"create at {DateTime.Now}";
		System.IO.File.WriteAllText(path, text);
        DisplayAlert(".NET MAUI", "ファイルを作成しました", "OK");
    }
}