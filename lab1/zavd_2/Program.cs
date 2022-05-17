using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var geom_mean = WhileNumber();
            Console.WriteLine(geom_mean);
        }


        static double WhileNumber()
        {
            var rnd = new Random();
            var number = rnd.Next(1000, 9999);
            Console.WriteLine(number);
            var k = 0;
            int max = 0;
            int min = 10;
            double geom_mean = 0;
            while (number > 0)
            {
                k = number % 10;
                if (k > max)
                    max = k;

                if (k < min)
                    min = k;

                number = number / 10;
            }
            Console.WriteLine($"Max={max}");
            Console.WriteLine($"Min={min}");
            geom_mean = Math.Sqrt(min * max);
            return geom_mean;

        }
    }
}