using System;
/*

    1. Integers can be specified in 3 different notations in C#: 
    decimal, hexadecimal, and binary. [no octal] 

    2. Underscore can be added in integer for readability
*/
namespace CSharpWay
{
    
    class HexaBinary
    {
        static void main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            int num1 = 31;
            int num2 = 0xA;     //10
            int num3 = 0b100;  //4

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
           
            Console.WriteLine("-----------------------------------");


            int num4 = 264_321_000;
            int num5 = 0x3_C;     //10
            int num6 = 0b_0110_000_100;  //4

            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine("-----------------------------------");
        }
    }
}
