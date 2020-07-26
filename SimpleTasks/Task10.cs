using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    class Task10 : ISimpleTaskExecute
    {
        private int _amountNumbersFromRange;
        private int[] _array;

        public string Name { get; } = "Задан массив действительных чисел из N элементов (используйте генератор случайных чисел) или передав массив. Определить количество элементов, значения которых находятся в диапазоне от -100 до +100.";

        public void Execute()
        {
            _array = Randomazer.Intance.OneDimensionalArray(60);
            NumberOfNumbersFromRange();
            Print();
        }

        private void NumberOfNumbersFromRange()
        {
            _amountNumbersFromRange = _array.Where(s => s > -100 && s < 100).Count();
        }

        private void Print()
        {
            Console.WriteLine($"Одномерный массив целых чисел: {_array.JoinToString(", ")};");
            Console.WriteLine($"Количество действительных чисел в диапазоне от -100 до 100 состовляет {_amountNumbersFromRange}");
        }
    }
}
