using System;

namespace CSharpWay
{

    /**
     * Two C# Types: Value and Reference Type
     * 
     * Value type stay on Stack memory
     * On passing value type to a method, copy has been sent
     * Hence on changing value orig value remain same
     * e.g. bool, int, double, enum, char etc
     * 
     * int num = 10;
     * Both num and 10 will get save in one memory location
     * 
     * Reference Type: 
     * string, class, delegates, arrays
     * Passing a refrence will pass address type and any change will
     * also change original value
     */
    class PassValueType
    {

        static void UpdateMe(int a, int b)
        {
            a = a * a;
            b = b * b;
            Console.WriteLine("Updated: "+a + " " + b);
        }

        static void main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine("Initial: "+num1 + " " + num2);
            UpdateMe(num1, num2);
            Console.WriteLine("After Update: "+num1 + " " + num2);
        }
    }
}
