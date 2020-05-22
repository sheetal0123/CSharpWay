using System;
using System.Collections.Generic;

namespace CSharpWay
{
    class GenericMethodEg
    {

        public static void PrintMe<T>(T a, T b)
        {
            Console.WriteLine("I am of Type:  "+a.GetType());
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("======= * ======= * ======= * =======");

        }


        static void main(string[] args)
        {
            PrintMe<int>(10, 20);
            PrintMe(50, 60);

            PrintMe("Alpha", "Beta");
        }
    }

}
