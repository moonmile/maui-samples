using System.Text;

namespace WebApiAccess;

public partial class HttpPostPage : ContentPage
{
	public HttpPostPage()
	{
		InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new HttpPostViewModel();
            _vm.Item = new Issue();
            _vm.Item.Subject = "サンプルデータ";
            _vm.Item.Description = "サンプル " + DateTime.Now.ToString();
            this.BindingContext = _vm;
        };
    }
    HttpPostViewModel _vm;


    private async void Button_Clicked(object sender, EventArgs e)
	{
        var apikey = "09dbd382ce4413d74aeb08d88f3cb97547f7610b";
        var project_id = 26;

        var cl = new HttpClient();
        cl.DefaultRequestHeaders.Add("X-Redmine-API-Key", apikey);
        var url = $"https://openccpm.com/redmine/issues.json";
        Console.WriteLine($"call {url}");

        var issue = _vm.Item;
        issue.ProjectId = project_id;
        issue.PriorityId = 2;

        var data = System.Text.Json.JsonSerializer.Serialize(new { issue = issue });
        _vm.JsonText = data;

        var contnet = new StringContent(data, Encoding.UTF8, "application/json");
        var response = await cl.PostAsync(url, contnet);
        var json = await response.Content.ReadAsStringAsync();
        Console.WriteLine(json);
    }
}

public class HttpPostViewModel : Prism.Mvvm.BindableBase
{
    public Issue Item { get; set; }
    private string _jsonText;
    public string JsonText
    {
        get => _jsonText;
        set => SetProperty(ref _jsonText, value, nameof(JsonText));
    }
}