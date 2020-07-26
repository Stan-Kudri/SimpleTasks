using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    // В заданной строке текста определите количество слов. Каждое слово отделено друг от друга пробелом  и знаками.

    class Task3 : IPerformingSimpleTask
    {
        private int _wordCount;
        private string _str;

        public void Execute()
        {
            _str = Randomazer.Intance.SentensWithPunctuation();
            WordCount();
            Print();
        }

        private void WordCount()
        {
            if (_str.Length == 0 || _str == null)
            {
                throw new Exception("Строка должна состоять из символов");
            }
            char[] symbol = new char[] { ' ', ';', ':', '.', ',' };
            _wordCount = _str.Split(symbol, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        private void Print()
        {
            Console.WriteLine($"Строка для выполнения задания: {_str};");
            Console.WriteLine($"Количество слов введенной строке равно {_wordCount}");
        }
    }
}
