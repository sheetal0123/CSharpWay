using System;
using System.Collections.Generic;

/**
 * 
 * 
 */
namespace CSharpWay
{
    public class ListEg
    {

        public static void BasicList()
        {
            List<string> wordList = new List<string> { "apple", "ball", "cat" };
            Console.WriteLine("Item at index 0: " + wordList[0]);

            foreach (var word in wordList)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("======= * ======= * ======= * =======");

        }



        public static void InitList()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            Console.WriteLine("Capacity: "+list.Capacity);
            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("======= * ======= * ======= * =======");
        }


        public static void AddRange()
        {
            List<int> listA = new List<int>();
            listA.Add(10);
            listA.Add(20);

            List<int> listB = new List<int>();
            listB.Add(30);

            Console.WriteLine("Contains: "+ listA.Contains(20));
            listA.AddRange(listB);
            listA.Insert(3, 40);
            listA.Insert(4, 50);
            listA.Remove(30);
            listA.RemoveAt(3);

            foreach (var v in listA)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("======= * ======= * ======= * =======");
        }




        static void main(String[] args)
        {
            BasicList();
            InitList();
            AddRange();
        }
    }
}
