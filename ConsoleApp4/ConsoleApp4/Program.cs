
using System;
// ДЗ №4
//       _____       _____       _____
//     -/2+3^2     -/3+5^2     -/5+7^2
//x = e^        + e^        * e^

class Program
{
    static void Main(string[] args)
    {
        double X; Console.WriteLine(Math.Round(GoToG(), 3)); Console.ReadKey();
    }
    static double GoToG()
    {
        double X;
        double e = Math.E;
        double a = -Math.Sqrt((2 + 3 * 3));
        double x = Math.Pow(e, a);
        double b = -Math.Sqrt((3 + 5 * 5));
        double y = Math.Pow(e, b);
        double c = -Math.Sqrt((5 + 7 * 7));
        double z = Math.Pow(e, c);
        return X = x + y * z;
    }

}