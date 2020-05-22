using System;

namespace CSharpWay
{
    /**
     * Incase we are not importing/using 'System' namespace then we need to write complete line
     * System.Console.WriteLine
     * Otherwise  only 'Console.WriteLine' is sufficient
     */
    class TypeBasic
    {

        public static void simpleVars()
        {
            //Diff var types
            int age_new = 35;
            float price = 30.5f;
            double priceInDouble = 50.5;
            bool flag = true;
            string str = "Hello C#";
            const string INR = "RS"; //constant can't be changed later

            //INR = "DOLLAR";
            Console.WriteLine(age_new);
            Console.WriteLine(price);
            Console.WriteLine(priceInDouble);
            Console.WriteLine(flag);
            Console.WriteLine(str);
            Console.WriteLine(INR);
            Console.WriteLine("======= * ======= * ======= * =======");
        }

        public static void algebricCalc()
        {
            //Algebric functions  +  - / *
            int a = 10;
            int b = 20;
            int c = a + b;
            System.Console.WriteLine("Sum: " + c);

            int m = 10;
            int n = 20;
            float o = (float)m / n;
            System.Console.WriteLine("Div: " + o);


            float p = 0.5f;
            double q = 0.5;
            if (p == q)
            {
                Console.WriteLine("P & Q are equal");
            }
            else
            {
                Console.WriteLine("P & Q are un-equal");
            }

            Console.WriteLine("======= * ======= * ======= * =======");
        }

        public static void floatTest()
        {
            float a = 2.234f; // 4 byte
            double b = 2.234; //8 byte; double is default value
            decimal c = 2.234m; // 16 byte

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
        }

        static void main(string[] args)
        {
            simpleVars();
            algebricCalc();
            floatTest();
        }
    }
}
