using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите радиус шара (см):");
        double radius = double.Parse(Console.ReadLine());

        // Вычисление объема шара
        double volume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);

        // Вычисление площади поверхности шара
        double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);

        Console.WriteLine($"Объем шара: {volume:F2} куб. см.");
        Console.WriteLine($"Площадь поверхности шара: {surfaceArea:F2} кв. см.");
    }
}
