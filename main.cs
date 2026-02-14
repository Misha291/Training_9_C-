using System;

namespace tran9
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int chislo = int.Parse(Console.ReadLine());

            for (int i = 1; i <= chislo; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.ReadKey();
        }
    }
}
