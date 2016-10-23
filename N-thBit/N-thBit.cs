/*
 * Write a program that reads from the console two integer numbers P and N and prints on the console the value of
 *  P's N-th bit.

Input
On the first line you will receive the number P. On the second line you will receive the number N.
 * */

using System;


class Program
{
    static void Main()
    {
        long p = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int mask = 1 << n;
        Console.WriteLine(((mask & p) >> n));
    }
}
