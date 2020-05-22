using System;

/*
 * Delegate return and param shd be same as Method
 * Using delegate we can call multiple methods in one call
 * Kind of pointers in C++
 * 
 * Multiple method can be attached to single delegate method
 * If we call delegate method then all attached method will get execute
 */
namespace CSharpWay
{

    public delegate void DelegateMethod(int a, int b);

    class DelegateEg
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
            //Basic Func:
            DelegateEg obj1 = new DelegateEg();
            DelegateMethod del = obj1.AddMe;  // no param
            del(10, 20);
            del.Invoke(10, 20);  // same as above

            //Multi Cast
            DelegateEg obj2 = new DelegateEg();
            DelegateMethod del2 = obj2.AddMe;  
            del2 += obj2.SubMe;  // Appended
            del2(600, 400);
        }
    }
}
