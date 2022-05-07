using System;
using System.IO;

namespace FileAndFileInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg",
                @"d:\temp\myfile.jpg",
                true);

            File.Delete(path);

            if (File.Exists(path))
            {
                // do this..
                // do this..
            }

            String content = File.ReadAllText(path);

            Console.WriteLine("\t" + "FileInfo Class");

            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo(".....");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                //do this..
            }

        }
    }
}
