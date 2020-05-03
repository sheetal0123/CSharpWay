using System;

namespace CSharpWay
{
    class Exceptions
    {
        static void main(String[] args)
        {
            string abc = "hello";

            try
            {
                int a = Convert.ToInt16(abc);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception caught:  " + e.StackTrace);
            }
        }
    }
}
