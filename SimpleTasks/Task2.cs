using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{    
    class Task2:ISimpleTaskExecute
    {
        private int[,] _matrix;
        private CalculateMatrixElements _calculate;

        public string Name { get; } = "Задан массив действительных чисел размерности 10х10. Найти суммы элементов каждой строки, произведения элементов каждого столбца, и максимальный элемент главной диагонали(подсказка: все элементы, для которых номер строки совпадает с номером столбца).";

        public void Execute()
        {
            _matrix = Randomazer.Intance.TwoDimensionalArray(10, 10);
            PrintMatrix();
            var sumRow = SumMatrixRowElements(_matrix);
            var columnProduct = ProductMatrixColumnElements(_matrix);
            var maxDiagonalValue = MaxValueDiagonal(_matrix);
            _calculate = new CalculateMatrixElements(sumRow, columnProduct, maxDiagonalValue);
            Print();
        }
        
        private void PrintMatrix()
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    Console.Write($" {_matrix[i, j]}");
                }
                Console.WriteLine("|");
            }
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

        private void Print()
        {
            Console.WriteLine($"Сумма элементов каждой строки по очереди : {_calculate.SumRow.JoinToString(",")}");
            Console.WriteLine($"Произведение элементов каждого столбца по очереди : \n{_calculate.ColumnProduct.JoinToString(",")}");
            Console.WriteLine($"Максимальный элемент главной диагонали : {_calculate.MaxDiagonalValue}");
        }

        private class CalculateMatrixElements
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
