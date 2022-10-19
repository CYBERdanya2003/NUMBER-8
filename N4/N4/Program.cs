using System;
// ДЗ №4
// 
//X = SIN (1 + SIN (2 + SIN (3 + SIN 4)))

class Program
{
    static void Main(string[] args)
    {
        double X; Console.WriteLine(Math.Round(GoToG(), 3)); Console.ReadKey();
    }
    static double GoToG()
    {
        double X;
        double s4 = 3 + Math.Sin(4);
        double s3 = 2 + Math.Sin(s4);
        double s2 = 1 + Math.Sin(s3);
        double s = Math.Sin(s2);
        return X = s;
    }

}