using System.Net.Http.Json;

namespace WebApiAccess;

public partial class GetJsonPage : ContentPage
{
	public GetJsonPage()
	{
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new GetJsonViewModel();
            this.BindingContext = _vm;
        };
    }
    GetJsonViewModel _vm;

    private async void Button_Clicked(object sender, EventArgs e)
	{
        var apikey = "09dbd382ce4413d74aeb08d88f3cb97547f7610b";
        var project_id = 26;
        var issue_id = 382;

        var cl = new HttpClient();
        cl.DefaultRequestHeaders.Add("X-Redmine-API-Key", apikey);
        var url = $"https://openccpm.com/redmine/projects/{project_id}.json";
        Console.WriteLine($"call {url}");


        var response = await cl.GetFromJsonAsync<ResponseProject>(url);
        Console.WriteLine(response?.Project.Name);
        _vm.Item = response.Project;
    }
}
public class GetJsonViewModel : Prism.Mvvm.BindableBase
{
	private Project _item;
    public Project Item
    {
        get => _item;
        set => SetProperty(ref _item, value, nameof(Item));
    }
}