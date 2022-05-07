using System;
using System.IO;

namespace DirectoryAndDirectoryInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Directory.CreateDirectory(@"c:\temp\folder1");

            String[] files = Directory.GetFiles(@"c:\projects\CSharpFundamentals",
                    "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            String[] directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals",
                "*.*", SearchOption.AllDirectories);
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }

            Console.WriteLine("\t" + "DirectoryInfo Class");

            DirectoryInfo directoryInfo = new DirectoryInfo(".....");

            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
