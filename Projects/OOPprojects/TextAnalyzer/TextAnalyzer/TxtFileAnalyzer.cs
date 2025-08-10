using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    internal class TxtFileAnalyzer : FileAnalyzer, IfileAnalyzer
    {   
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string file =File.ReadAllText(fileInfo.FullName);
            string [] words = file.Split(' ','\n','\r');
            string[] lines = file.Split('\n');
            AnalyzeResults Results = new AnalyzeResults();
            Results.Charcnt = file.Length;
            Results.Wordcnt =words.Length;
            Results.Linecnt = lines.Length;
            SetAnalyzeResults(Results);
    }
}
}
