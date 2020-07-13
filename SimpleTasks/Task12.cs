using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Задан массив действительных чисел из N элементов (используйте генератор случайных чисел).
     * Определить количество элементов, значения которых находятся вне диапазона от -10 до +10.*/

    class Task12
    {
        static private Random rnd = new Random();

        private int[] array;

        private int NumbersNoRange;

        public Task12(int count = 50)
        {
            array = new int[count];
            for(int i = 0; i < count; i++)
            {
                array[i] = rnd.Next(-100,100);
            }
        }

        public void NumbersOutRange()
        {
            NumbersNoRange = array.Where(s => s < -10 || s > 10).Count();
        }

        public void Print()
        {
            Console.WriteLine(array.JoinToString(",", prefix: "Массив чисел => [", postfix: "]"));
            Console.WriteLine("Количество чисел вне диапазона состовляет {0}", NumbersNoRange);
        }

    }
}
