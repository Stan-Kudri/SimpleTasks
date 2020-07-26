using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{

    //Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения заданного символа в строку.

    class Task1:IPerformingSimpleTask
    {
        private float _percent;
        private string _str;
        private char _symbol;

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
            _percent = (float) (count * 100 )/ _str.Length;
        }

        private void Print()
        {
            Console.WriteLine($"Процент вхождения ({_symbol}) в строке:\n{_str} \nCостовляет : {_percent:f2} %");
        }

    }
    
}

        /*public Dictionary<char, int> GetCharRepeatCount(string str)
        {
            return str
                .GroupBy(s => s)
                .ToDictionary(s => s.Key, s => s.Count());
        }
        */

