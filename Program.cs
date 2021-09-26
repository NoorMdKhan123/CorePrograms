using System;

namespace ConsonantVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character to check if it's a conconant or vowel");
            char character = char.Parse(Console.ReadLine());
            
                if (character == 'a' || character == 'e' || character == 'i' ||
                    character == 'o' || character == 'u' || character == 'A' || character == 'E'
                    || character == 'I' || character == 'O' || character == 'U')
                {
                    Console.WriteLine("Enter charatcer is a vowel");
                }
                else
                {
                    Console.WriteLine("Enter charatcer is a consonant");
                }
            
        
        }
    }
}
