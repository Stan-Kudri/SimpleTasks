using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Определите, является ли исходная строка символов палиндромом (читается одинаково с начала и с конца).
     Регистры символов и пробелы игнорируйте.*/

    class Task7 : IPerformingSimpleTask
    {
        private bool _stringPalindrom;
        private string _str;

        public void Execute()
        {
            _str = Randomazer.Intance.String();
            PalindromeString();
            Print();
        }

        private void PalindromeString()
        {
            if (_str == null)
                throw new Exception("Строка равна null!");
            char[] symbolStr = _str.ToCharArray();
            int numberCharacters = symbolStr.Length;
            if(numberCharacters==0)
            {
                throw new Exception("Строка не содержит символов!");
            }
            _stringPalindrom = true;
            for (int i = 0; i < numberCharacters/2; i++)
            {
                if (symbolStr[i] != symbolStr[numberCharacters - i-1])
                {
                    _stringPalindrom = false;
                }

            }
        }

        private void Print()
        {
            Console.WriteLine($"Строка для проверки на полиндромность: {_str}");
            if(_stringPalindrom == true)
                Console.WriteLine("Исходная строка является полиндромной");
            else
                Console.WriteLine("Исходная строка является не полиндромной");
        }
    }
}
