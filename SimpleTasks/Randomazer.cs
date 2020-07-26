using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    class Randomazer
    {
        private static Randomazer _intance;

        private char[] _symbol;

        private string[] _words;

        private string[] _wordsWithPunctuation;

        private Random _rnd;

        public int Number(int max) => _rnd.Next(0, max);

        public int Number(int min, int max) => _rnd.Next(min, max);
        
        public static Randomazer Intance
        {
            get
            {
                if (_intance != null)
                    return _intance;
                return (_intance = new Randomazer());
            }
        }

        private Randomazer()
        {
            _symbol = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            _words = new string[] { "Кот", "Собака", "Еж", "Змея", "Волк", "Медведь", "Крот" };
            _rnd = new Random();
            _wordsWithPunctuation = _words.Concat(new[] { ", ", " ", ".", ":" }).ToArray();
        }

        public string String(int min = 50, int max = 100)
        {
            int numberLatters = _rnd.Next(min, max);
            
            StringBuilder strLatters = new StringBuilder(numberLatters);
            for (int i = 0; i < numberLatters; i++)
            {
                var item = Symbol();
                strLatters.Append(item);
            }
            return strLatters.ToString();
            // Enumerable.Range(0, numberLatters).Select(_ => Symbol()).JoinToString(string.Empty)
        }

        public T RandomItem<T>(T[] array)
        {
            var index = _rnd.Next(0, array.Length);
            return array[index];
        }

        public char Symbol() => RandomItem(_symbol);

        public int[] OneDimensionalArray(int count, int min = -150, int max = 150)
        {
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = _rnd.Next(min, max);
            }
            return array;
        }

        public string[,] TwoDimensionalArrayString(int row = 6, int column = 6)
        {
            string[,] array = new string[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = _words[_rnd.Next(0, _words.Length)];
                }
            }
            return array;
        }

        public int[,] TwoDimensionalArray(int count, int min = -20, int max = 20)
        {
            int[,] array = new int[count, count];
            for(int i  = 0; i < count; i++)
            {
                for(int j = 0; j < count; j++)
                {
                    array[i, j] = _rnd.Next(min, max);
                }
            }
            return array;
        }

        public string Word()
        {
            return _words[_rnd.Next(0, _words.Length)];
        }

        public string Sentens()
        {
            return SentensCore(_words);
        }

        public string SentensWithPunctuation()
        {
            return SentensCore(_wordsWithPunctuation);
        }

        private string SentensCore(string[] wordsArray)
        {
            // https://github.com/bchavez/Bogus
            int numberWords = Number(20, 30);
            StringBuilder sentens = new StringBuilder(240);
            for (int i = 0; i < numberWords; i++)
            {
                var randomWord = RandomItem(wordsArray);

                sentens
                    .Append(randomWord)
                    .Append(" ");
            }
            return sentens.ToString();
            // Enumerable.Range(0, numberWords).Select(_ => RandomItem(words)).JoinToString(" ")
        }
    }
}
