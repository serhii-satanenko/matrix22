using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace matrix2
{
    class MatrixCalc
    {          
        private int _sum;
        private static int _x;
        private static int _y;
        public int[,] Matrix { get; private set; }

        public MatrixCalc(int[,] matrix)
        {
            Matrix = matrix;
            _x = Matrix.GetLength(0);
            _y = Matrix.GetLength(1);
        }
                        

        public int CalcMatrix()
        {
            //sum
            for (int i = 0; i < _x; i++)
            {
                for (int j = 0; j < _y; j++)
                {
                    if (i == j)
                        _sum += Matrix[i, j];
                }
            }
            return _sum;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < _x; i++)
            {
                for (int j = 0; j < _y; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"[{Matrix[i, j]}] ");
                    }
                    else if (i != j)
                    {
                        Console.ResetColor();
                        Console.Write($"[{Matrix[i, j]}] ");
                    }

                }
                Console.WriteLine();
            }
            Console.ResetColor();                  
        }
    }
}
