﻿using System;

namespace ConsoleApp4
{
    internal class zavd_1_Sagan
    {

        static double getMax(double a, double b)
        {
            if (a > b)
                return a;

            else
                return b;
        }

        static double getMul(double a, double b)
        {
            return a * b;
        }

        static double getDiv(double a, double b)
        {
            return a / b;
        }


        static void Main(string[] args)
        {
            var rnd = new Random();

            var a = rnd.Next(-10, 10);
            Console.WriteLine($"a= {a}");

            var b = rnd.Next(-10, 10);
            Console.WriteLine($"b= {b}");

            var c = rnd.Next(-10, 10);
            Console.WriteLine($"c= {c}");

            var max1 = getMax(a - b, a + b);
            Console.WriteLine(max1);
            var max2 = getMax((a * b) / c, c / (a * b));
            Console.WriteLine(max2);
            var y = getMax(max1, max2);
            Console.WriteLine($"y={y}");
        }
    }
}