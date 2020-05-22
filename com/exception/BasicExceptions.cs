using System;

namespace CSharpWay
{
    class BasicExceptions
    {

        public static void SimpleTryCatch()
        {
            string abc = "hello";

            try
            {
                int a = Convert.ToInt16(abc);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("InvalidOperationException >>" + ex.StackTrace); // Most Useful
            }
            catch (FormatException ex)
            {
                Console.WriteLine("======= * ======= * ======= * =======");
                Console.WriteLine("FormatException >>" + ex.StackTrace); // Most Useful
                Console.WriteLine(">>" + ex.Message);
                Console.WriteLine(">>" + ex.HelpLink);
                Console.WriteLine(">>" + ex.InnerException);
                Console.WriteLine(">>" + ex.Data);
                Console.WriteLine(">>" + ex.Source);
            }
            finally
            {
                Console.WriteLine("======= * ======= * ======= * =======");
                Console.WriteLine("I will run always to clean up the resources");
                //e.g. to close any open stream obj
            }
        
        }

        static void main(string[] args)
        {
            SimpleTryCatch();

        }
    }
}
