using System;
using System.Linq;

namespace SimpleTasks
{
    class Task6 : ISimpleTask
    {
        private int _amountNumbers;
        private int[] _array;

        public string Name { get; } = "В одномерном массиве из 100 чисел M[] подсчитайте сумму элементов, удовлетворяющих условию 0 < M[i] <125.";

        public void Execute()
        {
            int arraySize = 100;
            _array = Randomazer.Intance.OneDimensionalArray(arraySize);
            PrintArray();
            NumbersSatisfyingTheCondition();
            Print();
        }

        private void PrintArray()
        {
            Console.WriteLine($"Массив чисел из 100 элементов: {_array.JoinToString(",")}");
        }

        private void NumbersSatisfyingTheCondition()
        {
            if (_array == null)
                throw new Exception("Для этого массива нельзя реализовать задачу!");

            _amountNumbers = _array.Where(s => s > 0 && s < 125).Sum();
        }

        private void Print()
        {
            Console.WriteLine($"Cумма элементов, которые больше 0 и меньше 125 состовляет {_amountNumbers}");
        }
    }
}
