﻿
/*
 * he gravitational field of the Moon is approximately 17% of that on the Earth.

Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) 
on the Earth.
The weight W should be read from the console.
 * */

using System;


class MoonGravity
{
    static void Main()
    {
        double W = new double();
        W = double.Parse(Console.ReadLine());
        double result = W * 0.17;
        string output = string.Format("{0:0.000}", result);
        Console.WriteLine(output);
    }
}
