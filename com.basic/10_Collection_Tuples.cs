using System;
using System.Linq;

//A tuple is an ordered, immutable list of heterogeneous data values
namespace CSharpWay
{
    class Tuples
    {
        public static void TuplesBasic()
        {
            Console.WriteLine("----------------------");
            var words = ("Welcome", 2, "C#", "world");
            Console.WriteLine (words);
            
            int a = words.Item2;
            string b = words.Item3;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("----------------------");
            //similar to Java HashMap
            var wordSet = (w1: "Dark", w2: "Deep", w3: "Forest");

            Console.WriteLine(wordSet.w1);
            Console.WriteLine(wordSet.w3);
            Console.WriteLine("----------------------");
        }

        static void main(String[] args)
        {
            TuplesBasic();
        }
    }
}
