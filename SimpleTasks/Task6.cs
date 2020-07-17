using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    //В одномерном массиве из 100 чисел M[] подсчитайте сумму элементов, удовлетворяющих условию 0 < M[i] <125.
    class Task6
    {
        private int AmountNumbers;

        public void NumbersSatisfyingTheCondition(int[] array)
        {
            AmountNumbers = array.Where(s => s > 0 && s < 125).Sum();
        }

        public void Print()
        {
            Console.WriteLine($"Количество элементов, которые больше 0 и меньше 125 состовляет {AmountNumbers}");
        }
    }
}
