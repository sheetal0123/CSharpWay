using System;

//String Formatting
//String Interpolation
namespace CSharpWay
{
    class Date
    {
        static void main(String[] args)
        {
            Console.WriteLine("----------------------------------------");
            DateTime born = DateTime.Parse("January 23, 1985");
            Console.WriteLine (born);
            string yyyy = string.Format("{0:yyyy}", born);
            Console.WriteLine("He was born in => {0}", yyyy);

            string dd = string.Format("{0:dd}", born);
            Console.WriteLine("He was born in => {0}", dd);

            Console.WriteLine("----------------------------------------");

            DateTime todaysDate = DateTime.Now.Date;
            int day = todaysDate.Day;
            int month = todaysDate.Month;
            int year = todaysDate.Year;
            Console.WriteLine(day + "|" + month + "|" + year);

            Console.WriteLine("----------------------------------------");

            DateTime date = DateTime.Now;
            var formatedDate = date.ToString("yyyy-MM-dd");
            Console.WriteLine (formatedDate);

            Console.WriteLine("----------------------------------------");

            DateTime now = DateTime.Now;
            Console.WriteLine(now.Month); // Month Count i.e. 2
            Console.WriteLine(now.ToString("MMM")); // Feb
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Today is {0}", DateTime.Today.ToString("M-d")); //2-19

            Console.WriteLine("----------------------------------------");

            DateTime now1 = DateTime.Now;
            Console.WriteLine($"Hello, Today is {now.DayOfWeek}, its {now:HH:mm} now");
            Console.WriteLine("----------------------------------------");

        }
    }
}
