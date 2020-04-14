using System;
using System.Collections.Generic;

namespace CSharpWay
{
    class DictionaryExample
    {
        public static void DictionaryEg()
        {
            Console.WriteLine("----------------------");

            var domains =
                new Dictionary<string, string>()
                {
                    { "in", "India" },
                    { "us", "USA" },
                    { "es", "Spain" }
                };

            Console.WriteLine(domains["in"]);

            Console.WriteLine("----------------------");
        }

        static void main(String[] args)
        {
            DictionaryEg();
        }
    }
}
