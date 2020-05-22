using System;
using System.Collections.Generic;

namespace CSharpWay
{
    //Tuples - Collection of Hetrogenous elements
    //Discard - We can filter tuples using underscore
    class Discards
    {
        static void main(String[] args)
        {
           var vals = (1, "a", 3, 4, 50.5f, 6);

            (int x, string y, _ , _, float z, _) = vals;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
