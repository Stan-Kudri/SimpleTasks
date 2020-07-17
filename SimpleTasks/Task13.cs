using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*В двухмерном массиве переставьте попарно соседние строки, т.е. 1-ю со 2-ой, 3-ю с 4-й и т.д. Результат выведите на экран.*/

    class Task13
    {
        private string[,] ModifiedArray ;

        public void RearrangeLinesInPairs(string [,] array)
        {
            if(array.GetLength(1)%2!=0)
            {
                throw new Exception("Для реализации попарной перестановке нужно четное количество столбцов!");
            }
            ModifiedArray = new string[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j+=2)
                {
                    ModifiedArray[i, j] = array[i, j + 1];
                    ModifiedArray[i, j + 1] = array[i, j];                    
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < ModifiedArray.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < ModifiedArray.GetLength(1); j++)
                {
                    Console.Write($" {ModifiedArray[i, j]}");
                }
                Console.WriteLine("|");
            }
        }
    }
}
