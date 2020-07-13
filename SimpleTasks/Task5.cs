using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    //В заданном массиве действительных чисел найдите разность между максимальным и минимальным числом.

    class Task5
    {
        private int Difference;

        public void DifferenceMaxiAndMinNumber(int[] array)
        {
            if(array.Length > 1)
            {
                Difference = array.Max() - array.Min();
            }
            else
            {
                Difference = 0;
            }
        }

        public void Print()
        {
            if (Difference != 0)
                Console.WriteLine("Разница между максимальным и минимальным числом массива состовляет {0}", Difference);
            else
                Console.WriteLine("Количество элементов не удовлетворяет условиям!!");
        }
    }
}
