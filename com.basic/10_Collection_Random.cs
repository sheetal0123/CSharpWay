using System;

//using System.Linq;
//range: used to generate random number
namespace CSharpWay
{
    class RandomEg
    {
        static void main(String[] args)
        {
            Console.WriteLine("-------------------------");
            Random random = new Random();
            int i = random.Next(0, 2);
            Console.WriteLine("Given Random Number: " + i);
            bool flag = Convert.ToBoolean(i);

            if (flag)
            {
                Console.WriteLine("Its 1");
            }
            else
            {
                Console.WriteLine("Its 0");
            }

            Console.WriteLine("-------------------------");

            int j = random.Next(50, 60);
            Console.WriteLine("Random Number between 50 to 59: " + j);

            int k = random.Next(5);
            Console.WriteLine("Random Number between 0 to 4: " + k);

            int m = random.Next(); // 32 bit
            Console.WriteLine("Random Number >=0 :  " + m);
            Console.WriteLine("-------------------------");
        }
    }
}
