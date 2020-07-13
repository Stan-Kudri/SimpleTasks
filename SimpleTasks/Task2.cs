using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Задан массив действительных чисел размерности 10х10. Найти суммы элементов каждой строки, произведения элементов каждого столбца, 
    и максимальный элемент главной диагонали (подсказка: все элементы, для которых номер строки совпадает с номером столбца).*/
    
    class Task2
    {
        private Random rnd = new Random();
        private int[,] Matrix;
        private CalculateMatrixElements Calculate;

        public Task2(int rowCount = 10, int columnCount = 10)
        {
            Matrix = new int[rowCount, columnCount];
            for (int i = 0; i < Matrix.GetLength(0); i++)
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Matrix[i, j] = rnd.Next(0, 20);
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($" {Matrix[i, j]}");
                }
                Console.WriteLine("|");
            }
        }

        public void Execute()
        {            
            var sumRow = SumMatrixRowElements(Matrix);
            var columnProduct = ProductMatrixColumnElements(Matrix);
            var maxDiagonalValue = MaxValueDiagonal(Matrix);
            Calculate = new CalculateMatrixElements(sumRow,columnProduct , maxDiagonalValue );
        }

        private int[] SumMatrixRowElements(int[,] matrix)
        {
            int[] sumRow = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumRow[i] = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                    sumRow[i] += matrix[i, j];
            }
            return sumRow;
        }

        private BigInteger[] ProductMatrixColumnElements(int[,] matrix)
        {
            var columnProduct = new BigInteger[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                columnProduct[j] = 1;
                for (int i = 0; i < matrix.GetLength(0); i++)
                    columnProduct[j] *= matrix[i, j];
            }
            return columnProduct;
        }

        private int MaxValueDiagonal(int[,] matrix)
        {
            int maxDiagonalValue = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
                if (maxDiagonalValue < matrix[i, i])
                    maxDiagonalValue = matrix[i, i];
            return maxDiagonalValue;
        }
        
        public void Print()
        {
            Console.WriteLine($"Сумма элементов каждой строки по очереди : {Calculate.SumRow.JoinToString(",")}");
            Console.WriteLine($"Произведение элементов каждого столбца по очереди : {Calculate.ColumnProduct.JoinToString(",")}");
            Console.WriteLine($"Максимальный элемент главной диагонали : {Calculate.MaxDiagonalValue}");
        }

        public class CalculateMatrixElements
        {
            public readonly int[] SumRow;
            public readonly BigInteger[] ColumnProduct;
            public readonly int MaxDiagonalValue;

            public CalculateMatrixElements(int[] sumRow, BigInteger[] columnProduct, int maxDiagonalValue)
            {
                SumRow = sumRow;
                ColumnProduct = columnProduct;
                MaxDiagonalValue = maxDiagonalValue;
            }           
            
        }
    }
}
