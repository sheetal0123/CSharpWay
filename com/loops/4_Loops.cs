using System;
using System.Collections.Generic;

/*
 * while, plain for loop
 */
namespace CSharpWay
{
    class Loops
    {

        public static void WhileLoop()
        {
            int i = 90;
            while (i <= 100)
            {
                Console.WriteLine("SrNo: " + i);
                i++;
            }
            Console.WriteLine("======= * ======= * ======= * =======");

        }


        public static void ForLoop()
        {
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("SrNo: " + j);

                if (j == 7)
                    break;
            }
            Console.WriteLine("======= * ======= * ======= * =======");

        }


        public static void ForEachLoop()
        {
            string[] arr = new string[] {"abc","def","ghi" };
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("======= * ======= * ======= * =======");


            List<string> ls = new List<string>();
            ls.Add("alpha");
            ls.Add("bravo");
            foreach (string str in ls)
            {
                Console.WriteLine(str);
            }
        }



        static void main(string[] args)
        {
            WhileLoop();
            ForLoop();
            ForEachLoop();
        }
    }
}
