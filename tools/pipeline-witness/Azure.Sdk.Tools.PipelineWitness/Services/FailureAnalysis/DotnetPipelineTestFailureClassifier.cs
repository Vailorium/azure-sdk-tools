using System;
using Microsoft.TeamFoundation.Build.WebApi;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.Sdk.Tools.PipelineWitness.Services.FailureAnalysis
{
    public class DotnetPipelineTestFailureClassifier : IFailureClassifier
    {
        public Task ClassifyAsync(FailureAnalyzerContext context)
        {
            if (context.Build.Definition.Name.StartsWith("net - ", StringComparison.InvariantCulture))
            {
                var failedTasks = context.Timeline.Records
                    .Where(r => r.Result == TaskResult.Failed)
                    .Where(r => r.RecordType == "Task")
                    .Where(r => r.Name.StartsWith("Build & Test", StringComparison.InvariantCulture));

                foreach (var failedTask in failedTasks)
                {
                    context.AddFailure(failedTask, "Test Failure");
                }
            }

            return Task.CompletedTask;
        }
    }
}
