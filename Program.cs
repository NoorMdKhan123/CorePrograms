using System;

namespace HarmonicSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            
            string sum = "1";
            Console.WriteLine("the nth series is");
            for(int i=2; i<num; i++)
            { 
                sum += "+(1/" + i + ")";
                
               
            }
            Console.WriteLine(sum);
            
        }
    }
}
