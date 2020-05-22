using System;

namespace CSharpWay
{
    /**
     * var : type checking happen at compile time
     * dynamic : type checking happen at run time
     * dymamic introduced in C# 4.0
     * 
     */
    class TypeDynamic
    {
        public static void DynamicBasic()
        {
            dynamic n = "Peter";
            dynamic a = 23;
            dynamic fl = true;

            System.Console.WriteLine(n.GetType());
            System.Console.WriteLine(a.GetType());
            System.Console.WriteLine(fl.GetType());
            System.Console.WriteLine("{0} is {1} years old", n, a);
            Console.WriteLine("======= * ======= * ======= * =======");
        }

        //dynamic param
        public static void PrintMe(dynamic dy)
        {
            Console.WriteLine(dy);
        }


        public static void DynamicMethod()
        {

            PrintMe(10);
            PrintMe("Any String");
            PrintMe(true);
            Console.WriteLine("======= * ======= * ======= * =======");

        }

        static void main(string[] args)
        {
            DynamicBasic();
            DynamicMethod();
        }
    }
}
