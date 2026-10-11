namespace Domain;

public class Task
{
    public int Id { get; set; }
    public string? ClassName { get; set; } //E.g., MainFormSubmission
    public int WorkflowId { get; set; }
    public string? AssignedTo { get; set; }
    public int Status { get; set; } // pending, completed
    public int Action { get; set; } // none, approved, rejected
    public string? Url { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateActioned { get; set; }
}