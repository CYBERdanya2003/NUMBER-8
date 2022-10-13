using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите X|");
        Console.WriteLine("_________");
        var x = double.Parse(Console.ReadLine());
        Console.WriteLine(GoToCount(x));
        Console.ReadKey();
    }
    static double GoToCount(double x)
    {
        return 1 + Math.Sqrt((x * x - 1) / (x * x + 1));
    }
}