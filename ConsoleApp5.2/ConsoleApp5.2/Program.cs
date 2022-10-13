using System;
class Program
{
    static void Main(string[] args)
    {
        string tiara = "клавиатура";
        string v = tiara.Substring(6, 1) + tiara.Substring(4, 2) + tiara.Substring(8, 2);
        Console.WriteLine(v);

        string ruka = "клавиатура";
        string V = ruka.Substring(8, 1) + ruka.Substring(7, 1) + ruka.Substring(0, 1) + ruka.Substring(2, 1);
        Console.WriteLine(V);

        Console.ReadKey();
    }
}