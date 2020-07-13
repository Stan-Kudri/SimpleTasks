using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Задано пять произвольных целых чисел (элементы массива). Определить, является ли их расположение 
     *в массиве упорядоченным (т.е. по возрастанию или по убыванию) или неупорядоченным.*/

    class Task11
    {
        private bool OrderedArray;

        public void DefiningArrayOrdering(int[] array)
        {
            if (array.SequenceEqual(array.OrderByDescending(s => s)) || array.SequenceEqual(array.OrderBy(s => s)))
                OrderedArray = true;
            else
                OrderedArray = false;
        }

        public void Print()
        {
            if( OrderedArray == true)
                Console.WriteLine("Массив ялвляется упорядоченным");
            else
                Console.WriteLine("Массив ялвляется неупорядоченным");
        }
    }
}
