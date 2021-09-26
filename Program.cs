using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Enter the number to check if it's even or odd");
            int number = int.Parse(Console.ReadLine());
            if(number%2 == 0)
            {
                Console.WriteLine("the entered number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }

    }
}
