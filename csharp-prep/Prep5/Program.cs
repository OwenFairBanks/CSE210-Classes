using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserName = PromptUserName();
        float number = PromptUserNumber();
        float square = SquareNumber(number);
        DisplayResult(UserName, square);
    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }
        static float PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            float number = float.Parse(Console.ReadLine());

            return number;
        }
        static float SquareNumber(float number)
        {
            float square = number * number;
            return square;
        }
        static void DisplayResult(string UserName, float square)
        {
            Console.WriteLine($"{UserName}, the square of your number is {square}.");
        }
    }