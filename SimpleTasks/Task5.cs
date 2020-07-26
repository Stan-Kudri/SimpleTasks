using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    //В заданном массиве действительных чисел найдите разность между максимальным и минимальным числом.

    class Task5 : IPerformingSimpleTask
    {
        private int _difference;
        private int _maxValue;
        private int _minValue;
        private int[] _array;

        public void Execute()
        {
            int arraySize = Randomazer.Intance.Number(20);
            _array = Randomazer.Intance.OneDimensionalArray(arraySize);
            DifferenceMaxiAndMinNumber();
            Print();
        }

        private void DifferenceMaxiAndMinNumber()
        {
            if(_array.Length > 1)
            {
                _maxValue = _array.Max();
                _minValue = _array.Min();
                _difference = _maxValue - _minValue;
            }
            else
            {
                _difference = 0;
            }
        }

        private void Print()
        {
            Console.WriteLine($"Одномерный массив целых чисел: {_array.JoinToString(", ")};");
            if (_difference != 0)
                Console.WriteLine("Разница между максимальным ({0}) и минимальным ({1}) числом массива состовляет {2}",_maxValue,_minValue,_difference);
            else
                Console.WriteLine("Количество элементов не удовлетворяет условиям!!");
        }
    }
}
