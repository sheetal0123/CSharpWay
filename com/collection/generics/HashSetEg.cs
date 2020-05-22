using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpWay.com.collection.generics
{
    class HashSetEg
    {

        public static void Basic()
        {
            HashSet<int> hset = new HashSet<int>();
            hset.Add(10);
            hset.Add(20);
            hset.Add(10);
            hset.Add(20);

            foreach (int item in hset)
            {
                Console.WriteLine(item);
            }
        }


        public static void main(string [] args)
        {
            Basic();
        }
    }
}
