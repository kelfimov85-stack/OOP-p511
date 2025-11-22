using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{

    internal class Program
    {
        static int[,] Matrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"[{i+1}, {j+1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }

        static int[,] MatrixMulti(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrixThird = new int[3, 3];
            for(int i = 0; i < matrix1.GetLength(0); i++)
            {
                for(int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrixThird[i,j] = matrix1[i,j] * matrix2[i,j];
                }
            }
            return matrixThird;
        }

        static void Main(string[] args)
        {
            int[,] firstMatrix = new int[3, 3];
            int[,] secondMatrix = new int[3, 3];

            firstMatrix = Matrix(firstMatrix);
            secondMatrix = Matrix(secondMatrix);

            int[,] matrixThird = MatrixMulti(firstMatrix, secondMatrix);
            
           Console.WriteLine();

            for(int i = 0;i < matrixThird.GetLength(0);i++)
            {
                for(int j = 0;j < matrixThird.GetLength(1); j++)
                {
                    Console.Write($"{matrixThird[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

