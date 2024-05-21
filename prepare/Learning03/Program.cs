using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Fraction n1 = new Fraction();
        Fraction n2 = new Fraction(5);
        Fraction n3 = new Fraction(3,4);
        Fraction n4 = new Fraction(1,3);

        Console.WriteLine(n1.Make_Fraction());
        Console.WriteLine(n1.Compute_Fraction());
        Console.WriteLine(n2.Make_Fraction());
        Console.WriteLine(n2.Compute_Fraction());
        Console.WriteLine(n3.Make_Fraction());
        Console.WriteLine(n3.Compute_Fraction());
        Console.WriteLine(n4.Make_Fraction());
        Console.WriteLine(n4.Compute_Fraction());

    }
}