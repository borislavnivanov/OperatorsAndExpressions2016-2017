/*
 * Write an expression that calculates rectangle’s area and perimeter by given width and height. The width and height 
 * should be read from the console.

Input

The input will consist of 2 lines:
On the first line, you will receive a floating-point number that will represent the width of the rectangle.
On the second line, you will receive another floating-point number that will represent the height of the rectangle.
Output

Output a single line - the rectangle's area and perimeter, separated by a whitespace.
Print the area and perimeter values with exactly 2-digits precision after the floating point
2.5
3	7.50 11.00
*/

using System;

class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        double perimeter = (2 * width) + (2 * height);
        string result = string.Format("{0:0.00}", area) + " " + string.Format("{0:0.00}", perimeter);
        Console.WriteLine(result);
    }
}
