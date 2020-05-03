using System;
using System.Collections;
using System.Linq;

/* Tuples has performance issues hence ValueTuples introduced in C# 7.0 (.net 4.7)

   ValueTuples are the value types (structures) rather than reference types (classes) 
   like Tuple and it will overcome the limitations of Tuple class.

*/
namespace CSharpWay
{
    class ValueTuples
    {

        public static void TuplesBasicList()
        {
            Console.WriteLine("======= * ======= * ======= * =======");
            var wordsList = ("Welcome", 2, "C#", "world");
            Console.WriteLine (wordsList);

            int intVal = wordsList.Item2;
            string strVal = wordsList.Item3;
            Console.WriteLine(intVal);
            Console.WriteLine(strVal);
            Console.WriteLine("======= * ======= * ======= * =======");
        }

        public static void NamedTuplesMap()
        {
            //similar to Map/Dictonary
            var emp = (fname: "Bob", lname: "Will", age: 40);
            
            Console.WriteLine(emp.fname);
            Console.WriteLine(emp.lname);
            Console.WriteLine(emp.age);
            Console.WriteLine("======= * ======= * ======= * =======");
        }


        public static void ValueTuplesInitialization()
        {
            var user1 = (1, "Sheetal", "Singh");
            ValueTuple<int, string, string, double> user2 = (2, "Dan", "Brown", 90.5);
            (int, string, string, double) user3 = (3, "Rob", "Cob", 50.5);

            Console.WriteLine(user1.Item1);
            Console.WriteLine(user2.Item2);
            Console.WriteLine(user3.Item3);
            Console.WriteLine("======= * ======= * ======= * =======");
        }

        //Value Tuple has no limits
        public static void ValueTuplesLimit()
        {
            var numbers = (1, "2", 3, "4", 5, 6.5 , true, 8, 9, 10, 11);
            Console.WriteLine("Tenth: " + numbers.Item10);
        }


        public static void DeconstructionEg()
        {
            var (Id, Name, Location, Percentage) = GetUserDetails();
            Console.WriteLine("#User Details#");
            Console.WriteLine("Id:{0}", Id);
            Console.WriteLine("Name:{0}", Name);
        }

        public static (int, string, string, double) GetUserDetails()
        {
            return (1, "Sheetal", "Singh", 80.8);
        }

        static void main(String[] args)
        {
            //TuplesBasicList();
            //NamedTuplesMap();
            //ValueTuplesInitialization();
            DeconstructionEg();
        }
    }
}





