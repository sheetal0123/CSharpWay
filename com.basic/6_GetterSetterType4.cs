using System;

//custom properties i.e. getter, setter
namespace CSharpWay
{

    class ElectionAge
    {
        private int age;

        public bool ValidInputProp   // first property
        {
            get
            {
                return age > 0;
            }
        }


        public int ValidAgeForVoteProp   // second property
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18)     //value is reserverd word
                {
                    age = value;
                    Console.WriteLine("Can vote");
                }
                else
                {
                    Console.WriteLine("Under Age for vote");
                }
            }
        }
    }   

    class ElectionAgeTest
    {
        static void main(String[] args)
        {
            Console.WriteLine("======= * ======= * ======= * =======");

            var obj = new ElectionAge();  // var can hold class obj
            obj.ValidAgeForVoteProp = 20; // calling prop2 setter
            Console.WriteLine("Valid Input: " + obj.ValidInputProp); // calling prop1 getter
            Console.WriteLine("Current Age : "+ obj.ValidAgeForVoteProp); // calling prop2 getter

            Console.WriteLine("======= * ======= * ======= * =======");
        }
    }
    
}
