using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    internal class FileAnalyzer
    {
       public AnalyzeResults analyzeResults=new AnalyzeResults();

        public AnalyzeResults GetAnalyzeResults() { return analyzeResults; }
        public void SetAnalyzeResults(AnalyzeResults Results) { analyzeResults = Results; }
    }
}
