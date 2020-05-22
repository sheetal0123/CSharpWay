using System;

/**
 * Custom Exception Rule:
 * ClassName should end with word "Exception"
 * Should implement three constructors
 * Should derived from Exception class
 */
namespace CSharpWay.com.adv.exception
{
    public class MyCustomException : Exception
    {
        public MyCustomException() 
        { 
            Console.WriteLine("****** No Arg ********"); 
        }

        public MyCustomException(string message) : base(message) 
        {
            Console.WriteLine("****** Single Arg ********");
        }

        public MyCustomException(string message, Exception innerexception) : base(message, innerexception)
        {
            Console.WriteLine("****** Multi Arg ********");
        }
    }

    class Programme
    {
        public static void main(string [] args)
        {

            string abc = "Mango";

            if (string.IsNullOrEmpty(abc))
            {
                throw new MyCustomException();
                //throw new MyCustomException("Msg123");
                //throw new MyCustomException("Msg456", new ArrayTypeMismatchException());
            }
            else
            {
                Console.WriteLine("String Val: "+ abc);
            }

        }
    }
}
