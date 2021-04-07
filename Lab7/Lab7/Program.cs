// Grade ID: R8206
// Due date: 3/29/2020
// Lab 7
// Section 1
// This program writes out * in a square shape given the users input of rows desired

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int input;
            string numStars;
            Console.WriteLine("Stars Per Side Desired?: "); // converting user input using TryParse method
            numStars = Console.ReadLine();
            int.TryParse(numStars, out input);
            ShowSquareOfStars(input); // Gives the output of stars

        }
        public static void ShowSquareOfStars(int input) // the void method starts here
        {
            
            int MIN_ROWS = 0;
            if (input > MIN_ROWS)
                for (int row = 0; row < input; ++row) // for statements make the square with rows and columns
                {
                    for (int columns = 0; columns < input; ++columns)
                        Console.Write("* ");
                    Console.WriteLine();
                }
            else
            {
                Console.WriteLine("Enter Valid Input:");
                Console.ReadLine();
            }
                Console.WriteLine("");
        }
    }
}
