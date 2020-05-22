//using System;
/*  
    # Topics:    
    1. Pls note using System has been comments  
     System.Console.WriteLine
    2. Comments, Var naming conventions
    3. C# is Case Sensitive
    4. class, namespace and .cs file name are all different
*/
namespace CSharpWay
{
    class Basics
    {
        static void main(string[] args)
        {
            /*
                 Welcome To C# Tutorial 
                 This is C# Multiline Comments   
             */
            // I am single line comments
            System.Console.WriteLine("======= * ======= * ======= * =======");


            //Note: C# is Case Sensitive
            string hello = "hello Martin";
            string Hello = "Hello Flower";
            System.Console.WriteLine (hello);
            System.Console.WriteLine (Hello);

            System.Console.WriteLine("======= * ======= * ======= * =======");

            string _hello = "hello Dan";
            string Hel10 = "Hello Brown";
            System.Console.WriteLine (_hello);
            System.Console.WriteLine (Hel10);

            System.Console.WriteLine("======= * ======= * ======= * =======");
        }
    }
}
