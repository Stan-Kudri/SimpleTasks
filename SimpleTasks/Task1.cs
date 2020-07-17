using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{

    //Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения заданного символа в строку.

    class Task1
    {
        private double Percent;

        public void PercentageRatio(string str, char symbol)
        {
            if (string.IsNullOrEmpty(str))
                Percent = 0;

            var count = str.Count(s => s == symbol);
            Console.WriteLine(count + "        " + Percent + "         " + str.Length);
            Percent = count / str.Length;
            Console.WriteLine(Percent);
        }

        public void Print()
        {
            Console.WriteLine($"Процент вхождения символа состовляет : {Percent:f2}");
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

