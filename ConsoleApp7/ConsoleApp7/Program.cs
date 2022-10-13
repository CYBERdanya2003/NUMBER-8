using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите X");
        Console.WriteLine("---------");
        var x = int.Parse(Console.ReadLine());
        Console.WriteLine($"Значение функции при данном X: " + F(x));
        Console.ReadLine();
    }
    static double F(int x)
    {
        if (x < -1)
            return 1;
        else if (x > 1)
            return -1;
        else
            return -x;
    }
}