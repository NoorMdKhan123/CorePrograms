using System;

namespace LeapYearProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check");
            int year = int.Parse(Console.ReadLine());
            if( ((year % 4 == 0) && (year % 100 != 0 )) || (year % 400 == 100))
                    {
                Console.WriteLine("Year is a leap yeaar");
            }
            else
                {
                Console.WriteLine("year is not a leap year");

            }
        }
    }
}
