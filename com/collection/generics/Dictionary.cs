using System;
using System.Collections.Generic;

namespace CSharpWay
{
    class DictionaryExample
    {

        public static void DictionaryType1()
        {

            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("A", "Apple");
            map.Add("B", "Ball");
            map["C"] = "Cat";  // this can also be used
            map.Add("D", null);

            foreach (KeyValuePair<string, string> item in map)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }

            Console.WriteLine("======= * ======= * ======= * =======");

        }




        public static void DictionaryType2DuplicateKey()
        {

            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("A", "Alpha");
            map.Add("B", "Bravo");
            try
            {
                map.Add("A", "Alpha New");
            }
            catch (ArgumentException exp)
            {
                Console.WriteLine("Duplicate Key:=> " + exp.Message);
            }

            foreach (KeyValuePair<string, string> item in map)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }

            Console.WriteLine("======= * ======= * ======= * =======");
        }


        public static void DictionaryType3()
        {
            Dictionary<string, string> map = new Dictionary<string, string>()
                {
                    { "in", "India" },
                    { "us", "USA" },
                    { "es", "Spain" }
                };

            Console.WriteLine("Fetch Key Value: "+map["in"]);
            Console.WriteLine("Contains Key: " + map.ContainsKey("us"));
            Console.WriteLine("Contains Value: " + map.ContainsValue("Spain"));
            Console.WriteLine("======= * ======= * ======= * =======");


            foreach (string key in map.Keys)
            {
                Console.WriteLine(key + ": " + map[key]);
            }
            Console.WriteLine("======= * ======= * ======= * =======");


            foreach (var val in map.Values)
            {
                Console.WriteLine(val);
            }

        }



        public static void TryGetValEg()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("A", "Apple");
            map.Add("B", "Ball");

            string val = "";
            if (map.TryGetValue("AA", out val))
            {
                Console.WriteLine(val);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }



        static void main(String[] args)
        {
            DictionaryType1();
            //DictionaryType2DuplicateKey();
            //DictionaryType3();
            //TryGetValEg();
        }
    }
}  
