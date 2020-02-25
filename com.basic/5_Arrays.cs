using System;

namespace CSharpWay
{
    class Arrays
    {
        public static void intArray()
        {
            int[] arrayInt = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.WriteLine("Int Array : " + arrayInt[i]);
            }
            Console.WriteLine("-------------------");
        }

        public static void strArray()
        {
            string[] arrayStr = new string[] { "aa", "bb", "cc" };
            string word = arrayStr[0];
            Console.WriteLine("Word: " + word);

            for (int i = 0; i < arrayStr.Length; i++)
            {
                Console.WriteLine("String Array : " + arrayStr[i]);
            }
            Console.WriteLine("-------------------");
        }

        public static void charArray()
        {
            char[] chArray = { 'h', 'e', 'l', 'l', 'o' };

            for (int i = 0; i < chArray.Length; i++)
            {
                Console.WriteLine("Char Array : " + chArray[i]);
            }
        }

        static void main(string[] args)
        {
            intArray();
            strArray();
            charArray();
        }
    }
}
