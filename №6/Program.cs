using System;

class Program
{
    static void Main()
    {
        // Вычисление площади круга
        Console.WriteLine("Введите радиус круга (см):");
        double radius = double.Parse(Console.ReadLine());
        double circleArea = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Площадь круга: {circleArea:F2} кв. см.");

        // Вычисление площади прямоугольника
        Console.WriteLine("\nВведите длину прямоугольника (см):");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите ширину прямоугольника (см):");
        double width = double.Parse(Console.ReadLine());
        double rectangleArea = length * width;
        Console.WriteLine($"Площадь прямоугольника: {rectangleArea:F2} кв. см.");
    }
}
