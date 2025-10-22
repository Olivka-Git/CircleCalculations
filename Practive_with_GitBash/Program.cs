using System;

namespace CircleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для расчёта параметров круга");
            Console.Write("Введите радиус: ");

            string input = Console.ReadLine();

            if (double.TryParse(input, out double radius))
            {
                Console.WriteLine($"Радиус: {radius}");
                double circumference = CalculateCircumference(radius);
                Console.WriteLine($"Длина окружности: {circumference:F2}");
            }
            else
            {
                Console.WriteLine("Ошибочка! Введите корректное число.");
            }

            Console.ReadKey();
        }
        static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}