using System;
class Program
{
    static void Main(string[] args)
    {
        string iraida = "пирамида";
        string v = iraida.Substring(5, 1) + iraida.Substring(2, 2) + iraida.Substring(5, 1) + iraida.Substring(6,2);
        Console.WriteLine(v);

        string dima = "пирамида";
        string V = dima.Substring(6, 1) + dima.Substring(5, 1) + dima.Substring(4, 1) + dima.Substring(3, 1);
        Console.WriteLine(V);

        Console.ReadKey();
    }
}