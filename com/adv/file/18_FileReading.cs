using System;
using System.IO;

namespace CSharpWay
{
    class ReadFile
    {
        public static void ReadCSVFile()
        {
            string textFile = "D:\\MyCloud\\myworkspace\\CSharpWay\\com.adv\\file\\abc.csv";
            if (File.Exists(textFile))
            {
                using (StreamReader file = new StreamReader(textFile))
                {
                    int counter = 0;
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string str = line;
                        counter++;
                        
                        String testCaseName = line.Split(",")[0];
            			String rawCSVData = line.Split(",")[1];

                        Console.WriteLine(testCaseName);
                        Console.WriteLine(rawCSVData);
                    }
                    file.Close();
                }
            }
        }

        static void main(String[] args)
        {
            ReadCSVFile();
        }
    }
}
