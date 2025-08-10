namespace TextAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------Welcome to Data Analyzer-----------------------");
            Console.WriteLine("Enter Your Folder");
            string folder=Console.ReadLine();
            DirectoryInfo directory = new DirectoryInfo(folder);
            if (!directory.Exists)
            {
                Console.WriteLine("Folder Doesn't Exists");
                return;
            }
            else
            {
                var filenames= directory.GetFiles();
                foreach (var filename in filenames)
                {
                    IfileAnalyzer FileAnalyzer=null;
                    if (filename.Extension==".txt")
                    {
                        FileAnalyzer = new TxtFileAnalyzer();
                        FileAnalyzer.AnalyzeFile(filename);
                        var res = ((FileAnalyzer)FileAnalyzer).GetAnalyzeResults();
                        Console.WriteLine($"File Name: {filename.Name}");
                        Console.WriteLine($"Words count: {res.Wordcnt}");
                        Console.WriteLine($"Lines count: {res.Linecnt}");
                        Console.WriteLine($"Char count: {res.Charcnt}");
                    }
                    else if (filename.Extension==".csv")
                    {
                        FileAnalyzer = new CsvFileAnalyzer();
                        FileAnalyzer.AnalyzeFile(filename);
                        var res = ((FileAnalyzer)FileAnalyzer).GetAnalyzeResults();
                        Console.WriteLine($"File Name: {filename.Name}");
                        Console.WriteLine($"Feilds count: {res.Fieldcnt}");
                    }
                    else
                    {
                        Console.WriteLine($"can't analyze file {filename.Extension} ..");
                    }
                    Console.ForegroundColor= ConsoleColor.DarkBlue;
                    Console.WriteLine("----------------");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            
        }
    }
}
