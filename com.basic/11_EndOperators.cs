using System;
using System.Collections.Generic;

namespace CSharpWay
{
    class EndOperators
    {
        public static void EndOperatorsEg()
        {
            int[] intArray = { 0, 1, 2, 3, 4, 5 };

            //Console.WriteLine(intArray[^0]); //OutOfRange Ex
            Console.WriteLine(intArray[^1]);
            Console.WriteLine(intArray[^2]);

            string words = "we are learning end operator";
            Console.WriteLine(words[^1]);
        }

        static void main(String[] args)
        {
            EndOperatorsEg();
        }
    }
}
