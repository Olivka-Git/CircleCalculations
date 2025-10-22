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
                double circumference = CalculateCircumference(radius);
                double area = CalculateArea(radius);
                double volume = CalculateSphereVolume(radius);

                Console.WriteLine($"Длина окружности: {circumference:F2}");
                Console.WriteLine($"Площадь круга: {area:F2}");
                Console.WriteLine($"Объем шара: {volume:F2}");
            }

            Console.ReadKey();
        }
        static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double CalculateSphereVolume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }
}