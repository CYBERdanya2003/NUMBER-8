using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите (целое) число");
        Console.WriteLine("---------------------");
        int x;
        x = int.Parse(Console.ReadLine());
        Console.WriteLine(multipleornot(x));
        Console.ReadKey();
    }
    static bool multipleornot(int number)
    {
        return (number % 5 == 0) || (number % 7 == 0);
    }
}