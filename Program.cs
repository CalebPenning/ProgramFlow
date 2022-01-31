using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    class Program
    {
        static int GetGuess(string guess)
        {
            try 
            {
                int num = Int32.Parse(guess);
                return num;
            }

            catch (Exception e)
            {
                Console.WriteLine($"ERROR!!!!! {e.Message}");
                return 0;
            }
            
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer = rnd.Next(50);

            Console.WriteLine(answer.ToString());



            int guess = new int();

            Console.WriteLine($"initial guess = {guess}");

            Console.WriteLine("Guess a number between 0 and 50!");

            while (guess != answer)
            {
                guess = GetGuess(Console.ReadLine());
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
