/*We are given an integer number N (read from the console), a bit value v (read from the console as well) 
 * (v = 0 or 1) and a position P (read from the console). Write a sequence of operators (a few lines of C# code) 
 * that modifies N to hold the value v at the position P from the binary representation of N while preserving all 
 * other bits in N. Print the resulting number on the console.
 * 
 * */

using System;


class ModifyBit
{
    static void Main()
    {
        ulong numberN = ulong.Parse(Console.ReadLine());
        short positionP = short.Parse(Console.ReadLine());
        byte valueV = byte.Parse(Console.ReadLine());
        ulong result = new ulong();

        if (valueV == 0)
        {
            ulong mask = (ulong) ~(1 << positionP);
            result = mask & numberN;
            Console.WriteLine(result);
        }
        else if (valueV == 1)
        {
            ulong mask = (ulong)1 << positionP;
            result = mask | numberN;
            Console.WriteLine(result);
        }
    }
}