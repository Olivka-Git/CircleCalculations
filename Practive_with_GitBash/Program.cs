using System;

namespace CircleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для расчёта параметров прямоугольника");
            Console.Write("Введите длину: ");
            string lengthInput = Console.ReadLine();

            Console.Write("Введите ширину: ");
            string widthInput = Console.ReadLine();

            if (double.TryParse(lengthInput, out double length) &&
                double.TryParse(widthInput, out double width))
            {
                double perimeter = CalculatePerimeter(length, width);
                double area = CalculateRectangleArea(length, width);

                Console.WriteLine($"Периметр прямоугольника: {perimeter:F2}");
                Console.WriteLine($"Площадь прямоугольника: {area:F2}");
            }

            Console.ReadKey();
        }

        // ОБЫЧНЫЙ метод класса (не статическая локальная функция)
        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }
        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }
    }
}