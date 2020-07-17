using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Задан массив действительных чисел из N элементов (используйте генератор случайных чисел) или передав массив.
     * Определить количество элементов, значения которых находятся в диапазоне от -100 до +100.*/

    class Task10
    {
        private int AmountNumbersFromRange;
        
        public void NumberOfNumbersFromRange(int[] array)
        {
            AmountNumbersFromRange = array.Where(s => s > -100 && s < 100).Count();
        }

        public void Print()
        {
            Console.WriteLine($"Количество действительных чисел в диапазоне от -100 до 100 состовляет {AmountNumbersFromRange}");
        }
    }
}
