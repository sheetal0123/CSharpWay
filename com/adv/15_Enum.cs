using System;

namespace CSharpWay
{
    enum Days
    {
        Sunday,
        Monday,
        Tueday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum Seasons : int
    {
        Spring = 100,
        Summer = 200,
        Autumn = 300,
        Winter = 400
    }

    class EnumurationsEg
    {
        //Enum with Default Values
        public static void EnumWithDefaultValues()
        {
            Console.WriteLine("--------------------------");
            Days day = Days.Sunday;

            if ((day == Days.Sunday) || (day == Days.Saturday))
            {
                Console.WriteLine("Its Weekend...Party Hard");
            }

            Console.WriteLine("------------------------");

            int WeekdayStart = (int) Days.Monday;
            int WeekdayEnd = (int) Days.Friday;
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);

            Console.WriteLine("------------------------");

            foreach (Days d in Enum.GetValues(typeof (Days)))
            {
                Console.WriteLine((int) d + " : " + d);
            }
            Console.WriteLine("--------------------------");
        }

        public static void EnumWithDefinedValues()
        {
            Seasons s1 = Seasons.Winter;
            Seasons s2 = Seasons.Summer;

            Console.WriteLine("Winter: " + (int)s1);
            Console.WriteLine("Summer: " + s2);
        }

        static void main(String[] args)
        {
              EnumWithDefaultValues();
            EnumWithDefinedValues();
        }
    }
}
