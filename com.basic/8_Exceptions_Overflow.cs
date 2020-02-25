using System;

namespace CSharpWay
{
    class Exceptions_Overflow
    {
        //byte range 0 to 255
        public static void resetMethod()
        {
            Console.WriteLine("-----------------------");
            byte a = 254;
            Console.WriteLine (a); //254
            a++;
            Console.WriteLine (a); //255
            a++;
            Console.WriteLine (a); //0
            a++;
            Console.WriteLine (a); //1
            Console.WriteLine("-----------------------");
        }

        public static void checkedMethod()
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
            resetMethod();
            checkedMethod();
        }
    }
}
