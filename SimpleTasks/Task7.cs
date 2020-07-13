using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Определите, является ли исходная строка символов палиндромом (читается одинаково с начала и с конца).
     Регистры символов и пробелы игнорируйте.*/

    class Task7
    {
        private bool StringPalindrom;

        public void PalindromeString(string str)
        {
            StringPalindrom = str.EndsWith(str);            
        }

        public void Print()
        {
            if(StringPalindrom == true)
                Console.WriteLine("Исходная строка является полиндромной");
            else
                Console.WriteLine("Исходная строка является не полиндромной");
        }
    }
}
