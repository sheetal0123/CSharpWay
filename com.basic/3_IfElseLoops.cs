using System;

namespace CSharpWay
{
    class IfElseLoops
    {
        static void main(string[] args)
        {
            Console.WriteLine("======= * ======= * ======= * =======");

            int a = 10;
            int b = 10;
            if (a == b)
            {
                Console.WriteLine("Var  r equal");
            }
            else
            {
                Console.WriteLine("Var r not equal");
            }

            Console.WriteLine("======= * ======= * ======= * =======");

            int m = 10;
            int n = 20;
            if (m == n)
            {
                Console.WriteLine("Number are equal");
            }
            else if (m != n)
            {
                Console.WriteLine("Number are unequal");
            }

            Console.WriteLine("======= * ======= * ======= * =======");

            int num = 5;
            switch (num)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 5:
                    Console.WriteLine("Case 5");
                    break;
                default:
                    Console.WriteLine("Default Case");
                    break;
            }

            Console.WriteLine("======= * ======= * ======= * =======");
        }
    }
}
