using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длину основания треугольника (см):");
        double baseLength = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите высоту треугольника (см):");
        double height = double.Parse(Console.ReadLine());

        double area = (baseLength * height) / 2;
        Console.WriteLine($"Площадь треугольника: {area:F2} кв. см.");
    }
}
