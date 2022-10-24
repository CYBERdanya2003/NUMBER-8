using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Проверка поиска v(n)");
        Console.WriteLine("n == 1:" + Vn(1));
        Console.WriteLine("n == 5:" + Vn(5));
        Console.WriteLine("n == 12:" + Vn(12));

        Console.WriteLine("Проверка поиска s(n)");
        int n = 1;
        int s = 0;
        while (n <= 12)
        {
            s += int.Parse(Vn(n));
            n++;
        }
       // Console.WriteLine("s(12)= " + s);

        //Console.WriteLine("Prog");
       // n = 1;
       // ulong s2 = 0;
       // while (n <= 5000000)
       // {
      //      s2 += ulong.Parse(Vn(n));
       //     n++;

//
       // }
       // Console.WriteLine("s(500000) mod 123454321 = " + s % 123454321);

    }

    static void Vn(int n)
    {
        string p = "";
        string i = "";
        int c = 1;
        while (1 == 1)
        {
            if (p.EndsWith("43"))
            { p = p + "2"; i = i + "2"; }

            else if (p.EndsWith("32"))
            { p = p + "1"; i = i + "1"; }

            else if (p.EndsWith("1"))
            { p = p + "2"; i = i + "2"; }

            else if (p.EndsWith("2"))
            { p = p + "3"; i = i + "3"; }

            else if (p.EndsWith("3"))
            { p = p + "4"; i = i + "4"; }

            else if (p.EndsWith("4"))
            { p = p + "3"; i = i + "3"; }

            else
            {
                p = p + "1"; i = i + "1";
            }

            if (strSum(i) == c)
            {
                c += 1;
                if (strSum(i) == n)
                {
                    return i;
                    break;
                      
                }
                i = "";
            }    
        }
        return "error";   
    }
    static int strSum(string s)
    {
        int sum = 0;
        foreach (char i in s) ;
        {
            sum += (i - '0');

        }
        return sum;

    }
       

}
