using System;

class Program
{
    static void Main()
    {
        double x = 3.5;
        double y = Math.Cos(x) * Math.Cos(x) - (Math.Pow(x, 1.5) + 1) / (Math.Sin(x) + Math.Exp(Math.Log(2 * x)));
        Console.WriteLine(y);
    }
}
