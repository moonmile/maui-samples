namespace WebApiAccess;

public partial class HttpGetPage : ContentPage
{
	public HttpGetPage()
	{
		InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new HttpGetViewModel();
            this.BindingContext = _vm;
        };
	}
    HttpGetViewModel _vm;

    private async void Button_Clicked(object sender, EventArgs e)
	{
        var apikey = "09dbd382ce4413d74aeb08d88f3cb97547f7610b";
        var project_id = 26;
        var issue_id = 382;

        var cl = new HttpClient();
        cl.DefaultRequestHeaders.Add("X-Redmine-API-Key", apikey);
        var url = $"https://openccpm.com/redmine/issues/{issue_id}.json";
        Console.WriteLine($"call {url}");
        var response = await cl.GetAsync(url);
        var json = await response.Content.ReadAsStringAsync();
        Console.WriteLine(json);
        _vm.JsonText = json; 

        try
        {
            var res = await cl.GetAsync(url);
            if ( res.IsSuccessStatusCode)
            {
                // 呼び出し成功
            }
            else
            {
                // 呼び出し失敗
                switch (res.StatusCode) {
                    case System.Net.HttpStatusCode.NotFound:
                        break;
                    case System.Net.HttpStatusCode.Unauthorized:
                        break;
                    default:
                        break;
                }
            }
        } 
        catch
        {
            // URL間違いなどでサーバーが応答しない
        }



    }
}

public class HttpGetViewModel : Prism.Mvvm.BindableBase
{
    private string _jsonText;
    public string JsonText {
        get => _jsonText;
        set => SetProperty(ref _jsonText, value, nameof(JsonText));
    }
}