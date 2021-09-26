using System;

namespace FlipCoin1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no of times to flip coin");
            int NumberofFlips = int.Parse(Console.ReadLine());

            int headCount = 0;
            int tailCount = 0;
            int headPercentage = 0;
            int tailPercentage = 0;


            for (int i = 0; i < NumberofFlips; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(2);
                Console.WriteLine("Random numbers got generated " + randomNumber);
                if (randomNumber == 1)
                {
                    headCount++;
                }
                else if (randomNumber == 0)
                {
                    tailCount++;


                }
            }
            Console.WriteLine("head cousnt is" + headCount);
            Console.WriteLine("tail count is " + tailCount);
            Console.WriteLine("number of flip is" + NumberofFlips);

            headPercentage = ((headCount * 100) / NumberofFlips);
            tailPercentage = ((tailCount * 100) / NumberofFlips);

            Console.WriteLine("the % count of head is :" + headPercentage);
            Console.WriteLine("the % count of tail is :" + tailPercentage);
        }
    
    }
}
