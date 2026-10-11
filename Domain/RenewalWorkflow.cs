namespace Domain;

public class RenewalWorkflow: WorkflowBase<RenewalWorkflow>
{
    public RenewalWorkflow()
    {}

    public override async Task<RenewalWorkflow> InitializeAsync(WorkflowArgs args)
    {
       // await base.InitializeAsync(args);
        this.ClassName = "RenewalWorkflow";
        Console.Write("Renewal Workflow Started");
        return this;
    }

    public override async Task<RenewalWorkflow> CompleteAsync(WorkflowArgs args)
    {
        await base.CompleteAsync(args);
        this.DateFinalized = DateTime.Now;
        Console.Write("Renewal Workflow Completed");
        return this;
    }

    public override async Task<RenewalWorkflow> Cancel(WorkflowArgs args)
    {
        await base.Cancel(args);
        Console.Write("Renewal Workflow Cancelled");
        return this;
    }

    public override async Task<RenewalWorkflow> ExecuteAsync(WorkflowArgs args)
    {
        await base.ExecuteAsync(args);
        Console.Write("Executing Renewal workflow");
        return this;
    }
}