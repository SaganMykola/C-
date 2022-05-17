using System;

namespace ConsoleApp18
{

    class Program
    {

        static double getAvarage(double a, double b)
        {
            double avarage = (a + b) / 2;
            return avarage;
        }
        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m= ");
            int m = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                }
            }
            Console.WriteLine("Матриця:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"   {matrix[i, j]}");
                }
                Console.WriteLine();
            }
            double max = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
            }
            Console.WriteLine($"Максимальний елемент= {max}");

            double min = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
            }
            Console.WriteLine($"Мiнiмальний елемент= {min}");

            double avarage = getAvarage(max, min);
            Console.WriteLine($"середнє арифметичне найбiльшого i найменшого значень елементiв матрицi= {avarage}");
        }
    }
}