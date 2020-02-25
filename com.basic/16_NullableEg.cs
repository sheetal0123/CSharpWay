using System;

//Special Data Type: Nullable
//It can contain normal values + null
namespace CSharpWay
{
    class NullableEg
    {
        public static void defineNullType1()
        {
            Nullable<int> age = null;
            Console.WriteLine(">>" + age + "<<");
            Console.WriteLine(age.HasValue);
        }

        public static void defineNullType2()
        {
            int? age = null;
            Console.WriteLine(age.HasValue);
        }

        public static void nullTypeExample()
        {
            Console.WriteLine("-----------------------");
            int? num1 = 45;
            int? num2 = null;
            Console.WriteLine("NullNum1: " + num1);
            Console.WriteLine("NullNum2: " + num2);

            Console.WriteLine("-----------------------");
            double d1 = 30.5;
            double? d2 = new double?();
            Console.WriteLine("NullDouble1: " + d1);
            Console.WriteLine("NullDouble1: " + d2);

            Console.WriteLine("-----------------------");
            bool b1 = true;
            bool? b2 = new bool?();
            Console.WriteLine("NullBool1: " + b1);
            Console.WriteLine("NullBool2: " + b2);

            Console.WriteLine("-----------------------");
        }

        //If first val is null then second will be picked
        //else first will be picked
        public static void nullCoalescingOperator()
        {
            int? num1 = 100;
            int? num2 = null;

            int x = num1 ?? 500;
            int y = num2 ?? 500;

            Console.WriteLine(">>" + x);
            Console.WriteLine(">>" + y);
        }

        static void main(String[] args)
        {
            defineNullType1();
            defineNullType2();
            nullTypeExample();

            nullCoalescingOperator();
        }
    }
}
