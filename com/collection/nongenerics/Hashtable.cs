using System;
using System.Collections;

namespace CSharpWay
{

    class HashtableEg
    {

        public static void BasicEg1()
        {
            Console.WriteLine("======= * ======= * ======= * =======");
            Hashtable htbl = new Hashtable();
            htbl.Add("A", "Aplpe");
            htbl.Add("B", "Boy");
            htbl.Add(1, 20.5);
            htbl[10] = "Zebra"; // 10 will be key

            try
            {
                htbl.Add("B", "Ball");
            }
            catch
            {
                Console.WriteLine("exception:  duplicate key");
            }

            Console.WriteLine("\nk-v pair");
            foreach (DictionaryEntry item in htbl)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }

            Console.WriteLine("======= * ======= * ======= * =======");
        }



        public static void BasicEg2()
        {
            Hashtable ht = new Hashtable(){
                                {"A", "Stay"},
                                {"B", "Home"},
                                {"C", "Stay"},
                                {"D", "Safe"},
                            };
            Console.WriteLine("*********Keys Value********");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+" : "+ item.Value);
            }


            Console.WriteLine("*********Keys********");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("Key = {0}", item);
            }

            Console.WriteLine("*********Values********");
            foreach (var item in ht.Values)
            {
                Console.WriteLine("Value = {0}", item);
            }
        }




        static void main(string[] args)
        {
            BasicEg1();
            BasicEg2();
        }
    }
}
