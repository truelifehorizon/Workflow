namespace Domain;

public class EarlyTerminationWorkflow: WorkflowBase<EarlyTerminationWorkflow>
{
    public EarlyTerminationWorkflow()
    {}

    public override async Task<EarlyTerminationWorkflow> InitializeAsync(WorkflowArgs args)
    {
       // await base.InitializeAsync(args);
        this.ClassName = "EarlyTerminationWorkflow";
        Console.Write("EarlyTerminationWorkflow Workflow Started");
        return this;
    }

    public override async Task<EarlyTerminationWorkflow> CompleteAsync(WorkflowArgs args)
    {
        await base.CompleteAsync(args);
        this.DateFinalized = DateTime.Now;
        Console.Write("EarlyTerminationWorkflow Workflow Completed");
        return this;
    }

    public override async Task<EarlyTerminationWorkflow> Cancel(WorkflowArgs args)
    {
        await base.Cancel(args);
        Console.Write("EarlyTerminationWorkflow Workflow Cancelled");
        return this;
    }

    public override async Task<EarlyTerminationWorkflow> ExecuteAsync(WorkflowArgs args)
    {
        await base.ExecuteAsync(args);
        Console.Write("Executing EarlyTerminationWorkflow workflow");
        return this;
    }
}