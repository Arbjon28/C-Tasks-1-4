using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine();
            Console.WriteLine("Guess the number between 1-10. (-1 -> To Quit)");
            Console.WriteLine();

            int number = 6;
            int userNum;

            while (true)
            {
                Console.Write("The Number:   ");
                userNum = int.Parse(Console.ReadLine());
                if (userNum == -1)
                {
                    Console.WriteLine("Bye!");
                    break;

                }
                else if (userNum <= 0 || userNum > 10)
                {
                    Console.WriteLine("Guess the number between 1-10!!!");
                }
                else if (userNum == number)
                {
                    Console.WriteLine("Congratulations! You Won!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }
        }
    }
}