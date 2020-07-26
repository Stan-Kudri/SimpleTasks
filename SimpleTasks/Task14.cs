using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Определите, присутствует ли в тексте, заданном в виде строки, некоторое слово (различие регистра игнорируйте).*/

    class Task14 : IPerformingSimpleTask
    {
        private bool _wordInString;
        private string _str;
        private string _word;

        public void Execute()
        {
            _str = Randomazer.Intance.SentensWithPunctuation();
            _word = Randomazer.Intance.Word();
            WordPresenceInString();
            Print();

        }

        private void WordPresenceInString()
        {
            _wordInString = _str.IndexOf(_word, StringComparison.OrdinalIgnoreCase)!=-1 ? true: false ;
        }

        private void Print()
        {
            Console.WriteLine($"В строке:\n({_str});");
            if (_wordInString)
                Console.WriteLine($"Слово {_word} встречается в строке");
            else
                Console.WriteLine($"Слово {_word} не встречается в строке!");
        }
    }
}
