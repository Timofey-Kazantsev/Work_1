using System;

namespace TheBiggest
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Введите 3 числа");
            a = (float)Convert.ToDouble(Console.ReadLine());
            b = (float)Convert.ToDouble(Console.ReadLine());
            c = (float)Convert.ToDouble(Console.ReadLine());
            if ((a > b) & (a > c))
            {
                Console.WriteLine("Максимальное число = {0}", a);
            }
            else if ((b > c) & (b > a))
            {
                Console.WriteLine("Максимальное число = {0}", b);
            }
            else if ((c > a) & (c > b))
            {
                Console.WriteLine("Максимальное число = {0}", c);
            }
        }
    }
}
