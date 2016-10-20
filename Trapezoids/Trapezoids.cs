/*
 * Write an expression that calculates trapezoid's area by given sides a and b and height h. The three values 
 * should be read from the console in the order shown below. All three value will be floating-point numbers.
 * */

using System;


class Trapezoids
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double sideH = double.Parse(Console.ReadLine());
        double result = ((sideA + sideB) / 2) * sideH;
        Console.WriteLine("{0:0.0000000}", result);
    }
}