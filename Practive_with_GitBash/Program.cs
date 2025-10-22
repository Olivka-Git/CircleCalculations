using System;

namespace CircleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Калькулятор фигур ===");
            Console.WriteLine("1 - Круг");
            Console.WriteLine("2 - Прямоугольник");
            Console.Write("Выберите фигуру: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CalculateCircle();
                    break;
                case "2":
                    CalculateRectangle();
                    break;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }

            Console.ReadKey();
        }

        static void CalculateCircle()
        {
            Console.Write("Введите радиус круга: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double radius))
            {
                double circumference = 2 * Math.PI * radius;
                double area = Math.PI * Math.Pow(radius, 2);
                double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

                Console.WriteLine($"Длина окружности: {circumference:F2}");
                Console.WriteLine($"Площадь круга: {area:F2}");
                Console.WriteLine($"Объем шара: {volume:F2}");
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректное число.");
            }
        }

        static void CalculateRectangle()
        {
            Console.Write("Введите длину: ");
            string lengthInput = Console.ReadLine();

            Console.Write("Введите ширину: ");
            string widthInput = Console.ReadLine();

            if (double.TryParse(lengthInput, out double length) &&
                double.TryParse(widthInput, out double width))
            {
                double perimeter = 2 * (length + width);
                double area = length * width;

                Console.WriteLine($"Периметр прямоугольника: {perimeter:F2}");
                Console.WriteLine($"Площадь прямоугольника: {area:F2}");
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректные числа.");
            }

            ///
        }
    }
}