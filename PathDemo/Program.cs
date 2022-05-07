using System;
using System.IO;

namespace PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = @"C:\Projects\CSharpFundamentals\HelloWorld\
                HelloWorld.sln";


            int dotIndex = path.IndexOf('.');
            String requiredExtension = path.Substring(dotIndex, 4);
            Console.WriteLine("Extension: " + requiredExtension);

            String extension = path.
                Substring(path.Length - 3, 3);
            Console.WriteLine("Extension: " + extension);

            //Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name Without Extension: " +
                              Path.GetFileNameWithoutExtension(path));

            Console.WriteLine("Directory Name: " +
                              Path.GetDirectoryName(path));
        }
    }
}
