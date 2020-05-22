using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpWay.com.fileio
{

    /**
     * StreamWriter are derived from TextWriter
     * Binarywriter used to write in Binary Form
     */
    class FileStreams
    {
        public static string fpath = @"D:\MyCloud\myworkspace\CSharpWay\com.fileio\filestream.txt";

        public static void WriteFile()
        {
            //delete if file present
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }

            // Create the file
            FileStream fs = new FileStream(fpath, FileMode.Create);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("Hi");
                sw.WriteLine("Welcome to C# Tutorial");
                sw.WriteLine("Using File Streams !!!");
            }
            Console.WriteLine("File Written Successfully");
        }




        public static void ReadFile()
        {
            Console.WriteLine("Reading File ...");
            if (File.Exists(fpath))
            {
                using (StreamReader reader = new StreamReader(fpath))
                {
                    string str;
                    while ((str = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
        }

        public static void main(String [] args)
        {
            WriteFile();
            ReadFile();
        }
    }
}
