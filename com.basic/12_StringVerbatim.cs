using System;

namespace CSharpWay
{
    class StringVerbatim
    {
        public static void EscapeChar()
        {
            string escapeMe = "C# is \t similar to \nJava";
            Console.WriteLine (escapeMe);
        }

        public static void NotToEscape()
        {
            string escapeMe = @"C# is \t similar to \nJava";
            Console.WriteLine (escapeMe);
        }

        public static void MultiLine()
        {
            string para =
            @"Dear Friends,
                Hope you are learning something useful ...
                Regards
                Sheetal Singh
            ";
            Console.WriteLine (para);
        }

        static void main(String[] args)
        {
            System.Console.WriteLine("--------------------------");
            EscapeChar();
            System.Console.WriteLine("--------------------------");
            NotToEscape();
            System.Console.WriteLine("--------------------------");
            MultiLine();
            System.Console.WriteLine("--------------------------");
        }
    }
}
