using System;
class Program
{
    static void Main(string[] args)
    {
        int Res = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            Res = Res + (n + i) * (n + i);
        }
        Console.WriteLine(Res);
        Console.ReadKey();
    }

}