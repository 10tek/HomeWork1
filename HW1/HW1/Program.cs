using System;
using System.Threading;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            var text = Console.ReadLine();
            for (var i = 0; i < 3; i++)
            {
                for (int j = 0, k = 0; j < text.Length + 2; j++)
                {
                    if (i == 0 || i == 2 || j == 0 || j == text.Length + 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("*");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(text[k]);
                        k++;
                    }
                    Thread.Sleep(200);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
