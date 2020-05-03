using System;

namespace AsIsOperator
{
    class BaseClass { }

    class DerivedClass : BaseClass { }

    class MyClass
    {
        public static void isOperator()
        {
            BaseClass baseObj = new BaseClass();
            DerivedClass derivedObj = new DerivedClass();

            Console.WriteLine(baseObj is BaseClass);
            Console.WriteLine(derivedObj is BaseClass);
            Console.WriteLine(baseObj is Object);
            Console.WriteLine(baseObj is DerivedClass);
            Console.WriteLine("======= * ======= * ======= * =======");
        }

        public static void asOperator()
        {
            object[] objects = new object[4];
            objects[0] = "C# World";
            objects[1] = 12;
            objects[2] = new BaseClass();
            objects[3] = null;

            for (int i = 0; i < objects.Length; i++)
            {
                string str = objects[i] as string; // converting
                //Console.Write("{0}:", i);

                if (str != null)
                {
                    Console.WriteLine (str);
                }
                else
                {
                    Console.WriteLine("not a string");
                }
            }
            Console.WriteLine("======= * ======= * ======= * =======");
        }

        static void main(string[] args)
        {
            isOperator();
            asOperator();
        }
    }
}
