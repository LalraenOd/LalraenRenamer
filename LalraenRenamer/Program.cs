using System;
using System.IO;

namespace LalraenRenamer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "LalraenRenamer";
            Console.WriteLine("Enter destination folder: ", Console.ForegroundColor = ConsoleColor.Green);
            Console.ResetColor();
            string destFolder = Console.ReadLine();
            Console.WriteLine("Enter needed file extension: (.jpg, .png)");
            string fileExtension = Console.ReadLine();
            Console.ResetColor();
            if (destFolder != null && Directory.Exists(destFolder))
            {
                var files = Directory.GetFiles(destFolder);
                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    var resultFolder = destFolder + "\\" + fileInfo.Name + fileExtension;
                    File.Move(file, resultFolder);
                    Console.WriteLine("File moved to " + resultFolder, Console.ForegroundColor = ConsoleColor.Green);
                }
            }
            else
            {
                Console.WriteLine("Destination folder is not right ot not found", Console.ForegroundColor = ConsoleColor.Red);
                Environment.Exit(0);
            }
            Console.WriteLine("Done", Console.ForegroundColor = ConsoleColor.Green);
            Console.ReadKey();
        }
    }
}