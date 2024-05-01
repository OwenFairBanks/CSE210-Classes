using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int user_input = -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while ( user_input != 0 )
        {
            Console.Write("Enter number:");
            user_input = int.Parse(Console.ReadLine());
            if ( user_input != 0 )
            {
                numbers.Add(user_input);
            }
        }
        int sum = 0;
        int high = 0;
        int small = 999999999;
        numbers.Sort();
        foreach ( int number in numbers )
        {
            sum += number;
            if ( number > high )
            {
                high = number;
            }
            else if ( number < small )
            {
                small = number;
            }
        }
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {high}");
        Console.WriteLine($"The smallest number is: {small}");
        Console.WriteLine("The sorted list is:");
        foreach ( int number in numbers )
        {
            Console.WriteLine(number);
        }
    }
}