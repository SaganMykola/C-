using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Student();
            Console.WriteLine();
        }
    }

    internal class Student
    {
        private string name;
        private DateTime birthday;
        private DateTime admission;
        private int course;
        private List<double> marks;
        private double money;
        private int age;
        private double avarage;
        private string[] subjects;
        private DateTime time;
        private int graduation;

        public Student()
        {
            subjects = new string[] { "Алгебра", "Геометрiя", "Програмування", "Математичний аналiз", "Дискретна математика" };

            Console.Write("Введiть своє прiзвище та iнiцiали: ");
            name = Console.ReadLine();

            Console.Write("Введiть свою дату народження: ");
            birthday = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Введiть дату вступу: ");
            admission = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Вкажiть на якому ви курсi: ");
            course = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введiть свої бали: ");
            marks = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($" {subjects[i]} ");
                marks.Add(Convert.ToDouble(Console.ReadLine()));
                if (marks[i] > 5)
                {
                    marks[i] = marks.IndexOf(marks[i]);
                    Console.WriteLine("Введiть правильну кiлькiсть балiв");
                    Console.Write($" {subjects[i]} ");
                    marks[i] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.Write("Введiть розмiр своєї стипендiї: ");
            money = Convert.ToDouble(Console.ReadLine());

            avarage = marks[0];
            for (int i = 1; i < 5; i++)
            {
                avarage += marks[i];
            }
            avarage /= 5;

            time = DateTime.Now;
            age = time.Year - birthday.Year;

            graduation = admission.Year + (4 - course);

            Print();
        }

        public void Print()
        {
            Console.WriteLine();

            Console.WriteLine($"Прiзвище та iнiцiали студента: {name}");

            Console.WriteLine($"Дата народження: {birthday}");

            Console.WriteLine($"Дата вступу: {admission}");

            Console.WriteLine($"Курс: {course}");

            Console.Write("Бали: ");
            for (int i = 0; i < marks.Count; i++)
            {
                Console.Write($"  {subjects[i]}:  {marks[i]};");
            }
            Console.WriteLine();

            if (money == 0)
            {
                Console.WriteLine("Стипендiя вiдсутня");
            }
            else
            {
                Console.WriteLine($"Стипендiя: {money}");
            }
            Console.WriteLine($"Середнiй бал студента: {avarage}");

            Console.Write("Дисциплiна, бал з якої є нижчим за середнiй: ");
            for (int i = 0; i < marks.Count; i++)
            {
                if (marks[i] < avarage)
                {
                    Console.Write($"  {subjects[i]}");
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Вiк студента: {age}");

            Console.WriteLine($"Рiк закiнчення навчання: {graduation}");
        }
    }
}