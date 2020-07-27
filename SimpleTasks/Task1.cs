using System;
using System.Linq;

namespace SimpleTasks
{
    class Task1 : ISimpleTask
    {
        private float _percent;
        private string _str;
        private char _symbol;

        public string Name { get; } = "Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения заданного символа в строку.";

        public void Execute()
        {
            _str = Randomazer.Intance.String();
            _symbol = Randomazer.Intance.Symbol();
            PercentageRatio();
            Print();
        }        

        private void PercentageRatio()
        {
            if (string.IsNullOrEmpty(_str))
                _percent = 0;
            var count = _str.Count(s => s == _symbol);
            _percent = (count * 100)/ (float)_str.Length;
        }

        private void Print()
        {
            Console.WriteLine($"Процент вхождения ({_symbol}) в строке:\n{_str} \nCостовляет : {_percent:f2} %");
        }

    }
    
}


