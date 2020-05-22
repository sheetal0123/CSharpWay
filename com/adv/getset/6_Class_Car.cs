using System;


/**
 *  const : can be declared only once
 *  readonly: can be declared with default value like const +
 *            can also be updated using constructor (only)
 * 
 */
namespace CSharpWay
{
    class Car
    {
        public int topSpeed;
        public readonly string colour;
        public readonly string fuel = "Petrol";
        public const int TYRE_COUNT = 4;

        //fuel not parameterized
        public Car(int topSpeed, string colour)
        {
            this.topSpeed = topSpeed; //this required
            this.colour = colour;
        }


        public Car(int topSpeed, string clr, string fl)
        {
            this.topSpeed = topSpeed; 
            colour = clr;
            fuel = fl; // can update readonly inside constructor
        }

        public int getTopSpeed()
        {
            return topSpeed;
        }

    }

    class CarTest
    {
        static void main(String[] args)
        {
            Console.WriteLine("======= * ======= * ======= * =======");

            Car mini = new Car(150, "Yellow");
            Console.WriteLine("Top Speed : " + mini.getTopSpeed());
            Console.WriteLine("Colour : " + mini.colour);
            Console.WriteLine("Fuel : " + mini.fuel); //default value get picked
            Console.WriteLine("Tyre Count: " + Car.TYRE_COUNT); //Class name req



            Console.WriteLine("======= * ======= * ======= * =======");

            Car toyota = new Car(200, "Black", "Diesel");
            //toyota.fuel = "Diesel"; //compiler error
            toyota.topSpeed = 250; // non-readonly

            int spd = toyota.getTopSpeed();
            Console.WriteLine("Top Speed : " + spd);
            Console.WriteLine("Colour : " + toyota.colour);
            Console.WriteLine("Fuel : " + toyota.fuel); //updated in constructor
            Console.WriteLine("Tyre Count: " + Car.TYRE_COUNT); 

            Console.WriteLine("======= * ======= * ======= * =======");

            
        }
    }
}
