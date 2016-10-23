/*
 * Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit 
 * unsigned integer(read from the console).
 * */

using System;

class BitExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        uint mask = 7;
        uint firstseq = ((mask << 3) & n) >> 3;
        uint secondseq = ((mask << 24) & n) >> 24;

        n = n & ~(mask << 3);
        n = n & ~(mask << 24);
        n = n | (firstseq << 24);
        n = n | (secondseq << 3);

        Console.WriteLine(n);

    }
}