using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            if (!Directory.Exists(path))
            {
                Console.WriteLine("The directory does not exist");
            }
            Console.Write("Enter extension (without \".\"): ");
            string extension = Console.ReadLine();
            var fileNames = Directory.EnumerateFiles(path, $"*.{extension}", SearchOption.AllDirectories);
            
            var sum = 0;
            foreach(var fileName in fileNames)
            {
                var lines = File.ReadLines(fileName).Count();
                var reducedFileName = Path.GetFileName(fileName);
                Console.WriteLine($"{reducedFileName}: {lines} lines");
                sum += lines;
            }
            Console.WriteLine($"Total: {sum} lines");
            Console.WriteLine();
            Console.WriteLine("press enter to continue.");
            Console.ReadLine();

        }
    }
}
