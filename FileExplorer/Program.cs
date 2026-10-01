using System.IO;

namespace FileExplorer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the path to the entry directory:");

        var path = Console.ReadLine();

        PrintDirectory(path, 0);
    }

    static void PrintDirectory(string path, int level)
    {
        var dirName = new DirectoryInfo(path).Name;

        foreach (var filePath in Directory.GetFiles(path))
        {
            //přidat soubory
        }

        Console.WriteLine($"{new string(' ', level * 4)} └── {dirName}");

        if (level >= 100)
            return;

        foreach (var dirPath in Directory.GetDirectories(path))
        {
            PrintDirectory(dirPath, level + 1);
        }
    }
}
