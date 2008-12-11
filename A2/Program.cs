using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Filesystem Watcher");
            Console.WriteLine("------------------\n");

            FileSystemHandler fs = new FileSystemHandler();
            fs.Path = @"D:\tmp";
            fs.NotifyFilters = NotifyFilters.FileName | NotifyFilters.DirectoryName;
            fs.Filter = "*";

            Console.WriteLine("Currently watching {0} with pattern {1}", fs.Path, fs.Filter);
            Console.WriteLine("Press any key to quit.\n");
            Console.WriteLine("--\n");
            
            fs.Run();

            Console.ReadLine();
        }
    }
}
