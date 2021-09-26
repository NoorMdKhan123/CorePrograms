using System;

namespace TableProgram
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter power");
            int power = int.Parse(Console.ReadLine());
            int p = 1;
            Console.WriteLine("The Table of power 2 is : ");
       
            for(int i=1;i<=power;i++)
            {
                p = p * 2;
                Console.WriteLine("2^" +i+ "="+ p);
            }
        }
    }
}
