class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n.ToString().Sum(c => c - '0'));
    }
}
