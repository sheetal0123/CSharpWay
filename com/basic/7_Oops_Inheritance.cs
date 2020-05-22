using System;

namespace CSharpWay
{
    class Animal
    {
        int legs = 4;
        string living = "Land";

        public string getLiving()
        {
            return living;
        }

        public int getLegCount()
        {
            return legs;
        }
    }

    class Dog : Animal
    {
        static void main(String[] args)
        {
            Dog obj = new Dog();
            Console
                .WriteLine("Dog lives on : " +
                obj.getLiving() +
                "  with " +
                obj.getLegCount() +
                " legs generally");
        }
    }
}
