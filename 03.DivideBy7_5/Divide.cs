/*
 * Write a program that does the following:

Reads an integer number from the console.
Stores in a variable if the number can be divided by 7 and 5 without remainder.
Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5.
Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.
3	false 3

 * */

using System;


class Divide
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        if (input % 7 == 0 && input % 5 ==0)
        {
            Console.WriteLine("true {0}", input);
        }
        else
        {
            Console.WriteLine("false {0}", input);
        }
    }
}