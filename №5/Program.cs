using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x:");
        double x = double.Parse(Console.ReadLine());

        double y = 7 * Math.Pow(x, 2) + 3 * Math.Pow(x, 3) + 6;
        Console.WriteLine($"Значение функции: {y}");
    }
}
