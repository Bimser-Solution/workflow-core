using System;
using System.Threading.Tasks;
using WorkflowCore.Models;

namespace WorkflowCore.Interface
{
    public interface IWorkflowExecutor
    {
        Task<WorkflowExecutorResult> Execute(WorkflowInstance workflow);

        /// <summary>
        /// Executes all steps to until the wait for event
        /// </summary>
        /// <param name="workflow">Workflow instance</param>
        /// <param name="stepExecutedAction">Invoke action after the every step executed</param>
        /// <returns>Last executed step result</returns>
        Task<WorkflowExecutorResult> ExecuteUntilEventWait(WorkflowInstance workflow, Func<WorkflowExecutorResult, Task> stepExecutedAction);
    }
}