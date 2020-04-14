using System;

namespace CSharpWay
{
    class RangeOperator
    {
        // [start_included to end_not_included]
        public static void RangeOperatorEg()
        {
            int[] intArray = { 10, 11, 12, 13, 14, 15 };
            string filteredString = String.Join("#",intArray[1..4]);
            int [] filteredArray = intArray[1..4];
            Console.WriteLine(filteredString);

            for (int i = 0; i < filteredArray.Length; i++){
                Console.WriteLine(filteredArray[i]);
            }

            Console.WriteLine("-----------------------");
        }


        public static void RangeOperatorEg2()
        {
            int[] intArray = { 10, 20, 30, 40, 50 };
            int [] filteredArray = intArray[..^1]; // 0 to end operator
            
            for (int i = 0; i < filteredArray.Length; i++){
                Console.WriteLine(filteredArray[i]);
            }

            Console.WriteLine("-----------------------");
        }


        public static void RangeOperatorEg3()
        {
            int[] intArray = { 10, 20, 30, 40, 50 };
            int [] filteredArray = intArray[3..]; // index to end
            
            for (int i = 0; i < filteredArray.Length; i++){
                Console.WriteLine(filteredArray[i]);
            }

            Console.WriteLine("-----------------------");
        }



        static void main(String[] args)
        {
//            RangeOperatorEg();
//            RangeOperatorEg2();
              RangeOperatorEg3();
        }
    }
}
