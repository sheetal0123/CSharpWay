using System;

namespace CSharpWay
{
    class Exceptions_Overflow
    {
        public static void uncheckedOverflowEg()
        {
            int a = 2147483647;
            Console.WriteLine("Max Range of Int: " + a);

            int res = unchecked(a + 1);
            Console.WriteLine("Unchecked: " + res);
        }

        public static void overflowSaved()
        {
            int a = 2147483647;
            int res = checked(a + 1);
            Console.WriteLine("Checked: " + res);
        }


        public static void overflowSaved2()
        {
            checked
            {
                byte a = 254;
                Console.WriteLine (a); //254
                a++;
                Console.WriteLine (a); //255
                a++;
                Console.WriteLine (a); //System.OverflowException:
                a++;
                Console.WriteLine (a);
            }
        }


        static void main(String[] args)
        {
            Console.WriteLine("======= * ======= * ======= * =======");
            uncheckedOverflowEg();
            //overflowSaved();
            Console.WriteLine("======= * ======= * ======= * =======");
            //overflowSaved2();
            Console.WriteLine("======= * ======= * ======= * =======");
        }
    }
}
