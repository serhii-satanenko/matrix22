using System;

namespace matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = new int();
            int y = new int();
            Random rnd = new Random();
            int sum = new int();

            Console.WriteLine($"Введите разменость масива matrix: ");
            Console.Write("Количество строк:"); x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столюцов:"); y = Convert.ToInt32(Console.ReadLine());

            var matrix = new int[x, y];
            //Generate matrix
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = rnd.Next(0, 100);
                }
            }
            //sum
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == j)
                        sum += matrix[i, j];
                }
            }


            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"[{matrix[i, j]}] ");
                    }
                    else if (i != j)
                    {
                        Console.ResetColor();
                        Console.Write($"[{matrix[i, j]}] ");
                    }

                }
                Console.WriteLine();
            }

            Console.ResetColor();
            Console.Write($"Сумма главной диагонали = {sum}");
        }
    }
}
