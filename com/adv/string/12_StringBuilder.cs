using System;
using System.Text;

namespace CSharpWay
{
    class StringBuilderEx
    {
        public static void TestSB()
        {
            System.Console.WriteLine("--------------------------");

            string str = "hello";

            StringBuilder sb = new StringBuilder(str);
            sb.Append(" Friends");
            sb.Append(" , Are you learning C#");

            Console.WriteLine (sb);
            System.Console.WriteLine("--------------------------");
        }

        public static void StringImmutable()
        {
            string name1 = "Bat";
            Console.WriteLine("Orig Str:" + name1);

            string name2 = name1.Replace('B', 'C');
            Console.WriteLine("Updated Str:" + name2);
            Console.WriteLine("Orig Str:" + name1); //remain same
            System.Console.WriteLine("--------------------------");
        }

        public static void StringBuilderMutable()
        {
            StringBuilder sb1 = new StringBuilder("Rat");
            Console.WriteLine("Orig sb:" + sb1);

            StringBuilder sb2 = sb1.Replace('R', 'M', 0, 1);
            Console.WriteLine("Updated sb:" + sb2);
            Console.WriteLine("Orig sb:" + sb1); // updated
            System.Console.WriteLine("--------------------------");
        }

        static void main(String[] args)
        {
            TestSB();
            StringImmutable();
            StringBuilderMutable();
        }
    }
}
