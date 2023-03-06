using Conductor.Client.Interfaces;
using Conductor.Client.Extensions;
using Conductor.Client.Worker;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Worker
{
    public class SimpleWorker : IWorkflowTask
    {
        public string TaskType { get; }
        public WorkflowTaskExecutorConfiguration WorkerSettings { get; }

        public SimpleWorker(string taskType = "test-sdk-csharp-task")
        {
            TaskType = taskType;
            WorkerSettings = new WorkflowTaskExecutorConfiguration();
        }

        public async Task<Conductor.Client.Models.TaskResult> Execute(Conductor.Client.Models.Task task, CancellationToken token)
        {
            return await Task.FromResult(task.Completed());
        }
    }
}
