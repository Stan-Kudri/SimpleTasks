using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Задан генератором случайных чисел одномерный массив из действительных чисел. Найдите максимальное и минимальное число этого массива.*/

    class Task15 : IPerformingSimpleTask
    {

        private int[] _array;

        public void Execute()
        {
            int size = Randomazer.Intance.Number(30);
            _array = Randomazer.Intance.OneDimensionalArray(size);
            PrintArray();
            Print();
        }
        

        public void PrintArray()
        {
            Console.WriteLine(_array.JoinToString(",", prefix: "Массив чисел => [", postfix: "]"));
        }

        public void Print()
        {
            Console.WriteLine($"Максимальное значение массива => {_array.Max()}");
            Console.WriteLine($"Минимальное значение массива => {_array.Min()}");
        }
    }
}
