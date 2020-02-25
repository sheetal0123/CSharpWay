using System;
using System.Linq;

//range: used to generate number sequence
namespace CSharpWay
{
    class Range
    {
        static void main(String[] args)
        {
            // (start number, total data count)
            foreach (var el in Enumerable.Range(5, 10))
            {
                Console.Write(el + " ");
            }

            Console.WriteLine();

            // (start number, total data count)
            foreach (var el in Enumerable.Repeat(5, 10))
            {
                Console.Write(el + " ");
            }

            Console.WriteLine();

            foreach (var el in Enumerable.Reverse(Enumerable.Range(5, 10)))
            {
                Console.Write(el + " ");
            }
        }
    }
}
