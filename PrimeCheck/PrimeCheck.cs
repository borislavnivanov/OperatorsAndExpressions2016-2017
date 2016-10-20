/*
 * Write a program that reads an integer N (which will always be less than 100 or equal) and uses an expression to
 *  check if given N is prime (i.e. it is divisible without remainder only to itself and 1).

Note: You should check if the number is positive
*/

using System;


class PrimeCheck
{
    static void Main()
    {
        string IsPrime = "true";
        int number;
        bool Isint = int.TryParse(Console.ReadLine(), out number);
        if (Isint)
        {
            if (number <= 1)
            {
                IsPrime = "false";
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        IsPrime = "false";
                    }
                }
            }
            Console.WriteLine(IsPrime);
        }
        else
        {
            Console.WriteLine("Invalid entry!");
        }
    }
}