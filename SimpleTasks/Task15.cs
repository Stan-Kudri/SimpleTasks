using System;
using System.Linq;

namespace SimpleTasks
{
    class Task15 : ISimpleTask
    {
        private int[] _array;

        public string Name { get; } = "Задан генератором случайных чисел одномерный массив из действительных чисел. Найдите максимальное и минимальное число этого массива.";

        public void Execute()
        {
            int size = Randomazer.Intance.Number(10,30);
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
