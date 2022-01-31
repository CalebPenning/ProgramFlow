using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer = rnd.Next(50);

            Console.WriteLine(answer.ToString());



            int guess = new int();

            Console.WriteLine("Guess a number between 0 and 50!");

            while (guess != answer)
            {
                guess = Int32.Parse(Console.ReadLine());
                if (guess == answer)
                {
                    Console.WriteLine($"That's right! The answer was {answer}");
                }

                else
                {
                    Console.WriteLine($"{guess} isn't right. Try again!");
                }
            }
            Console.ReadLine();
        }
    }
}
