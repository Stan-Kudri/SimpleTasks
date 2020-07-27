using System;

namespace SimpleTasks
{
    class Task13 : ISimpleTask
    {
        private string[,] _array;
        private string[,] _modifiedArray ;
        private int _row;
        private int _column;

        public string Name { get; } = "В двухмерном массиве переставьте попарно соседние строки, т.е. 1-ю со 2-ой, 3-ю с 4-й и т.д. Результат выведите на экран.";

        public void Execute()
        {
            _array = Randomazer.Intance.TwoDimensionalArrayString();
            _row = _array.GetLength(0);
            _column = _array.GetLength(1);
            PrintOriginalArray();
            RearrangeLinesInPairs();
            Print();
        }

        private void PrintOriginalArray()
        {
            Console.WriteLine("Исходный массив строк:\n");
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    Console.Write($" {_array[i, j]}");
                }
                Console.WriteLine("|");
            }
        }

        private void RearrangeLinesInPairs()
        {
            if (_column%2!=0 || _array == null)
                throw new Exception("Для реализации попарной перестановке нужно четное количество столбцов!");

            _modifiedArray = new string[_array.GetLength(0), _array.GetLength(1)];
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j+=2)
                {
                    _modifiedArray[i, j] = _array[i, j + 1];
                    _modifiedArray[i, j + 1] = _array[i, j];                    
                }
            }
        }

        private void Print()
        {
            Console.WriteLine("\nИзмененный массив стрк:\n");
            for (int i = 0; i < _modifiedArray.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < _modifiedArray.GetLength(1); j++)
                {
                    Console.Write($" {_modifiedArray[i, j]}");
                }
                Console.WriteLine("|");
            }
        }
    }
}
