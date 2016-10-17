/*
 * Write a program that reads an integer N from the console and prints true if the third digit of N is 7, or 
 * "false THIRD_DIGIT", where you should print the third digits of N.

The counting is done from right to left, meaning 123456's third digit is 4.
Input

The input will always consist of exactly one line, containing the number N.
Output

The output should be a single line - print whether the third digit is 7, following the format described above.

5	false 0
701	true
 * */

using System;


class ThirdDigit
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
     
        if (input % 1000 > 699 && input % 1000 < 800)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0:0}", (input / 100) % 10);
        }
    }
}