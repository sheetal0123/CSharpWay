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
            var words = ("Welcome", "to", "C#", "world");
            Console.WriteLine (words);

            Console.WriteLine("----------------------");
            Console.WriteLine(words.Item1);
            Console.WriteLine(words.Item3);

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
