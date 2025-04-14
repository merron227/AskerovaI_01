using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты первой точки (x1, y1):");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки (x2, y2):");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"Расстояние между точками: {distance}");
    }
}
