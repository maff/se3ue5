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
            FileSystemHandler fs = new FileSystemHandler("D:\\tmp");
            fs.NotifyFilters = NotifyFilters.FileName | NotifyFilters.DirectoryName;
            fs.Filter = "*.txt";
            fs.Run();

            Console.ReadLine();
        }
    }
}
