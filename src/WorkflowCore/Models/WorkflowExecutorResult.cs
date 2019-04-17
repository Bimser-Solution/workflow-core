using System.Collections.Generic;

namespace WorkflowCore.Models
{
    public class WorkflowExecutorResult
    {
        public bool HasError { get { return Errors?.Count > 0; } }
        public bool HasSubscription { get { return Subscriptions?.Count > 0; } }
        public List<EventSubscription> Subscriptions { get; set; } = new List<EventSubscription>();
        public List<ExecutionError> Errors { get; set; } = new List<ExecutionError>();
    }
}
