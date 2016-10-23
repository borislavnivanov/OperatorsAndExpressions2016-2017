/*
 * Using bitwise operators, write a program that uses an expression to find the value of the bit at index 3
 *  of an unsigned integer read from the console.

The bits are counted from right to left, starting from bit 0.
The result of the expression should be either 1 or 0. Print it on the console.
 * */

using System;


class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        short index = 3;

        int mask = 1 << index;
        Console.WriteLine(((number & mask) >> 3));
    }
}
