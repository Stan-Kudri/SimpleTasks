using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Задана квадратная матрица целых чисел.Подсчитайте количество отрицательных и положительных элементов,
     * а также выведите на печать координаты нулевых элементов (номер строки и номер столбца).*/

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

    class Task8
    {
        private int NegativeNumbers;
        private int PositiveNumbers;
        private List<Coordinates> ZeroElementCoordinates = new List<Coordinates>();
        
        public void Print(int  negative, int positive, string[] zeroElementCoordinates)
        {
            Console.WriteLine($"Количество элементов матрицы больше 0 состовляет : {PositiveNumbers}");
            Console.WriteLine($"Количество элементов матрицы меньше 0 состовляет : {NegativeNumbers}");
            Console.WriteLine("Координаты элементов матрицы равные 0 :");
            foreach(var coordinat in ZeroElementCoordinates)
            {
                Console.WriteLine($"[{coordinat.Row},{coordinat.Column}]");
            }
        }

        private void Execute(int[,] array)
        {
            NegativeNumbers = 0;
            PositiveNumbers = 0;
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                        PositiveNumbers++;
                    if (array[i, j] < 0)
                        NegativeNumbers--;
                    else
                        ZeroElementCoordinates.Add(new Coordinates(i,j));
                }
            }
        }
        
    }
}
