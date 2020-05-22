using System;

namespace CSharpWay
{

    class TypeVar
    {

        public static void VarBasicCheck()
        {
            Console.WriteLine("======= * ======= * ======= * =======");

            //var type automatically assigned by C# compiler
            //var can hold int, string , list etc
            var name = "Peter";
            var age = 23;

            System.Console.WriteLine(name.GetType());
            System.Console.WriteLine(age.GetType());
            System.Console.WriteLine("{0} is {1} years old", name, age);
            Console.WriteLine("======= * ======= * ======= * =======");
        }


        public static void VarObj()
        {
            //Anonymous Object
            var userInfo = new
            {
                Id = 1,
                Name = "Mr Stone",
                IsActive = true
            };

            Console.WriteLine("Id:" + userInfo.Id);
            Console.WriteLine("Name:" + userInfo.Name);
            Console.WriteLine("IsActive:" + userInfo.IsActive);
        }

        static void main(string[] args)
        {
            VarBasicCheck();
            VarObj();
        }
    }
}
