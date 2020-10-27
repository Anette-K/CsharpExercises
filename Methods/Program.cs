/*
 * First "quick n dirty " version of exercise 1. 
 * A program that reads 2 integers form the console and prints the largest of them using  your own method GetMax()
 * TODO: Exception handling, atleast on user input.
 * 
 */
using System;

namespace Methods
{ 
    class Program
    {
        static int GetMax(int firstNumber, int secondNumber)
        { if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("First number:  ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Second number:  ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Largest number: " + GetMax(firstNumber, secondNumber));
        }
    }
}
