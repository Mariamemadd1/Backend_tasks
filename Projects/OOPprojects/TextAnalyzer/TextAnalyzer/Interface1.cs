using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    internal interface IfileAnalyzer 
    {
        public void AnalyzeFile(FileInfo fileInfo);
    }
}
