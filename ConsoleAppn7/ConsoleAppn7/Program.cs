using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите X");
        var x = int.Parse(Console.ReadLine());
        Console.WriteLine($"полученное значение функции:" + Coordinate(x));
        Console.ReadLine();
    }
    static double Coordinate(int x)
    {
        if (x > 0)
            return Math.Pow(Math.E, -1 * x);
        else if (x <= -1)
            return Math.Pow(Math.E, x + 1);
        else
            return (1);
    }
}



