/*
 * Write a program that reads an integer from the console, uses an expression to check if given integer is odd
 *  or even, and prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead
 *   of NUMBER.
 * */

using System;

class OddOrEven
{
    static void Main()
    {
        int input = new int();
        input = int.Parse(Console.ReadLine());
        if (input % 2 == 0)
        {
            Console.WriteLine("even {0}",input);
        }
        else
        {
            Console.WriteLine("odd {0}", input);
        }
    }
 }
