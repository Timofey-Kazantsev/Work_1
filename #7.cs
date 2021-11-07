using System;

namespace Tabl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица умножения");
            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < 3 ; j++)
                {
                    Console.Write($"{j}*{i}={j * i} \t");
                }
                Console.WriteLine();
            }

        }
    }
}
