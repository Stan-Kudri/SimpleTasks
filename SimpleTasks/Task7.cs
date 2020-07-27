using System;

namespace SimpleTasks
{
    class Task7 : ISimpleTask
    {
        private bool _stringPalindrom;
        private string _str;

        public string Name { get; } = "Определите, является ли исходная строка символов палиндромом (читается одинаково с начала и с конца). Регистры символов и пробелы игнорируйте.";

        public void Execute()
        {
            _str = Randomazer.Intance.String();
            PalindromeString();
            Print();
        }

        private void PalindromeString()
        {
            char[] symbolStr = _str.ToCharArray();
            int numberCharacters = symbolStr.Length;

            if (_str == null && numberCharacters == 0)
                throw new Exception("Строка задана не верно!");
           
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
            if (_stringPalindrom == true)
            {
                Console.WriteLine("Исходная строка является полиндромной");
            }
            else
            {
                Console.WriteLine("Исходная строка является не полиндромной");
            }
        }
    }
}
