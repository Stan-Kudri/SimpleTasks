﻿using System;
using System.Linq;

namespace SimpleTasks
{
    class Task12 : ISimpleTask
    {
        private int[] _array;
        private int _numbersNoRange;

        public string Name { get; } = "Задан массив действительных чисел из N элементов (используйте генератор случайных чисел). Определить количество элементов, значения которых находятся вне диапазона от -10 до +10.";

        public void Execute()
        {
            int size = Randomazer.Intance.Number(30);
            _array = Randomazer.Intance.OneDimensionalArray(size);
            NumbersOutRange();
            Print();
        }

        private void NumbersOutRange()
        {
            _numbersNoRange = _array.Where(s => s < -10 || s > 10).Count();
        }

        private void Print()
        {
            Console.WriteLine(_array.JoinToString(",", prefix: "Массив чисел => [", postfix: "]"));
            Console.WriteLine("Количество чисел вне диапазона от -10 до +10 состовляет {0}", _numbersNoRange);
        }

    }
}
