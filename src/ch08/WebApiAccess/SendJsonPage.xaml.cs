using System.Net.Http.Json;
using System.Text;

namespace WebApiAccess;

public partial class SendJsonPage : ContentPage
{
    public SendJsonPage()
    {
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new SendJsonViewModel();
            this.BindingContext = _vm;
        };
    }
    SendJsonViewModel _vm;

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var apikey = "09dbd382ce4413d74aeb08d88f3cb97547f7610b";
        var project_id = 26;
        var issue_id = 382;

        var cl = new HttpClient();
        cl.DefaultRequestHeaders.Add("X-Redmine-API-Key", apikey);
        var url = $"https://openccpm.com/redmine/issues/{issue_id}.json";
        Console.WriteLine($"call {url}");
        var response = await cl.GetFromJsonAsync<ResponseIssue>(url);
        Console.WriteLine(response?.Issue.Subject);
        _vm.Subject = response.Issue.Subject;
        var issue = response?.Issue!;
        issue.Description += "更新 " + DateTime.Now.ToString() + "\n";
        issue.PriorityId = issue.Priority.Id; // 本来はレスポンスから取得する
        _vm.Description = issue.Description;
        var data = System.Text.Json.JsonSerializer.Serialize(new { issue = issue });
        var contnet = new StringContent(data, Encoding.UTF8, "application/json");
        var response2 = await cl.PutAsync(url, contnet);
        await response2.Content.ReadAsStringAsync();
        

    }
}

public class SendJsonViewModel : Prism.Mvvm.BindableBase
{
    private string _subject;
    public string Subject
    {
        get => _subject;
        set => SetProperty(ref _subject, value, nameof(Subject));
    }
    private string _description;
    public string Description
    {
        get => _description;
        set => SetProperty(ref _description, value, nameof(Description));
    }
}