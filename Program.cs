using System;

namespace QuotientRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dividend number");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor number");
            int divisor = int.Parse(Console.ReadLine());
            int quoitent = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine(" the quoitent is"+ quoitent);
            Console.WriteLine(" the remainder is" + remainder);




        }
    }
}
