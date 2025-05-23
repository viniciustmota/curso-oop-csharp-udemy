using System.IO;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\temp\myfolder\file1.txt";

            Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
            Console.WriteLine($"PathSeparator: {Path.PathSeparator}");
            Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"GetFileName: {Path.GetFileName(path)}");
            Console.WriteLine($"GetExtension: {Path.GetExtension(path)}");
            Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"GetFullPath: {Path.GetFullPath(path)}");
            Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");






            // Aula 134

            //string path = @"C:\temp\myfolder";

            //try
            //{
            //    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FOLDERS:");
            //    foreach (string s in folders)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FILES:");
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }
            //    Console.WriteLine();
            //    Directory.CreateDirectory(path + @"\newfolder"); // Cria uma nova pasta
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occured");
            //    Console.WriteLine(e.Message);
            //}















            // Aula 133

            //string sourcePath = @"C:\temp\file1.txt";
            //string targetPath = @"C:\temp\file2.txt";

            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath);

            //    using (StreamWriter sw = File.AppendText(targetPath))
            //    {
            //        foreach (string line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occured");
            //    Console.WriteLine(e.Message);
            //}












            // Aula 132

            //string path = @"C:\temp\file1.txt";

            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }

            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}


            // Aula 131

            //StreamReader sr = null;
            //try
            //{
            //    sr = File.OpenText(path);
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }

            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error acurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (sr != null) sr.Close();
            //}















            // Aula 130

            //string sourcePath = @"C:\temp\file1.txt";
            //string targetPath = @"C:\temp\file2.txt";

            //try
            //{
            //    //FileInfo fileInfo = new FileInfo(sourcePath);
            //    //fileInfo.CopyTo(targetPath);

            //    string[] lines = File.ReadAllLines(sourcePath);
            //    foreach(string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //catch(IOException e)
            //{
            //    Console.WriteLine("An error occured");
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}