using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiAccess;


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



