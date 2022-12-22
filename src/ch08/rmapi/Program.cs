// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");

var apikey = "09dbd382ce4413d74aeb08d88f3cb97547f7610b";
var project_id = 26;
var issue_id = 382;

await HttpGetPage();
// await HttpPostPage();
// await GetJsonPage();
// await JsonListPage();
// wait SendJsonPage();


// ## GETメソッドで呼び出し
// HttpGetPage.xaml.cs
// 指定IDの issue を取得する
async Task HttpGetPage() {
    var cl = new HttpClient();
    cl.DefaultRequestHeaders.Add("X-Redmine-API-Key", apikey);
    var url = $"https://openccpm.com/redmine/issues/{issue_id}.json";
    Console.WriteLine($"call {url}");
    var response = await cl.GetAsync(url);
    var json = await response.Content.ReadAsStringAsync();
    Console.WriteLine(json);
}


// ## POSTメソッドの利用
async Task HttpPostPage()
{
    var cl = new HttpClient();
    cl.DefaultRequestHeaders.Add("X-Redmine-API-Key", apikey);
    var url = $"https://openccpm.com/redmine/issues.json";
    Console.WriteLine($"call {url}");

    var issue = new Issue();
    issue.ProjectId = project_id ;
    issue.Subject = "サンプルデータ";
    issue.Description = "サンプル " + DateTime.Now.ToString();
    issue.PriorityId = 2;

    var data = System.Text.Json.JsonSerializer.Serialize(new { issue = issue });
    var contnet = new StringContent(data, Encoding.UTF8, "application/json");
    var response = await cl.PostAsync(url, contnet);
    var json = await response.Content.ReadAsStringAsync();
    Console.WriteLine(json);
}


// ## JSONデータを受信する
async Task GetJsonPage()
{
    var cl = new HttpClient();
    cl.DefaultRequestHeaders.Add("X-Redmine-API-Key", apikey);
    var url = $"https://openccpm.com/redmine/projects/{project_id}.json";
    Console.WriteLine($"call {url}");


    var response = await cl.GetFromJsonAsync<ResponseProject>(url);
    Console.WriteLine(response?.Project.Name);

    /*

    var response = await cl.GetAsync(url);
    var json = await response.Content.ReadAsStringAsync();
    Console.WriteLine(json);

    var options = new JsonSerializerOptions
    {
        DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };

    var res = System.Text.Json.JsonSerializer.Deserialize<ResponseProject>(json);
    Console.WriteLine(res.project.Name);
    */
}


// ## JSONとリスト表示の連携
// JsonListPage.xaml.cs
// 指定プロジェクトIDの issues を取得する
async Task JsonListPage()
{
    var cl = new HttpClient();
    cl.DefaultRequestHeaders.Add("X-Redmine-API-Key", apikey);
    var url = $"https://openccpm.com/redmine/issues.json?project_id={project_id}";
    Console.WriteLine($"call {url}");

    var response = await cl.GetFromJsonAsync<ResponseIssues>(url);
    foreach( var it in response?.Issues!)
    {
        Console.WriteLine($"{it.Id} {it.Subject}");
    }
}

// ## JSONデータを送信する
// SendJsonPage.xaml.cs
// 指定IDの issue を更新する

async Task SendJsonPage()
{
    var cl = new HttpClient();
    cl.DefaultRequestHeaders.Add("X-Redmine-API-Key", apikey);
    var url = $"https://openccpm.com/redmine/issues/{issue_id}.json";
    Console.WriteLine($"call {url}");
    var response = await cl.GetFromJsonAsync<ResponseIssue>(url);
    Console.WriteLine(response?.Issue.Subject);

    var issue = response?.Issue!;
    issue.Description += "更新 " + DateTime.Now.ToString() + "\n";
    issue.PriorityId = issue.Priority.Id; // 本来はレスポンスから取得する
    var data = System.Text.Json.JsonSerializer.Serialize(new { issue = issue });
    var contnet = new StringContent(data, Encoding.UTF8, "application/json");
    var response2 = await cl.PutAsync(url, contnet);
    var json = await response2.Content.ReadAsStringAsync();
    Console.WriteLine(json);
}


#nullable disable

public class Issue
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("subject")]
    public string Subject { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("project_id")]
    public int ProjectId { get; set; }
    [JsonPropertyName("tracker_id")]
    public int TrackerId { get; set; }
    [JsonPropertyName("status_id")]
    public int StatusId { get; set; }
    [JsonPropertyName("priority_id")]
    public int PriorityId { get; set; }
    [JsonPropertyName("assigned_to_id")]
    public int AssignedToId { get; set; }
    [JsonPropertyName("done_ratio")]
    public int DoneRatio { get; set; }
    [JsonPropertyName("start_date")]
    public string StartDate { get; set; }
    [JsonPropertyName("due_date")]
    public string DueDate { get; set; }
    [JsonPropertyName("created_on")]
    public DateTime CreatedOn { get; set; }
    [JsonPropertyName("updated_on")]
    public DateTime UpdatedOn { get; set; }


    [JsonPropertyName("priority")]
    public Priority Priority { get; set; }
    [JsonPropertyName("tracker")]
    public Priority Tracker { get; set; }
}
public class ResponseIssues
{
    [JsonPropertyName("issues")]
    public Issue[] Issues { get; set; }
}
public class ResponseIssue
{
    [JsonPropertyName("issue")]
    public Issue Issue { get; set; }
}

public class ResponseProject
{
    [JsonPropertyName("project")]
    public Project Project { get; set; }
}

public class Project
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("Identifier")]
    public string Identifier { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("status")]
    public int Status { get; set; }
    [JsonPropertyName("is_public")]
    public bool IsPublic { get; set; }
    [JsonPropertyName("inherit_members")]
    public bool InheritMembers { get; set; }
    [JsonPropertyName("created_on")]
    public DateTime CreatedOn { get; set; }
    [JsonPropertyName("updated_on")]
    public DateTime UpdatedOn { get; set; }

}
/*
 {
    "project": {
        "id": 26,
        "name": "日経 .NET MAUI",
        "identifier": "maui",
        "description": "日経BP .NET MAUI入門本のためのプロジェクト",
        "homepage": "",
        "status": 1,
        "is_public": true,
        "inherit_members": false,
        "created_on": "2022-10-24T13:59:45Z",
        "updated_on": "2022-10-24T14:07:04Z"
    }
}
*/

public class Priority
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class Tracker
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
}



