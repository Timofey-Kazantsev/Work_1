using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("s =");
            int s = Convert.ToInt32(Console.ReadLine());
            int i = s;
            int factorial = 1;
            do
            {
                factorial *= i;
                --i;
            }
            while (i > 1);
            Console.WriteLine($"{s}! = {factorial}");
            Console.ReadLine();
        }
    }
}
