using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    class Task11 : ISimpleTaskExecute
    {
        private bool _orderedArray;
        private int[] _array;

        public string Name { get; } = "Задано пять произвольных целых чисел (элементы массива). Определить, является ли их расположение в массиве упорядоченным (т.е. по возрастанию или по убыванию) или неупорядоченным.";

        public void Execute()
        {
            _array = Randomazer.Intance.OneDimensionalArray(5, -10, 10);
            DefiningArrayOrdering();
            Print();
        }

        private void DefiningArrayOrdering()
        {
            if (_array.SequenceEqual(_array.OrderByDescending(s => s)) || _array.SequenceEqual(_array.OrderBy(s => s)))
                _orderedArray = true;
            else
                _orderedArray = false;
        }

        private void Print()
        {
            Console.WriteLine(_array.JoinToString(",", prefix: "Массив чисел => [", postfix: "]"));
            if ( _orderedArray == true)
                Console.WriteLine("Массив ялвляется упорядоченным");
            else
                Console.WriteLine("Массив ялвляется неупорядоченным");
        }
    }
}
