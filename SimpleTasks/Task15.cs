using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Задан генератором случайных чисел одномерный массив из действительных чисел. Найдите максимальное и минимальное число этого массива.*/

    class Task15
    {
        static private Random rnd = new Random();

        private int[] array;

        public Task15(int value = 10)
        {
            array = new int[10];
            for (int i = 0; i < value; i++)
                array[i] = rnd.Next(-10,10);
        }

        public void PrintArray()
        {
            Console.WriteLine(array.JoinToString(",", prefix: "Массив чисел => [", postfix: "]"));
        }

        public void OutputTask()
        {
            Console.WriteLine($"Максимальное значение массива => {array.Max()}");
            Console.WriteLine($"Минимальное значение массива => {array.Min()}");
        }
    }
}
