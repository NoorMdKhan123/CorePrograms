using System;

namespace GreatestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("1st number is greatest among all three");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("2nd number is greatest among all three");
            }
            else
            {
                Console.WriteLine("3rd number is greatest among all three");

            }
        }
    }
}
