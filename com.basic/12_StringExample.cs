using System;

//String Formatting
//String Interpolation
namespace CSharpWay
{
    class StringExample
    {
        public static void BasicOperations()
        {
            System.Console.WriteLine("--------------------------");
            string s1 = "Hello";
            string s2 = "World";
            string result = s1 + " : " + s2;
            int len = s1.Length;
            bool flag = s1.Equals(String.Empty);
            Console
                .WriteLine("String {0} has {1} length and status is {2}",
                s1,
                len,
                flag);
            System.Console.WriteLine (result);

            System.Console.WriteLine("--------------------------");
            string lang = "language";
            Console.WriteLine("Index: " + lang.IndexOf('a'));
            Console.WriteLine("Last Index: " + lang.LastIndexOf('a'));
        }

        public static void StringFormatting()
        {
            System.Console.WriteLine("--------------------------");
            string name = "Sheetal";
            int age = 35;

            System.Console.WriteLine("--------------------------");

            //String Formating, index based
            string msg1 = string.Format("{0} is {1} years old.", name, age);

            Console.WriteLine (msg1);
            string msg2 = string.Format("{1} is {0} age", name, age);
            Console.WriteLine (msg2);


            System.Console.WriteLine("--------------------------");
        }

        public static void StringInterpolation()
        {
            string name = "Dan";
            int age = 30;

            //String Interpolation
            string msg2 = $"{name} is {age} years old.";
            Console.WriteLine (msg2);

            System.Console.WriteLine("--------------------------");
        }

        public static void StringComparision()
        {
            string str1 = "Apple";
            string str2 = "apple";
            string str3 = "apple";

            Console.WriteLine(str2 == str3);
            Console
                .WriteLine("Ignore Case:" + string.Compare(str1, str2, true));
            Console
                .WriteLine("Match Exact:" + string.Compare(str1, str2, false));
        }

        public static void JoinAndSplit()
        {
            var items =
                new string[] { "world", "flowers", "beautiful", "peace" };

            var langs = string.Join(",", items);
            Console.WriteLine (langs);

            string[] langs2 = langs.Split(',');

            foreach (string lang in langs2)
            {
                Console.WriteLine (lang);
            }
        }

        public static void CopyAndClone()
        {
            string str = "apple";

            string cloned = (string) str.Clone(); //ref
            string copied = "todo";//string.Copy(str); // new instance (depricateds)

            Console.WriteLine(str.Equals(cloned)); //T
            Console.WriteLine(str.Equals(copied)); //T

            Console
                .WriteLine("Cloned Reference Chk: " +
                ReferenceEquals(str, cloned)); //T
            Console
                .WriteLine("Copy Reference Chk: " +
                ReferenceEquals(str, copied)); //F
        }

        static void main(String[] args)
        {
            //BasicOperations();
            StringFormatting();
            //StringInterpolation();
            //StringComparision();
            //JoinAndSplit();
            //CopyAndClone();
        }
    }
}
