using System;

//String Formatting
//String Interpolation
namespace CSharpWay
{
    class CharEg
    {
        public static void StrToChar()
        {
            string str = "world";
            char c = str[0];
            Console.WriteLine (c);

            System.Console.WriteLine("--------------------------");

            foreach (char ch in str)
            {
                Console.Write(ch + " -> ");
            }
            System.Console.WriteLine("\n--------------------------");

            string str2 = "welcome to C#";
            char[] charArray = str2.ToCharArray();
            foreach (char ch in charArray)
            {
                Console.Write(ch + " -> ");
            }
            System.Console.WriteLine("\n--------------------------");
        }

        public static void CharToStr()
        {
            char[] charArray = { 'a', 'b', 'c' };
            string abc = new string(charArray);
            Console.WriteLine (abc);
            System.Console.WriteLine("--------------------------");
        }

        static void main(String[] args)
        {
            StrToChar();
            CharToStr();
        }
    }
}
