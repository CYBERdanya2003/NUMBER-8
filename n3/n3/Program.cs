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
        return ((Math.Abs(x) + 1) - (Math.Abs(x) - 1)) / Math.Abs(x);
    }
}