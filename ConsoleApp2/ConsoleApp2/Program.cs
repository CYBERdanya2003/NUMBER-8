
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите d внешнего кольца");
        Console.WriteLine("-------------------------");
        double D = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("-------------------------");
        Console.WriteLine("Введите d внутреннего кольца");
        Console.WriteLine("----------------------------");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("----------------------------");
        double PI = Math.PI;

        Console.WriteLine($"S кольца = " + (PI / 4 * (D * D - d * d)));
        Console.Read();
    }
}