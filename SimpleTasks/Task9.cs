using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения гласных букв 
     * латинского алфавита в строку (не различая регистры). («A», «E», «I», «O», «U», «Y»)*/

    class Task9 : IPerformingSimpleTask
    {
        private double _percentVowelLetters;
        private string _str;

        public void Execute()
        {
            _str = Randomazer.Intance.String(20,40);
            VowelLettersPercentage();
            Print();
        }

        private void VowelLettersPercentage()
        {
            if(_str.Length == 0 || _str == null)
            {
                throw new Exception("Строка заданна неправильно!");
            }
            string vowel = "OAEIUY";
            int vowelLetters = 0;
            foreach (var symbol in _str.ToUpper())
            {
                if (vowel.Any(s => s == symbol))
                    vowelLetters++;
            }
            _percentVowelLetters = (float) (vowelLetters*100) / _str.Length;
        }

        private void Print()
        {
            Console.WriteLine($"Исходная строка для выполнения задачи: {_str};");
            Console.WriteLine($"Процентное вхождение гласных букв в исходную строку состовляет {_percentVowelLetters:f2} %");
        }
    }
}
