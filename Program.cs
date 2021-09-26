using System;

namespace Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number whose factors has to be find");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The factors are : ");
            for (int i = 2; num > 1; i++)
            {
                
                while (num % i == 0)
                {
                    
                    Console.Write(" "+i+ " ");

                  num /= i;

                }

            }
          
        }
    }
}
