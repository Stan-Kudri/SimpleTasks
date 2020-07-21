using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    /*Задан одномерный массив целых чисел. Образуйте из него два отсортированных по возрастанию массива,
    содержащих четные и нечетные числа. Подсказка: четное число делится на 2 без остатка.*/ 

    class Task4
    {
        private List<int> Even = new List<int>();
        private List<int> Odd = new List<int>();

        public void SplitArray(int[] array)
        {
            if(array==null)
            {
                throw new Exception("Такой массив нельзя отсортировать");
            }
            foreach (var split in array)
            {
                if (split % 2 != 0)
                {
                    Odd.Add(split);
                }
                else
                {
                    Even.Add(split);
                }
            }
            Odd.Sort();
            Even.Sort();            
        }

        public void Print()
        {
            Console.WriteLine(Even.JoinToString(",", prefix: "Even = [", postfix: "]"));
            Console.WriteLine(Odd.JoinToString(",", prefix: "Odd = [", postfix: "]"));
        }
        
        /*public (int[] Even, int[] Odd) SplitArray(int[] arrayForSplit)
        {
            arrayForSplit.GroupBy(s => s % 2 == 0).OrderBy(s => s);

        }*/
    }
}
