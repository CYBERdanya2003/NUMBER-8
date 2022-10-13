using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координату X");
        Console.WriteLine("--------------------");
        double x;
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату Y");
        Console.WriteLine("--------------------");
        double y;
        y = double.Parse(Console.ReadLine());
        Console.WriteLine(Coordinates(x, y));
        Console.ReadKey();
    }
    static bool Coordinates(double ox, double oy)
    {
        if ((ox > 2) && (oy > 0) && (ox > 1) && (ox < -1))
            return true;
        else
            return false;
    }
}