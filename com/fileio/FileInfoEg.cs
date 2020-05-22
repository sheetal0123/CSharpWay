using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace CSharpWay.com.fileio
{

    /**
     * If we are performing multiple operations on the single file, 
     * then it’s more efficient to use FileInfo class methods instead of File class methods.
     * 
     */
    class FileInfoEg
    {
        public static string fpath = @"D:\MyCloud\myworkspace\CSharpWay\com.fileio\fileinfo.txt";

        public static void WriteFile()
        {
            //delete if file present
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }

            // Create the file
            FileInfo fi = new FileInfo(fpath);
            using (StreamWriter sw = fi.CreateText())
            {
                sw.WriteLine("Hi");
                sw.WriteLine("Welcome to C# Tutorial");
                sw.WriteLine("Using FileInfo !!!");
            }
            Console.WriteLine("File Written Successfully");
        }




        public static void ReadFile()
        {
            Console.WriteLine("Reading File ...");
            if (File.Exists(fpath))
            {
                FileInfo fi = new FileInfo(fpath);
                using (StreamReader sr = fi.OpenText())
                {
                    string txt;
                    while ((txt = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(txt);
                    }
                }

                Console.WriteLine("Some Useful Info(FileInfo):");
                Console.WriteLine("Length: "+ fi.Length);
                Console.WriteLine("extension:" + fi.Extension);
                Console.WriteLine("Last Access Time:" + fi.LastAccessTime);
            }
        }

        public static void main(String [] args)
        {
            WriteFile();
            ReadFile();
        }
    }
}
