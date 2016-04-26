using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame4_26
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome and Guess a Number!");
            run();


        }

        static bool IsValid(int xchecker, int xLimit = 20)
        {
            bool valid = false;
            // how do we check if it's valid???
            if (xchecker >= 0 && xchecker < xLimit)
            {
                valid = true;
            }
            return valid;
        }



        /// <summary>
        /// getInt()
        /// grabs a non negative integer from the User through the Console
        /// </summary>
        /// <param name="prompt">Takes a String to display to User before readline</param>
        /// <returns>non Negative integer</returns>
        static int GetInt(string prompt)
        {
            int result = -1;
            string response = "";
            do
            {
                Console.Write(prompt);
                response = Console.ReadLine();

            } while (!int.TryParse(response, out result));
            return result;
        }

        static int GetValidInt(string prompt, int limit)
        {
            int myInt = -1;
            do
            {
                myInt = GetInt(prompt);

            } while ((myInt < 0) || (myInt >= limit));
            return myInt;
        }
        static void run()
        {
            Random rnd = new Random();
            int target = rnd.Next(101);
            int response = 0;
            bool finished = false;
            Console.WriteLine(target);
            int guesses = 0;
            while (!finished)
            {
                finished = false;
                response = GetValidInt("Enter an Integer between 0 - 100:", 101);

                if (target > response)
                {
                    Console.WriteLine("Higher.");
                }
                else if (target < response)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Hit!");
                    finished = true;
                }
                guesses++;
            }
            Console.WriteLine("It only took you " + guesses + " guesses");
            Console.ReadLine();
        }
    }
}
