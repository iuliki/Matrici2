using System;

namespace Matrici2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] matrix1 = ReadMatrix();
            PrintMatrix(matrix1);
            Console.WriteLine("Randul de pe care vrea sa se faca suma: ");
            int R = Console.Read();
            SumaRand(matrix1,R);
           
        }
        public static class ConsoleHelper
        {
            public static int ReadNumber(string label, int maxTries, int defaultValue)
            {
                int currentTry = 0;
                do
                {
                    Console.Write(label);
                    string valueAsString = Console.ReadLine();
                    int valueAsNumber;
                    bool isNumber = int.TryParse(valueAsString, out valueAsNumber);

                    if (isNumber)
                    {
                        return valueAsNumber;
                    }

                    currentTry++;
                    Console.WriteLine($"The value '{valueAsString}' doen't represent a valid number, please try again ...");
                }
                while (currentTry < maxTries);

                return defaultValue;
            }
        }
        public static int[,] ReadMatrix()
        {
            // citesc nr de linii
            int rowsCount = ConsoleHelper.ReadNumber("Nr de linii=", 3, 0);

            // citesc nr de coloane
            int colsCount = ConsoleHelper.ReadNumber("Nr de coloane=", 3, 0);

            int[,] matrix = new int[rowsCount, colsCount];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int element = ConsoleHelper.ReadNumber($"Element[{row},{col}]=", 3, 0);
                    matrix[row, col] = element;
                }
            }

            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            if (matrix is null)
            {
                Console.WriteLine("Matrix is null");
                return;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col],6}");
                }

                Console.WriteLine();
            }
        }

        public static void SumaRand(int[,] matrix, int R )
        {
            
            int suma=0;
            int colsCount2 = matrix.GetLength(1);
            for (int col = 0; col < colsCount2; col++)
                suma = suma + matrix[R, col];

            Console.WriteLine($"Suma de pe randul {R} este {suma}");
        }
        


    }

}
