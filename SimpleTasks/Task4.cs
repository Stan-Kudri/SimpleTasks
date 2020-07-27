using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTasks
{
    class Task4 : ISimpleTask
    {
        private List<int> _even = new List<int>();
        private List<int> _odd = new List<int>();
        private int[] _array;

        public string Name { get; } = "Задан одномерный массив целых чисел. Образуйте из него два отсортированных по возрастанию массива, содержащих четные и нечетные числа.Подсказка: четное число делится на 2 без остатка.";

        public void Execute()
        {
            int arraySize = Randomazer.Intance.Number(10,20);
            _array = Randomazer.Intance.OneDimensionalArray(arraySize);
            SplitArray(_array);
            Print();
        }

        private void SplitArray(int[] array)
        {
            if(array==null)
                throw new Exception("Такой массив нельзя отсортировать");

            foreach (var split in array)
            {
                if (split % 2 != 0)
                {
                    _odd.Add(split);
                }
                else
                {
                    _even.Add(split);
                }
            }
            _odd.Sort();
            _even.Sort();            
        }

        private void Print()
        {
            Console.WriteLine($"Одномерный массив целых чисел: {_array.JoinToString(", ")};");
            Console.WriteLine(_even.JoinToString(",", prefix: "Even = [", postfix: "]"));
            Console.WriteLine(_odd.JoinToString(",", prefix: "Odd = [", postfix: "]"));
        }
        
    }
}
