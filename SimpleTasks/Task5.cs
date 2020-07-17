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
        private int MaxValue;
        private int MinValue;

        public void DifferenceMaxiAndMinNumber(int[] array)
        {
            if(array.Length > 1)
            {
                MaxValue = array.Max();
                MinValue = array.Min();
                Difference = MaxValue - MinValue;
            }
            else
            {
                Difference = 0;
            }
        }

        public void Print()
        {
            if (Difference != 0)
                Console.WriteLine("Разница между максимальным ({0}) и минимальным ({1}) числом массива состовляет {2}",MaxValue,MinValue,Difference);
            else
                Console.WriteLine("Количество элементов не удовлетворяет условиям!!");
        }
    }
}
