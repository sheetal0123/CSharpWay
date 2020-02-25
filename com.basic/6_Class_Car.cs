using System;

namespace CSharpWay
{
    class Car
    {
        int topSpeed;

        string colour;

        public Car(int topSpeed, string c)
        {
            this.topSpeed = topSpeed;
            colour = c;
        }

        public int getTopSpeed()
        {
            return topSpeed;
        }

        public string getColour()
        {
            return colour;
        }

        public void setPaint(string newColour)
        {
            colour = newColour;
        }
    }

    class CarTest
    {
        static void main(String[] args)
        {
            Car toyota = new Car(200, "Black");
            int spd = toyota.getTopSpeed();
            string clr = toyota.getColour();
            Console.WriteLine("Top Speed is: " + spd);
            Console.WriteLine("Colour is: " + clr);

            toyota.setPaint("Red");
            string newClr = toyota.getColour();
            Console.WriteLine("New Colour is: " + newClr);
        }
    }
}
