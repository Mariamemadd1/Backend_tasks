using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    internal class CsvFileAnalyzer : FileAnalyzer,IfileAnalyzer
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string[] file= File.ReadAllLines(fileInfo.FullName);
            var row = file[0].Split(',');
            AnalyzeResults analyzeResults = new AnalyzeResults();
            
            analyzeResults.Fieldcnt = row.Length;
            SetAnalyzeResults(analyzeResults);
        }
    }
}
