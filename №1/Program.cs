using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int number2 = int.Parse(Console.ReadLine());

        int sum = number1 + number2;
        Console.WriteLine("Сумма данных чисел: " + sum);
    }
}
