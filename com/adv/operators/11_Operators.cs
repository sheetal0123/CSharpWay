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

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }

        public static void booleanOperator()
        {
            int a = 10;
            int b = 20;
            int c = 30;

            if (c > b && b > a)
            {
                Console.WriteLine("Logical AND");
            }

            if (c == b || b > a)
            {
                Console.WriteLine("Logical OR");
            }
        }

        public static void compoundOperator()
        {
            int a = 10;
            Console.WriteLine(a += 5); // a = a+5
            Console.WriteLine(a *= 5); // a = a*5
            Console.WriteLine(a %= 5); // a = a%5
        }

        static void main(String[] args)
        {
            //signOperator();
            //castingOperatorAndOthers();
            //ArithematicOperators();
            //booleanOperator();
            compoundOperator();
        }
    }
}
