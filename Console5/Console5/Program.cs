using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите слово или фразу на русском языке");
        Console.WriteLine("--------------------------------------");
        string leet = Console.ReadLine().ToLower();
        Console.WriteLine(TranslateOnLeet(leet));
        Console.ReadKey();
    }
    static string TranslateOnLeet(string x)
    {
        x = x.Replace("а", "A");
        x = x.Replace("б", "B");
        x = x.Replace("в", "V");
        x = x.Replace("г", "G");
        x = x.Replace("д", "D");
        x = x.Replace("е", "E");
        x = x.Replace("ё", "E");
        x = x.Replace("ж", "ZH");
        x = x.Replace("з", "Z");
        x = x.Replace("и", "I");
        x = x.Replace("й", "I");
        x = x.Replace("к", "K");
        x = x.Replace("л", "L");
        x = x.Replace("м", "M");
        x = x.Replace("н", "N");
        x = x.Replace("о", "O");
        x = x.Replace("п", "P");
        x = x.Replace("р", "R");
        x = x.Replace("с", "S");
        x = x.Replace("т", "T");
        x = x.Replace("у", "U");
        x = x.Replace("ф", @"F");
        x = x.Replace("х", @"H");
        x = x.Replace("ц", @"C");
        x = x.Replace("ч", @"CH");
        x = x.Replace("ш", "SH");
        x = x.Replace("щ", "SHCH");
        x = x.Replace("ъ", "IE");
        x = x.Replace("ы", "Y");
        x = x.Replace("ь", "");
        x = x.Replace("э", "E");
        x = x.Replace("ю", "IU");
        x = x.Replace("я", "IA");


        return x;
    }
}