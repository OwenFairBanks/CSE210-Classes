using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment p1 = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment p2 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment p3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(p1.GetSummary());
        Console.WriteLine("");
        Console.WriteLine(p2.GetSummary());
        Console.WriteLine(p2.GetHomework());
        Console.WriteLine("");
        Console.WriteLine(p3.GetSummary());
        Console.WriteLine(p3.GetWritingInfo());
        Console.WriteLine("");

    }
}