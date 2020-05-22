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
    class Binary
    {
        public static string fpath = @"D:\MyCloud\myworkspace\CSharpWay\com.fileio\binary.txt";

        public static void WriteFile()
        {
            //delete if file present
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }

            // Create the file
            using (BinaryWriter bw = new BinaryWriter(File.Open(fpath, FileMode.Create)))
            {
                
                bw.Write("Welcome to Binary Writer");
                bw.Write(10);
                bw.Write(true);
                bw.Write(1.25);
            }
            Console.WriteLine("File Written Successfully");
        }




        public static void ReadFile()
        {
            Console.WriteLine("Reading File ...");
            if (File.Exists(fpath))
            {
                using (BinaryReader br = new BinaryReader(File.Open(fpath, FileMode.Open)))
                {
                    
                    Console.WriteLine("1:"+br.ReadString());
                    Console.WriteLine("2:"+br.ReadInt32());
                    Console.WriteLine("3:"+br.ReadBoolean());
                    Console.WriteLine("4:"+br.ReadDouble());
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
