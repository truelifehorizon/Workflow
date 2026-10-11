using System.Security.AccessControl;
using Microsoft.VisualBasic.CompilerServices;

namespace Domain;

public abstract class WorkflowBase<TDerived>: IWorkflow<TDerived>
where TDerived : WorkflowBase<TDerived>
{
    #region Workflow properties
    public int WorkflowId { get; set; }
    /// <summary>
    /// Class name of this workflow used in the reconstruction of the workvlow class.
    /// </summary>
    public string? ClassName { get; set; }
    /// <summary>
    /// possible status:
    /// Initiated -> created but not sent off for approval
    /// Active -> sent off for approval
    /// Approved -> All approvers approved
    /// Completed -> All approved and finalized (PDF created, emails sent, etc.) successfully
    /// Canceled -> As if deleted. but is in the system for audit purpose.
    /// </summary>
    public int Status { get; set; }
    /// <summary>
    /// List of workflow tasks currently completed or pending action.
    /// </summary>
    public List<Task> Tasks { get; set; } = [];
    /// <summary>
    /// 
    /// </summary>
    public DateTime DateCreated { get; set; }
    /// <summary>
    /// All approvers approved, but not finalized (PDF not created yes, etc.)
    /// </summary>
    public DateTime DateApproved { get; set; }
    /// <summary>
    /// Date all approved and finalized (PDF created, final email sent, etc.)
    /// </summary>
    public DateTime DateFinalized { get; set; }
    /// <summary>
    /// This is the initiator
    /// </summary>
    public string? CreatedBy { get; set; } // Initiator Entra ID
    /// <summary>
    /// This is the Workflow data entered in step 1 (initiation task) and could be updated in the subsequent tasks
    /// </summary>
    public WorkflowData Data { get; set; } = new WorkflowData();
    #endregion
    #region Implementation of IWorkflow<W>
    public virtual Task<TDerived> InitializeAsync(WorkflowArgs args)
    {
        throw new NotImplementedException();
    }

    public virtual Task<TDerived> CompleteAsync(WorkflowArgs args)
    {
        throw new NotImplementedException();
    }

    public virtual Task<TDerived> Cancel(WorkflowArgs args)
    {
        throw new NotImplementedException();
    }

    public virtual Task<TDerived> ExecuteAsync(WorkflowArgs args)
    {
        throw new NotImplementedException();
    }
    #endregion
}