using System;

namespace SwapNumber
{
    class Swap
    {
        static void Main(string[] args)
        {
            int number1, number2, temprary;

            Console.Write("Enter the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            temprary = number1;
            number1 = number2;
            number2 = temprary;

            Console.WriteLine("After Swapping : ");
            Console.Write("First Number :{0} \n Second Number :{1}", number1, number2);

            Console.ReadKey();



        }
    }
}
