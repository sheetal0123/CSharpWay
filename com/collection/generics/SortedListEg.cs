using System;
using System.Collections.Generic;

/**
 * Sorted KV pair based on Key
 * 
 */
namespace CSharpWay
{
    public class SortedListEg
    {

        public static void BasicSortedList()
        {
            SortedList<int, string> sList = new SortedList<int, string>();
            sList.Add(2, "Two");
            sList.Add(3, "Three");
            sList.Add(1, "One");
            sList[4] = "Four";

            foreach (KeyValuePair<int, string> item in sList)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }

            //Exception on adding same key
            try
            {
                sList.Add(2, "NewValue");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("======= * ======= * ======= * =======");
        }




        static void main(String[] args)
        {
            BasicSortedList();
        }
    }
}
