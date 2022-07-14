using Azure.Sdk.Tools.PipelineWitness.Entities.AzurePipelines;
using Microsoft.TeamFoundation.Build.WebApi;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azure.Sdk.Tools.PipelineWitness.Services.FailureAnalysis
{
    public interface IFailureAnalyzer
    {
        Task<IReadOnlyCollection<Failure>> AnalyzeFailureAsync(Build build, Timeline timeline);
    }
}
