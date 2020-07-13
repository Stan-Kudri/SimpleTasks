using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    // В заданной строке текста определите количество слов. Каждое слово отделено друг от друга пробелом  и знаками.

    class Task3
    {
        private int wordCount;
        
        public void WordCount(string str)
        {
            char[] symbol = new char[] { ' ', ';', ':', '.', ',' };
            wordCount = str.Split(symbol).Length;
        }

        public void Print()
        {
            Console.WriteLine($"Количество слов введенной строке равно {wordCount}");
        }
    }
}
