using System;
using System.Collections;
using System.Linq;

//A tuple is an ordered, immutable list of heterogeneous data values
namespace CSharpWay
{
    class Tuples
    {

        public static void TuplesInitialization()
        {
            Tuple<int, string, string> user1 = new Tuple<int, string, string>(1, "Sheetal","Singh");
            var user2 = new Tuple<int, string, string>(2, "Bob", "Bryan");
            var user3 = (3,"Tom", "Cat");

            Console.WriteLine(user1.Item1);
            Console.WriteLine(user2.Item2);
            Console.WriteLine(user3.Item3);
        }

        //Tuple Support Max 8 element | 8th is special place
        public static void TuplesMaxLimit()
        {
            var a = new Tuple<int, int, int, int, int, int, int>(10, 20, 30, 40, 50, 60, 70);
            Console.WriteLine("Seventh: "+a.Item7);

            //compliler error : Till Item 7 supported 
            //var b = new Tuple<int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8);
            //Console.WriteLine("Eighths: " + b.Item8);
        }


        public static void TuplesCreateMethod()
        {
            var user1 = Tuple.Create(1, "Sheetal", "Singh");
            Console.WriteLine(user1.Item2);

            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7);
            Console.WriteLine(numbers.Item7); // 7
            //Console.WriteLine(numbers.Item8); 

        }


        // In case we want to add more element then 8th place can be used
        // On 8th position new Tuples can be added i.e. Nested Tuples
        public static void TuplesWithMoreElements()
        {
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13, 14));
            Console.WriteLine(numbers.Item7); // 7
            
            
            //Console.WriteLine(numbers.Item8); // Compliler Error
            Console.WriteLine(numbers.Rest);  // ((8, 9, 10, 11, 12, 13, 14))
            Console.WriteLine(numbers.Rest.Item1);  // (8, 9, 10, 11, 12, 13, 14)

            Console.WriteLine(numbers.Rest.Item1.Item1);  // 8
            Console.WriteLine(numbers.Rest.Item1.Item7);  // 14
        }


        static void main(String[] args)
        {
            //TuplesInitialization();
            //TuplesMaxLimit();
            //TuplesCreateMethod();
            TuplesWithMoreElements();
        }
    }
}








/*private static IEnumerable TupleToEnumerable(object tuple)
{
    return tuple.GetType()
                .GetProperties()
                .Select(property => property.GetValue(tuple));
}
*/