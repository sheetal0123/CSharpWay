using System;
using System.Buffers;
using System.Collections;


namespace CSharpWay.com.collection
{
    //Grow Dynamically
    class ArrayListEg
    {

        public static void Basic1()
        {
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add("Twenty");
            myList.Add(30);

            Console.WriteLine("Count : " + myList.Count);
            Console.WriteLine("Capacity : " + myList.Capacity); // max no can be hold

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======= * ======= * ======= * =======");

        }


        public static void Basic2()
        {
            ArrayList myListMain = new ArrayList() { 1, "Two" }; ;
            ArrayList myListSub = new ArrayList() { 3, "Four" }; ;
            myListMain.AddRange(myListSub);

            int one = (int)myListMain[0];
            string two = (string)myListMain[1];
            Console.WriteLine("Element at 0: " + one);
            Console.WriteLine("Element at 1: " + two);
            Console.WriteLine("======= * ======= * ======= * =======");

        }


        public static void SimpleOperations()
        {
            ArrayList list = new ArrayList() { 1, "Two" }; ;
            list.Insert(2, "Three");
            list.Insert(3, "Four");

            list.Remove("Two");
            list.RemoveAt(0);
            bool flag = list.Contains("Four");
            Console.WriteLine("Contains Check: "+flag);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======= * ======= * ======= * =======");

        }
        public static void main(string[] args)
        {
            Basic1();
            Basic2();
            SimpleOperations();
        }

    }

}
