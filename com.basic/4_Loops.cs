using System;

namespace CSharpWay
{
    class Loops
    {
        static void main(string[] args)
        {
            Console.WriteLine("----------------------------------------------");

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("SrNo: " + i);
                i++;
            }


            Console.WriteLine("----------------------------------------------");

            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("SrNo: " + j);
            }

            Console.WriteLine("----------------------------------------------");
        }
    }
}
