using System;
namespace ConsoleApp1
{

    class Program
    {
        static double[] inputArray(int length)
        {

            double[] a = new double[length];
            for (int i = 0; i < a.Length; i++)
            {
                var rnd = new Random();
                a[i] = rnd.Next(-10, 10);

            }
            return a;
        }

        static void printArr(double[] a)
        {
            foreach (var el in a)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }

        static double dovzVectora(double[] a)
        {
            double suma = Math.Pow(a[0], 2);
            for (int i = 1; i < a.Length; i++)
            {
                suma += Math.Pow(a[0 + i], 2);
            }
            suma = Math.Sqrt(suma);
            return suma;
        }

        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] vec1 = inputArray(n);
            double[] vec2 = inputArray(n);
            double[] div = new double[n];
            for (int i = 0; i < n; i++)
                div[i] = vec1[i] - vec2[i];
            double dovz = dovzVectora(div);
            Console.Write("Перший вектор: ");
            printArr(vec1);
            Console.Write("Другий вектор: ");
            printArr(vec2);
            Console.Write("Рiзниця векторiв: ");
            printArr(div);
            Console.WriteLine($"Довжина вектора= {dovz}");
        }
    }
}