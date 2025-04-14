using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длину первого основания трапеции (см):");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите длину второго основания трапеции (см):");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите высоту трапеции (см):");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;
        Console.WriteLine($"Площадь трапеции: {area:F2} кв. см.");
    }
}
