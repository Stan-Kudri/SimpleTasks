using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Определите, присутствует ли в тексте, заданном в виде строки, некоторое слово (различие регистра игнорируйте).*/

    class Task14
    {
        private bool WordInString;
        private string Word;

        public void WordPresenceInString(string str, string word)
        {
            Word = word;
            WordInString = str.IndexOf(word, StringComparison.OrdinalIgnoreCase)!=-1 ? true: false ;
        }

        public void Print()
        {
            if(WordInString)
                Console.WriteLine($"В строке встречается слово {Word}");
            else
                Console.WriteLine($"Слово {Word} не встречается в строке!");
        }
    }
}
