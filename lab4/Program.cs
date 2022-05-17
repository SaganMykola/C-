using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m1 = new TSMatrix();
            var m2 = new TSMatrix(new double[,] { { 1, 2, 5, 6 }, { 3, 4, 7, 8 }, { 5, 6, 7, 6 }, { 7, 5, 7, 8 } });
            var m3 = new TSMatrix(m2);
            var count = 0;

            Console.WriteLine("Перша матриця:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0,2}", m1.matrix[i, j]);
                }
                count++;

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Друга матриця: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0,2}", m2.matrix[i, j]);
                }


                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Третя матриця: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0,2}", m3.matrix[i, j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"Кількість рядків: {count}, кількість стовпців: {count}");

            Console.WriteLine($"Максимальний елемент матриці: {m1.getMax(m1.matrix)}");

            Console.WriteLine($"Мінімальний елемент матриці: {m1.getMin(m1.matrix)}");

            Console.WriteLine($"Сума елементів матриці: {m1.getSum(m1.matrix)}");

            var suma = m1 + m2;
            Console.WriteLine("Сума елементів матриць ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($" {suma[i, j]}");
                }
                Console.WriteLine();
            }

            var riz = m1 - m2;
            Console.WriteLine("Різниця елементів матриць ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($" {riz[i, j]}");
                }
                Console.WriteLine();
            }


        }

    }
    internal class TSMatrix
    {
        public double[,] matrix;

        public double[,] Matrix { get { return matrix; } set { matrix = value; } }
        public TSMatrix()
        {
            matrix = new double[4, 4];
            Console.WriteLine("Введіть елементи матриці");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        public TSMatrix(double[,] matrix)
        {
            this.matrix = matrix;
        }

        public TSMatrix(TSMatrix m)
        {
            matrix = m.matrix;
        }

        public double getMax(double[,] a)
        {
            double max = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    max = Math.Max(max, a[i, j]);
            }
            return max;
        }
        public double getMin(double[,] a)
        {
            double min = a[0, 0];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    min = Math.Min(min, a[i, j]);
            }
            return min;
        }

        public double getSum(double[,] a)
        {
            double sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    sum += a[i, j];
            }
            return sum;
        }

        public static double[,] operator +(TSMatrix m1, TSMatrix m2)
        {
            double[,] suma = new double[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    suma[i, j] += m1.matrix[i, j] + m2.matrix[i, j];
                }
            }
            return suma;
        }

        public static double[,] operator -(TSMatrix m1, TSMatrix m2)
        {
            double[,] riz = new double[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    riz[i, j] = m1.matrix[i, j] - m2.matrix[i, j];
                }
            }
            return riz;
        }
    }
}