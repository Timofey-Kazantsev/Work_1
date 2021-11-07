using System;

namespace Par
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n =");
            int k = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int n = 0;
            for (int i = 1; i <= k; ++i)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    n += 1;
                }
            }
            Console.WriteLine("Количество парных членов = {0}", n);
            Console.WriteLine("Сумма парных членов = {0}", sum);
            Console.ReadLine();
        }
    }
}
