﻿using System;
using System.Collections.Generic;

namespace SimpleTasks
{
    class Coordinates
    {
        public readonly int Row;
        public readonly int Column;

        public Coordinates(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }

    class Task8 : ISimpleTask
    {
        private int[,] _matrix;
        private int _negativeNumbers;
        private int _positiveNumbers;
        private List<Coordinates> _zeroElementCoordinates = new List<Coordinates>();

        public string Name { get; } = "Задана квадратная матрица целых чисел.Подсчитайте количество отрицательных и положительных элементов, а также выведите на печать координаты нулевых элементов(номер строки и номер столбца).*/";

        public void Execute()
        {
            int size = Randomazer.Intance.Number(5, 25);
            _matrix = Randomazer.Intance.TwoDimensionalArray(size);
            PrintMatrix();
            CompletingQuest();
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

        private void CompletingQuest()
        {
            _negativeNumbers = 0;
            _positiveNumbers = 0;
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    if (_matrix[i, j] > 0)
                    {
                        _positiveNumbers++;
                    }
                    if (_matrix[i, j] < 0)
                    {
                        _negativeNumbers++;
                    }
                    else if (_matrix[i, j] == 0)
                    {
                        _zeroElementCoordinates.Add(new Coordinates(i, j));
                    }
                }
            }
        }

        private void Print()
        {
            Console.WriteLine($"Количество элементов матрицы больше 0 состовляет : {_positiveNumbers};");
            Console.WriteLine($"Количество элементов матрицы меньше 0 состовляет : {_negativeNumbers};");
            if (_zeroElementCoordinates.Count == 0)
            {
                Console.WriteLine("Координаты элементов матрицы равные 0 не существует;");
            }
            else
            {
                Console.Write("Координаты элементов матрицы равные 0: ");
                foreach (var coordinat in _zeroElementCoordinates)
                {
                    Console.Write($"[{coordinat.Row},{coordinat.Column}]; ");
                }
                Console.WriteLine();
            }
        }


        
    }
}
