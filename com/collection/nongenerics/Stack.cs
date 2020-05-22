using System;
using System.Collections;


namespace CSharpWay.com.collection
{

    class StackEg
    {

        public static void StackBasics()
        {
            Stack stk = new Stack();
            stk.Push("Welcome");
            stk.Push("To");
            stk.Push("Stack");
            Console.WriteLine("Counts : {0}", stk.Count);

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======= * ======= * ======= * =======");
        }



        public static void main(string[] args)
        {
            StackBasics();
        }

    }

}
