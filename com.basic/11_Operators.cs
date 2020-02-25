using System;
using System.Collections.Generic;

namespace CSharpWay
{
    class Operators
    {
        public static void signOperator()
        {
            int a = 10;
            Console.WriteLine (a); //10
            Console.WriteLine(+a); //10
            Console.WriteLine(-a); //-10
            Console.WriteLine(-(-a)); //10
            Console.WriteLine(a++); //11
            Console.WriteLine(a--); //10
        }

        public static void castingOperatorAndOthers()
        {
            var isValid = false;

            if (!isValid)
            {
                float val = 5.5f;
                int num = (int) val;
                Console.WriteLine("Casting: " + num);
            }
        }

        public static void ArithematicOperators()
        {
            int a = 100;
            int b = 10;

            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);
        }

        static void Main(String[] args)
        {
            //signOperator();
            //castingOperatorAndOthers();
            ArithematicOperators();
        }
    }
}
