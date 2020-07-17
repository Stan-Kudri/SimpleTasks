using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения гласных букв 
     * латинского алфавита в строку (не различая регистры). («A», «E», «I», «O», «U», «Y»)*/

    class Task9
    {
        public double PercentVowelLetters;

        public void VowelLettersPercentage(string str)
        {
            if(str.Length == 0)
            {
                throw new Exception("Строка не содержит символов!");
            }
            string vowel = "OAEIUY";
            int vowelLetters = 0;
            foreach (var symbol in str.ToUpper())
            {
                if (vowel.Any(s => s == symbol))
                    vowelLetters++;
            }
            PercentVowelLetters =(float) (vowelLetters*100) / str.Length;
        }

        public void Print()
        {
            Console.WriteLine($"Процентное вхождение гласных букв в исходную строку состовляет {PercentVowelLetters:f2} %");
        }
    }
}
