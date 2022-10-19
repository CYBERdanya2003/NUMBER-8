
using System;

namespace _1ksat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Владимир Маяковский 'Горе'");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"Тщетно отчаянный ветер
ился нечеловече
Капли чернеющей крови
стынут крышами кровель.
И овдовевшная в ночи
вышла луна одиночить");
            Console.ReadKey();
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Владимир Маяковский 'Горе'");
                Console.WriteLine();
                Console.WriteLine(@"Тщетно отчаянный ветер
ился нечеловече
Капли чернеющей крови
стынут крышами кровель.
И овдовевшная в ночи
вышла луна одиночить");
                Console.ReadKey();
            }
        }
    }
}