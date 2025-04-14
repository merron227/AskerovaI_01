using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение a:");
        double a = double.Parse(Console.ReadLine());

        // Вычисление z1
        double z1 = Math.Sin((Math.PI / 2) + 3 * a) / (1 - Math.Sin(3 * a - Math.PI));

        // Вычисление z2
        double z2 = 1 / Math.Tan((5.0 / 4) * Math.PI + (3.0 / 2) * a); // ctg(x) = 1 / tan(x)

        Console.WriteLine($"Результат z1: {z1}");
        Console.WriteLine($"Результат z2: {z2}");

        // Проверка совпадения
        Console.WriteLine($"Результаты совпадают: {Math.Abs(z1 - z2) < 1e-6}");
    }
}
