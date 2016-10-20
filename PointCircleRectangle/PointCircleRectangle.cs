/*
 * Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point
 *  (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 * */

using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double r = 1.5;
        bool inCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (r * r);
        bool inRectangle = x >= 1 && x <= 6 && y >= -1 && y <= 2;

        if (inCircle == true && inRectangle == true)
        {
            Console.WriteLine("inside circle inside rectangle");
        }
        else if (inCircle == true && inRectangle == false)
        {
            Console.WriteLine("inside circle outside rectangle");
        }
        else if (inCircle == false && inRectangle == true)
        {
            Console.WriteLine("outside circle inside rectangle");
        }
        else
        {
            Console.WriteLine("outside circle outside rectangle");
        }

    }
}