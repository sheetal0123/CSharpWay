using System;

namespace CSharpWay
{
    class ReadValue
    {
        static void Main(String[] args)
        {
            Console.Write("What is your name?");
            string name = Console.ReadLine();
            
            Console.Write("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());
           
            Console.WriteLine("Hello "+ name+", its your "+ age + "th Birthday");
        }
    }
}
