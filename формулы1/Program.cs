using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите радиус основания цилиндра (см):");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите высоту цилиндра (см):");
        double height = double.Parse(Console.ReadLine());

        // Вычисление объема
        double volume = Math.PI * Math.Pow(radius, 2) * height;

        // Вычисление площади поверхности
        double surfaceArea = 2 * Math.PI * radius * (radius + height);

        Console.WriteLine($"Объем цилиндра: {volume:F2} куб. см.");
        Console.WriteLine($"Площадь поверхности цилиндра: {surfaceArea:F2} кв. см.");
    }
}
