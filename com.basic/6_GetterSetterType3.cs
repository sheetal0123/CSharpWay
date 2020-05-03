using System;

//getter + private setter with constructor
namespace CSharpWay
{
    
    class Emp
    {
        public int id { 
            get; 
            set; 
        }
        public string name { get; private set; }

        public Emp()
        {

        }

        public Emp(int i, string n)  
        {
            id = i;
            name = n; // constructor can set private fields
        }
        public override string ToString() => $"Object Values : {id} {name}";

    }

    class EmpTest
    {
        static void main(String[] args)
        {

            Console.WriteLine("======= * ======= * ======= * =======");

            Emp e1 = new Emp();
            e1.id = 1;
            //e1.name = "Bob";  // cannot access private member
            Console.WriteLine(e1);

            Console.WriteLine("======= * ======= * ======= * =======");

            Emp e2 = new Emp(2, "Dan");
            Console.WriteLine(e2);

            Console.WriteLine("======= * ======= * ======= * =======");

        }
    }
    
}
