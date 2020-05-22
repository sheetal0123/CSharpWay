using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace CSharpWay.com.fileio
{

    class DirectoryInfoEg
    {
        public static string dirpath = @"D:\MyCloud\myworkspace\CSharpWay\com.fileio\dir";

        public static void CreateDirectory()
        {
            DirectoryInfo di = new DirectoryInfo(dirpath);
            if (di.Exists)
            {
                Console.WriteLine("Directory Already Exists");
            }
            else
            {
                di.Create();
                Console.WriteLine("Directory Created Successfully");
            }
        }



        public static void main(String [] args)
        {
            CreateDirectory();
            
        }
    }
}
