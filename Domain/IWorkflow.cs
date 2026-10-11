namespace Domain;

public interface IWorkflow <TSelf> where TSelf : IWorkflow<TSelf>
{
    Task<TSelf> InitializeAsync(WorkflowArgs args);
    Task<TSelf> CompleteAsync(WorkflowArgs args);
    Task<TSelf> Cancel(WorkflowArgs args);
    Task<TSelf> ExecuteAsync(WorkflowArgs args);
}