using System;

namespace matrix2
{
    class Program
    {
        static void Main(string[] args)
        {           
            int a = new int();
            int b = new int();
            int answer = new int();
            Random rnd = new Random();            

            Console.WriteLine("Введите 1 для ввода масива в ручную и 2 для автоматической генерации масива");
            Console.Write("1 или 2:");
            do
            {                
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer != 1 && answer != 2)
                {
                    Console.WriteLine($"Значение не может быть {answer}");
                    Console.WriteLine("Введите 1 для ввода масива в ручную и 2 для автоматической генерации масива");
                    Console.Write("1 или 2:");
                }
            } while (answer != 1 && answer != 2);
            //enter matrix param
            Console.WriteLine("Введите размерность матрицы");
            Console.Write("Введите количество строк:");
            do
            {               
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 2)
                {
                    Console.WriteLine("Значение не может быть меньше 2");
                    Console.Write("Введите количество строк:");                    
                }
                else Console.WriteLine("Спасибо");

            } while (a < 2);

            Console.Write("Введите количество столбиков:");

            do
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (b < 2)
                {
                    Console.WriteLine("Значение не может быть меньше 2");
                    Console.Write("Введите количество строк:");
                }
                else Console.WriteLine("Спасибо");

            } while (b < 2);

            int[,] matrix = new int[a, b];
            if (answer == 1)
            {
                Console.WriteLine("введите значения");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write($" [{i}][{j}]: "); 
                        matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }                
            }

            else if (answer == 2)
            {                
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        matrix[i, j] = rnd.Next(0, 100);
                    }
                }                
            }
            Console.WriteLine();
            MatrixCalc c = new MatrixCalc(matrix);
            Console.WriteLine("Масив:");
            c.PrintMatrix();
            Console.WriteLine();
            Console.WriteLine($"Сумма главной диагонали: {c.CalcMatrix()}");
            Console.ReadLine();      
        
        }        
    }
}
