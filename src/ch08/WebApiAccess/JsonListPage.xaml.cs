using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace WebApiAccess;

public partial class JsonListPage : ContentPage
{
    public JsonListPage()
    {
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new JsonListViewModel();
            _vm.Items = new List<Issue>();
            this.BindingContext = _vm;
        };
    }
    JsonListViewModel _vm;


    private async void Button_Clicked(object sender, EventArgs e)
    {
        var apikey = "09dbd382ce4413d74aeb08d88f3cb97547f7610b";
        var project_id = 26;
        var issue_id = 382;

        var cl = new HttpClient();
        cl.DefaultRequestHeaders.Add("X-Redmine-API-Key", apikey);
        var url = $"https://openccpm.com/redmine/issues.json?project_id={project_id}";
        Console.WriteLine($"call {url}");

        var response = await cl.GetFromJsonAsync<ResponseIssues>(url);
        _vm.Items = new List<Issue>(response.Issues);
    }
}

public class JsonListViewModel : Prism.Mvvm.BindableBase
{
    private List<Issue> _items;
    public List<Issue> Items
    {
        get => _items;
        set => SetProperty(ref _items, value, nameof(Items));
    }
}


