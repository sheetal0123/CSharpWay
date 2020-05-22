using System;

//properties with constructor
namespace CSharpWay
{
    
    class MyAgeClass
    {
        public int age { get; set; }
        
        
        public MyAgeClass(int a)  //constructor
        {
            age = a;
        }
    }

    class MyAgeTestClass
    {
        static void main(String[] args)
        {
            MyAgeClass obj1 = new MyAgeClass(10);
            Console.WriteLine(obj1.age);
        }
    }
    
}
