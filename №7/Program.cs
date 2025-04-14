using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите двузначное число:");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 10; // Первая цифра
        int lastDigit = number % 10;  // Последняя цифра

        Console.WriteLine($"Первая цифра: {firstDigit}");
        Console.WriteLine($"Последняя цифра: {lastDigit}");
    }
}
