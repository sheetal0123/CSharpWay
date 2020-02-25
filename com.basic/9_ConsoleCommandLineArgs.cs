using System;

namespace Epam.Work.Automater
{
    class CommandLineArgs
    {
        static void main(String[] args)
        {
            Console.WriteLine("Enter few argument, space separated: ");
            //dotnet run 1 a bc

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
