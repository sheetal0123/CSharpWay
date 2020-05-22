using System;
using System.Collections.Generic;

namespace CSharpWay
{
    class GenericClass<T>
    {
        public T msg;
        public void GenericMethod(T name, T location)
        {
            Console.WriteLine("Message: {0}", msg);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
        }
    }

    public class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("### Generics Example ###");
            //string
            GenericClass<string> gclass = new GenericClass<string>();
            gclass.msg = "Welcome to Genrics";
            gclass.GenericMethod("Sheetal", "Singh");
            Console.WriteLine("======= * ======= * ======= * =======");


            //int
            GenericClass<int> gclass2 = new GenericClass<int>();
            gclass2.msg = 1000;
            gclass2.GenericMethod(10, 20);
        }
    }
}
