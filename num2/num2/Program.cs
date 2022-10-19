using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координату x координата центра квадрата");
        Console.WriteLine("-------------------------");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("-------------------------");
        Console.WriteLine("Введите координату y координата центра квадрата");
        Console.WriteLine("----------------------------");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("----------------------------");
        Console.WriteLine("Введите координату x координата вершины");
        Console.WriteLine("----------------------------");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("----------------------------");
        Console.WriteLine("Введите координату y координата вершины");
        Console.WriteLine("----------------------------");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double d = ((Math.Sqrt((Math.Abs(x1 - x2) + Math.Abs(y1 - y2)) * 2)));
        double d1 = d + d; ;
        Console.WriteLine("S Квадрата = " + (d1 * d1) / 2);
        Console.WriteLine("P Квадрата = " + d1 * 2 * Math.Sqrt(2));
        Console.Read();
    }
}