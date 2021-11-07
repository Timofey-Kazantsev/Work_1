using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину катета:");
            int m  = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < m + 1; i++)
            {
                for (int k = 1; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
