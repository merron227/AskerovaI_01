using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите радиус круга (см):");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Площадь круга: {area:F2} кв. см.");
    }
}
