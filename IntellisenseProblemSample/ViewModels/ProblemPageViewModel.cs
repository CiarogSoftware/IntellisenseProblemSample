using IntellisenseProblemSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellisenseProblemSample.ViewModels
{
    public class ProblemPageViewModel
    {
        public ProblemPageViewModel(SampleService sampleService)
        {
            SampleService = sampleService;
        }

        public SampleService SampleService { get; }
    }
}
