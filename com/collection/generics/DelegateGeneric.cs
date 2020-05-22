using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpWay.com.collection.generics
{

    public delegate void DelegateGenMethod<T>(T a, T b);

    class DelegateGeneric
    {
        public void AddMe(int a, int b)
        {
            Console.WriteLine("Add Results: {0}", a + b);
            Console.WriteLine("======= * ======= * ======= * =======");
        }


        public void SubMe(int a, int b)
        {
            Console.WriteLine("Sub Results: {0}", a - b);
            Console.WriteLine("======= * ======= * ======= * =======");
        }

        static void main(string[] args)
        {
            DelegateGeneric obj = new DelegateGeneric();
            DelegateGenMethod<int> del = obj.AddMe; 
            del(10, 20);

            //another way to initialize
            DelegateGenMethod<int> del2 = new DelegateGenMethod<int>(obj.AddMe);
            del2(100, 200);
        }

    }
}
