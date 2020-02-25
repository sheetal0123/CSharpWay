using System;

namespace CSharpWay
{
    class Conversions
    {
        public static void str2Int()
        {
            Console.WriteLine("-----------------------------------");

            string x = "10";
            string y = "20";

            int convertedX = Convert.ToInt16(x);
            int convertedY = Int32.Parse(y);
            int sum = convertedX + convertedY;
            Console.WriteLine("String -> int Convertion: " + sum);
        }

        static void main(string[] args)
        {
            Console.WriteLine("-----------------------------------");

            //int to Str
            int i = 10;
            string strI = i.ToString();

            string s1 = "This is implicit conversion: " + i;
            string s2 = "This is explicit conversion: " + strI;
            Console.WriteLine("int -> Str : " + s1);
            Console.WriteLine("int -> Str : " + s2);

            Console.WriteLine("-----------------------------------");

            //int -> bool
            // 0 is False rest everything is True
            int a = 0;
            int b = -3;
            int c = 10;
            bool flagA = Convert.ToBoolean(a);
            bool flagB = Convert.ToBoolean(b);
            bool flagC = Convert.ToBoolean(c);
            Console.WriteLine(a + " -> " + flagA);
            Console.WriteLine(b + " -> " + flagB);
            Console.WriteLine(c + " -> " + flagC);
            Console.WriteLine("-----------------------------------");
        }
    }
}
