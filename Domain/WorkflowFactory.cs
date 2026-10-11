namespace Domain;

public interface IWorkflowFactory
{
   Task<TWorkflow> Create<TWorkflow>() where TWorkflow :  WorkflowBase<TWorkflow>;
}
public class WorkflowFactory: IWorkflowFactory
{
   public async Task<TWorkflow> Create<TWorkflow>() where TWorkflow : WorkflowBase<TWorkflow>
   {
      TWorkflow workflow = Activator.CreateInstance<TWorkflow>();
      workflow = await workflow.InitializeAsync(new WorkflowArgs());
      Console.WriteLine("Workflow factory created" +  workflow.ClassName);
      return workflow;
   }
}